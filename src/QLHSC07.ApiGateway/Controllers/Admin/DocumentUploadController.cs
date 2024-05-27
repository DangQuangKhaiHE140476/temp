using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Extensions;
using Microsoft.Extensions.DependencyInjection;
using QLHSC07.Services.Interfaces;
using QLHSC07.CORE.FileService;
using QLHSC07.ApiGateway.Service.Worker;
using QLHSC07.ApiGateway.Service.SchedulerService;
using QLHSC07.Model.DocumentUpload;
using QLHSC07.CORE;
using QLHSC07.CORE.Resource;
using QLHSC07.CORE.Helper;
using QLHSC07.Model.User;
using QLHSC07.CORE.Enum;
using Microsoft.AspNetCore.WebUtilities;
using System.Text;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Globalization;
using System.Net;

namespace QLHSC07.ApiGateway.Controllers.Admin
{
    [Route("api/admin/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class DocumentUploadController : ControllerBase
    {
        private readonly IDocumentUploadService _documentUploadService;
        private readonly IFileService _fileService;
        private readonly IHostEnvironment _env;
        private readonly IWorkerService _workerService;
        private readonly ISecurityMatrixService _securityMatrixService;
        private readonly IServiceScopeFactory _serviceScopeFactory;
        private readonly IUserService _userService;

        public DocumentUploadController(IDocumentUploadService documentUploadService, IFileService fileService,
        IHostEnvironment env, IWorkerService workerService, ISecurityMatrixService securityMatrixService, 
        IServiceScopeFactory serviceScopeFactory, IUserService userService)
        {
            _documentUploadService = documentUploadService;
            _fileService = fileService;
            _env = env;
            _workerService = workerService;
            _securityMatrixService = securityMatrixService;
            _serviceScopeFactory = serviceScopeFactory;
            _userService = userService;
        }

        [HttpPost]
        [ActionName("CreateDocumentFolder")]
        public ActionResult CreateDocumentFolder([FromBody] CreateFolderDto model)
        {
            var user = _workerService.GetCurrentUser();
            //var permission = false;
            //foreach (var role in user.Roles)
            //{
            //    var check = _securityMatrixService.CheckPermission(role.Id, ActionEnum.CREATE.GetDisplayName(),
            //        RoleHelper.Screen.DocumentManagement);
            //    if (check || role.Code == RoleHelper.Admin) permission = true;
            //}
            //if (permission == false)
            //{
            //    return BadRequest(new ResponseErrorData
            //    {
            //        ErrorMessage = StringMessage.ErrorMessages.CreateDenied,
            //        ErrorType = ErrorTypeConstant.NoPermission
            //    });
            //}
            var regex = new Regex(@"^[\w\-. ]+$");
            if (!regex.IsMatch(model.FolderName))
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorMessage = StringMessage.ErrorMessages.NameIsNotValid,
                    ErrorType = ErrorTypeConstant.NameIsNotValid
                });
            }
            if (string.IsNullOrEmpty(model.TargetPath))
            {
                model.TargetPath = "Uploads";
            }
            var message = _documentUploadService.CheckDuplicateDocument(null,model.FolderName,0,model.ParentId,null);
            if (!string.IsNullOrEmpty(message))
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.FileExisted,
                    ErrorMessage = message
                });
            }
            var path = _fileService.CreateFolder(model.TargetPath, model.FolderName);
            var isCreated = _documentUploadService.CreateFolder(model.ParentId, path, model.FolderName, user.Email);
            if (!isCreated)
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.ErrorProcess,
                    ErrorMessage = StringMessage.ErrorMessages.ErrorProcess
                });
            }

            return Ok(new ResponseData
            {
                Content = true
            });
        }
        
        [AllowAnonymous]
        [HttpPost]
        [ActionName("UploadImage")]
        public async Task<ActionResult> UploadImage()
        {
            try
            {
                var url = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host}/";
                var files = Request.Form.Files;
                var user = _workerService.GetCurrentUser();
                var listFile = new List<Object>();
                var path = string.Empty;
                if (files.Count > 0)
                {
                    foreach (var item in files)
                    {
                        var folder = Path.Combine(Constant.PathName.GeneralFolder, "temp");
                        path = await _fileService.SaveFileAsync(Constant.PathName.GeneralFolder, item);
                        path = await ImageOptimization.ResizeImage(_env, path, Constant.PathName.GeneralFolder, false, 800, 0);
                        if (!string.IsNullOrEmpty(path))
                            listFile.Add(new
                            {
                                url = $"{url}{path.Replace("\\", "/")}",
                                name = Path.GetFileName(path),
                                size = item.Length
                            });

                        //await ImageOptimization.ResizeImage(path, Path.Combine(_env.ContentRootPath, Constant.PathName.News, "temp"), false,800, 0);
                    }
                }

                return Ok(new
                {
                    result = listFile
                });
            }
            catch(Exception ex)
            {
                return Ok(new {
                    errorMessage=ex.Message
                });
            }
        }

        [HttpPost]
        [ActionName("UploadDocument")]
        public async Task<ActionResult> UploadDocument([FromForm] UploadDocumentDto model, IFormFile[] UploadFile)
        {
            var user = _workerService.GetCurrentUser();
            for (var counter = 0; counter < UploadFile.Length; counter++)
            {
                if (UploadFile[counter].FileName.Length > 100)
                {
                    return BadRequest(new ResponseErrorData
                    {
                        ErrorMessage = StringMessage.ErrorMessages.FileNameTooLong,
                        ErrorType = ErrorTypeConstant.FileNameTooLong
                    });
                }
                var message = _documentUploadService.CheckDuplicateDocument(null,UploadFile[counter].FileName,1,model.ParentId,null);
                if (!string.IsNullOrEmpty(message))
                {
                    return BadRequest(new ResponseErrorData
                    {
                        ErrorType = ErrorTypeConstant.FileExisted,
                        ErrorMessage = message
                    });
                }
            }

            for (var counter = 0; counter < UploadFile.Length; counter++)
            {
                if (string.IsNullOrEmpty(model.UploadFolderPath) && model.ParentId == 0)
                {
                    model.UploadFolderPath = "Uploads";
                }

                await _fileService.SaveFileAsyncCurrentName(model.UploadFolderPath, UploadFile[counter]);
                var dir = Path.Combine(model.UploadFolderPath, UploadFile[counter].FileName);
                var fullPath = Path.Combine(_env.ContentRootPath, dir);
                var data = new DocumentUploadDto
                {
                    Name = UploadFile[counter].FileName,
                    ParentId = model.ParentId,
                    Path = dir,
                    Type = 1, //have constant file but i'm lazy to findout. type 1 = file
                    FileExtensionId = _documentUploadService.GetFileExtIdByPath(fullPath),
                    AllowedModify = model.UploadFolderPath.Contains(@"Uploads\cgis")
                };
                var fileId = _documentUploadService.SaveFile(data, user?.Email);
                if (fileId == null)
                    return BadRequest(new ResponseErrorData
                    {
                        ErrorMessage = StringMessage.ErrorMessages.ErrorProcess,
                        ErrorType = ErrorTypeConstant.ErrorProcess
                    });
            }

            return Ok(new ResponseData
            {
                Content = true
            });
        }
        
        //[HttpGet]
        //[ActionName("DownloadFileBinary")]
        //public ActionResult DownloadFileBinary(long id)
        //{
        //    CurrentUserDto currentUserModel = _workerService.GetCurrentUser();
        //    if (currentUserModel == null)
        //    {
        //        return BadRequest(new ResponseErrorData
        //        {
        //            ErrorType = ErrorTypeConstant.NoPermission,
        //            ErrorMessage = StringMessage.ErrorMessages.NoPermission
        //        });
        //    }
        //    var filePath = _planningService.DownloadFileBinary(id,currentUserModel);
        //    if (filePath == null)
        //    {
        //        return BadRequest(new ResponseErrorData
        //        {
        //            ErrorType = ErrorTypeConstant.DataNotValid,
        //            ErrorMessage = StringMessage.ErrorMessages.FileIsNotExist
        //        });
        //    }
        //    if (filePath == string.Empty)
        //    {
        //        return BadRequest(new ResponseErrorData
        //        {
        //            ErrorType = ErrorTypeConstant.DownloadDenied,
        //            ErrorMessage = StringMessage.ErrorMessages.DownloadCmsDenied
        //        });
        //    }
        //    var byteArray = System.IO.File.ReadAllBytes(filePath);
        //    return new FileContentResult(byteArray, "application/octet-stream");
        //}

        [HttpPost]
        [ActionName("DownloadDocument")]
        public async Task<ActionResult> DownloadDocument([FromBody] List<DownloadDocumentDto> model)
        {
            var user = _workerService.GetCurrentUser();
            var result = _documentUploadService.CheckDocument(model, user);
            if (!string.IsNullOrEmpty(result))
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorMessage = string.Format(StringMessage.ErrorMessages.DownloadDenied, result),
                    ErrorType = ErrorTypeConstant.DownloadDenied
                });
            }
            var folder = "download_" + Guid.NewGuid();
            var folderPath = Path.Combine(_env.ContentRootPath, folder);
            var zipName = folder + ".zip";
            Directory.CreateDirectory(folderPath);
            var compressPath = Path.Combine(_env.ContentRootPath, zipName);
            foreach (var file in model)
            {
                var path = Path.Combine(_env.ContentRootPath, file.FilePath ?? string.Empty);
                if (string.IsNullOrEmpty(file.FilePath) || !Directory.Exists(path) && !System.IO.File.Exists(path))
                {
                    return BadRequest(new ResponseErrorData
                    {
                        ErrorMessage = StringMessage.ErrorMessages.FileIsNotExist,
                        ErrorType = ErrorTypeConstant.FileIsNotExist
                    });
                }
            }
            foreach (var file in model)
            {
                file.FilePath = Path.Combine(_env.ContentRootPath, file.FilePath);
                if (System.IO.File.Exists(file.FilePath))
                {
                    System.IO.File.Copy(file.FilePath, Path.Combine(folderPath, Path.GetFileName(file.FilePath)), true);
                }
                else if (Directory.Exists(file.FilePath))
                {
                    var name = Path.GetFileName(file.FilePath);
                    ZipFile.CreateFromDirectory(file.FilePath, Path.Combine(folderPath, name + ".zip"));
                }
                else
                {
                    return BadRequest(new ResponseErrorData
                    {
                        ErrorMessage = StringMessage.ErrorMessages.FileIsNotExist,
                        ErrorType = ErrorTypeConstant.FileIsNotExist
                    });
                }
            }
            ZipFile.CreateFromDirectory(folderPath, compressPath);
            var byteArray = await System.IO.File.ReadAllBytesAsync(compressPath);
            System.IO.File.Delete(compressPath);
            Directory.Delete(folderPath, true);
            return File(byteArray, "application/octet-stream", zipName);
        }

        [HttpPost]
        [ActionName("DeleteDocument")]
        public ActionResult DeleteDocument([FromBody] List<DeleteDocumentDto> model)
        {
            var user = _workerService.GetCurrentUser();
            var permission = false;

            if (permission == false)
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorMessage = StringMessage.ErrorMessages.DeleteDenied,
                    ErrorType = ErrorTypeConstant.NoPermission
                });
            }

            var type = 0;
            var path = string.Empty;
            foreach (var document in model)
            {
                var isDeleted = _documentUploadService.Delete(document.Id, ref type, ref path);
                if (!isDeleted)
                    return BadRequest(new ResponseErrorData
                    {
                        ErrorMessage = StringMessage.ErrorMessages.ErrorProcess,
                        ErrorType = ErrorTypeConstant.ErrorProcess
                    });
                switch (type)
                {
                    case 0:
                        if (Directory.Exists(path)) Directory.Delete(path, true);
                        break;
                    case 1:
                        if (System.IO.File.Exists(path)) System.IO.File.Delete(path);
                        break;
                }
            }

            return Ok(new ResponseData
            {
                Content = true
            });
        }

        [HttpGet]
        [ActionName("GetAllDocumentByParentId")]
        public ActionResult GetAllDocumentByParentId(long parentId, string type)
        {
            var data = _documentUploadService.GetAllDocumentByParentId(parentId, type);
            return Ok(new ResponseData
            {
                Content = data
            });
        }

        [HttpGet]
        [ActionName("GetParentDocumentById")]
        public ActionResult GetParentDocumentById(long id)
        {
            var data = _documentUploadService.GetParentDocumentById(id);
            return Ok(new ResponseData
            {
                Content = data
            });
        }

        [HttpPost]
        [ActionName("MoveDocument")]
        public ActionResult MoveDocument([FromBody] List<MoveDocumentDto> model)
        {
            var user = _workerService.GetCurrentUser();
            foreach (var doc in model)
            {
                var message = _documentUploadService.CheckDuplicateDocument(doc.DocumentId, null, null, doc.TargetParentId, null);
                if (!string.IsNullOrEmpty(message))
                {
                    return BadRequest(new ResponseErrorData
                    {
                        ErrorType = ErrorTypeConstant.FileExisted,
                        ErrorMessage = message
                    });
                }
                var documentPath = _documentUploadService.GetFilePathById(doc.DocumentId);
                var documentName = Path.GetFileName(documentPath);
                var source = Path.Combine(_env.ContentRootPath, documentPath);
                var target = Path.Combine(_env.ContentRootPath, doc.TargetFolderPath, documentName);
                if (documentPath == Path.Combine(doc.TargetFolderPath, documentName))
                    return Ok(new ResponseData
                    {
                        Content = new
                        {
                            Status = true
                        }
                    });
                if (string.IsNullOrEmpty(doc.TargetFolderPath)) doc.TargetFolderPath = "Uploads";
                if ((System.IO.File.Exists(source) || Directory.Exists(source))
                    && Directory.Exists(Path.Combine(_env.ContentRootPath, doc.TargetFolderPath)))
                {
                    Directory.Move(source, target);
                }
                var isChangedPath = _documentUploadService.MoveDocumentUpdatePath(doc.DocumentId, doc.TargetFolderPath);
                var isChangedParentId = _documentUploadService.MoveDocumentUpdateParentId(doc.DocumentId, doc.TargetParentId, user?.Email);
                if (!isChangedPath || !isChangedParentId)
                {
                    return BadRequest(new ResponseErrorData
                    {
                        ErrorMessage = StringMessage.ErrorMessages.FileIsNotExist,
                        ErrorType = ErrorTypeConstant.FileEmpty
                    });
                }
            }
            return Ok(new ResponseData
            {
                Content = true
            });
        }

        [HttpGet]
        [ActionName("SearchDocument")]
        public ActionResult SearchDocument(string fileName, long? parentId)
        {
            var data = _documentUploadService.SearchDocument(fileName, parentId);
            return Ok(new ResponseData
            {
                Content = data
            });
        }

        [HttpPost]
        [ActionName("RenameDocument")]
        public ActionResult RenameDocument(long documentId, string newFileName)
        {
            var user = _workerService.GetCurrentUser();
            var message = _documentUploadService.CheckDuplicateDocument(documentId, null, null, null, newFileName);
            if (!string.IsNullOrEmpty(message))
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.FileExisted,
                    ErrorMessage = message
                });
            }
            var isRenamed = _documentUploadService.RenameDocument(documentId, newFileName, user?.Email);
            if (isRenamed)
            {
                return Ok(new ResponseData
                {
                    Content = new
                    {
                        Status = true
                    }
                });
            }

            return BadRequest(new ResponseErrorData
            {
                ErrorMessage = StringMessage.ErrorMessages.FileIsNotExist,
                ErrorType = ErrorTypeConstant.FileEmpty
            });
        }

        [HttpPost]
        [ActionName("UploadFile")]
        public async Task<ActionResult<int>> UploadFile(IFormFile file)
        {
            if (file == null || file.Length <= 0)
                return BadRequest(new ResponseErrorData
                {
                    ErrorMessage = $"{ StringMessage.ErrorMessages.FileEmpty}",
                    ErrorType = ErrorTypeConstant.FileTooLarge
                });

            var userId = _workerService.GetCurrentUser()?.Id;
            var user = _userService.GetByUserid(userId);
            if (user == null) return BadRequest(
                new ResponseErrorData
                {
                    ErrorMessage = $"Access Denied",
                    ErrorType = ErrorTypeConstant.AccessDenied
                }
                );
            var extension = string.Empty;
            var returnPath = string.Empty;
            long? fileId;

            #region check file
            extension = Path.GetExtension(file.FileName);
            if (extension == null) return BadRequest(new ResponseErrorData
            {
                ErrorMessage = $"{ StringMessage.ErrorMessages.FileNotAllow}",
                ErrorType = ErrorTypeConstant.FileNotAllow
            });
            if (file.Length > Constant.FileSizeMax) //2Mb
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorMessage = $"File {file.FileName} { StringMessage.ErrorMessages.FileTooLarge}. Dung lượng file phải < {Constant.FileSizeMax / 1024 / 1024}MB",
                    ErrorType = ErrorTypeConstant.FileTooLarge
                });
            }

            if (file.FileName.Length > Constant.FileNameMaxLength)
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorMessage = $"{StringMessage.ErrorMessages.FileNameTooLong}. Tên file phải <= {Constant.FileNameMaxLength} ký tự",
                    ErrorType = ErrorTypeConstant.FileNameTooLong
                });
            }
            #endregion
         
            returnPath = await _fileService.SaveFileAsync(Constant.PathName.RecordsFolder, file);
            fileId = await _documentUploadService.UploadAndSave(file, user.Email, returnPath);

            return Ok(new ResponseData
            {
                Content = new
                {
                    FileId = fileId,
                    Status = true
                }
            });
        }

        [HttpPost]
        [ActionName("UploadFileStream")]
        [RequestFormLimits(MultipartBodyLengthLimit = 1073741824)]
        [RequestSizeLimit(1073741824)]
        //[DisableFormValueModelBinding]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> UploadFileStream()
        {
            string[] _permittedExtensions = { ".txt", ".png", ".jpg", ".jpeg", ".gif", ".pdf", ".dwg", ".rar", ".zip",".xls", ".xlsx", ".doc", ".docx", ".csv" };
            var _fileSizeLimit = 1073741824;
            FormOptions _defaultFormOptions = new FormOptions();
            string _targetFilePath = string.Empty;
            // Accumulate the form data key-value pairs in the request (formAccumulator).
            var formAccumulator = new KeyValueAccumulator();
            List<ContentDispositionHeaderValue> contentDispositionHeaderValues = new List<ContentDispositionHeaderValue>();
            List<byte[]> streamedFileContents = new List<byte[]>();

            if (!MultipartRequestHelper.IsMultipartContentType(Request.ContentType))
            {
                ModelState.AddModelError("File",
                    $"The request couldn't be processed (Error 1).");
                // Log error

                return BadRequest(ModelState);
            }

            var boundary = MultipartRequestHelper.GetBoundary(
                    MediaTypeHeaderValue.Parse(Request.ContentType),
                    _defaultFormOptions.MultipartBoundaryLengthLimit);
            var reader = new MultipartReader(boundary, HttpContext.Request.Body);
            var section = await reader.ReadNextSectionAsync();

            while (section != null)
            {
                var hasContentDispositionHeader =
                    ContentDispositionHeaderValue.TryParse(
                        section.ContentDisposition, out var contentDisposition);

                if (hasContentDispositionHeader)
                {
                    // Check form data content
                    if (MultipartRequestHelper.HasFormDataContentDisposition(contentDisposition))
                    {
                        // Don't limit the key name length because the 
                        // multipart headers length limit is already in effect.
                        var key = HeaderUtilities
                            .RemoveQuotes(contentDisposition.Name).Value;
                        var encoding = GetEncoding(section);

                        if (encoding == null)
                        {
                            ModelState.AddModelError("File",
                                $"The request couldn't be processed (Error 2).");
                            // Log error

                            return BadRequest(ModelState);
                        }

                        using (var streamReader = new StreamReader(
                            section.Body,
                            encoding,
                            detectEncodingFromByteOrderMarks: true,
                            bufferSize: 1024,
                            leaveOpen: true))
                        {
                            // The value length limit is enforced by 
                            // MultipartBodyLengthLimit
                            var value = await streamReader.ReadToEndAsync();

                            if (string.Equals(value, "undefined",
                                StringComparison.OrdinalIgnoreCase))
                            {
                                value = string.Empty;
                            }

                            formAccumulator.Append(key, value);

                            if (formAccumulator.ValueCount >
                                _defaultFormOptions.ValueCountLimit)
                            {
                                // Form key count limit of 
                                // _defaultFormOptions.ValueCountLimit 
                                // is exceeded.
                                ModelState.AddModelError("File",
                                    $"The request couldn't be processed (Error 3).");
                                // Log error

                                return BadRequest(ModelState);
                            }
                        }
                    }
                    else if (MultipartRequestHelper
                        .HasFileContentDisposition(contentDisposition))
                    {
                        contentDispositionHeaderValues.Add(contentDisposition);
                        // **WARNING!**
                        // In the following example, the file is saved without
                        // scanning the file's contents. In most production
                        // scenarios, an anti-virus/anti-malware scanner API
                        // is used on the file before making the file available
                        // for download or for use by other systems. 
                        // For more information, see the topic that accompanies 
                        // this sample.
                        var streamedFileContent = await FileHelpers.ProcessStreamedFile(section, contentDisposition, ModelState,
                        _permittedExtensions, _fileSizeLimit);
                        if (!ModelState.IsValid)
                        {
                            return BadRequest(ModelState);
                        }
                        streamedFileContents.Add(streamedFileContent);
                    }
                }

                // Drain any remaining section body that hasn't been consumed and
                // read the headers for the next section.
                section = await reader.ReadNextSectionAsync();
            }

            //bind data to model
            var formValueProvider = new FormValueProvider(
                BindingSource.Form,
                new FormCollection(formAccumulator.GetResults()),
                CultureInfo.CurrentCulture);

            _targetFilePath = Constant.PathName.RecordsFolder; // string.Format(Constant.PathName.RecordsFolder, recordCode);
            if (!Directory.Exists(_targetFilePath))
            {
                Directory.CreateDirectory(_targetFilePath);
            }
            if (contentDispositionHeaderValues.Count > 0 && streamedFileContents.Count > 0)
            {
                var fileId = await SaveStreaming(_targetFilePath, contentDispositionHeaderValues[0], streamedFileContents[0]);
                if (fileId == null)
                    return BadRequest(new ResponseErrorData
                    {
                        ErrorMessage = StringMessage.ErrorMessages.ErrorProcess,
                        ErrorType = ErrorTypeConstant.ErrorProcess
                    });
                else
                {
                    return Ok(new ResponseData
                    {
                        Content = new
                        {
                            Content = new
                            {
                                FileId = fileId,
                                Status = true
                            }
                        }
                    });
                }
            }
            else
            {
                ModelState.AddModelError("File",
                $"Không có file nào được chọn");
                // Log error

                return BadRequest(ModelState);
            }
        }

        public class MyMultipartSection : MultipartSection
        {
            public new string ContentDisposition { get; set; }
            public new string ContentType { get; set; }
        }
        private static Encoding GetEncoding(MultipartSection section)
        {
            var hasMediaTypeHeader =
                MediaTypeHeaderValue.TryParse(section.ContentType, out var mediaType);

            // UTF-7 is insecure and shouldn't be honored. UTF-8 succeeds in 
            // most cases.
            if (!hasMediaTypeHeader || Encoding.UTF7.Equals(mediaType.Encoding))
            {
                return Encoding.UTF8;
            }

            return mediaType.Encoding;
        }

        protected async Task<long?> SaveStreaming(string uploadPath, ContentDispositionHeaderValue contentDisposition,
            byte[] streamedFileContent)
        {
            // Don't trust the file name sent by the client. To display
            // the file name, HTML-encode the value.
            var trustedFileNameForDisplay = WebUtility.HtmlEncode(
                    contentDisposition.FileName.Value);
            var trustedFileNameForFileStorage = Path.GetRandomFileName() + Path.GetExtension(trustedFileNameForDisplay);

            using (var targetStream = System.IO.File.Create(
                Path.Combine(uploadPath, trustedFileNameForFileStorage)))
            {
                await targetStream.WriteAsync(streamedFileContent);

                var dir = Path.Combine(uploadPath, trustedFileNameForFileStorage);
                var fullPath = Path.Combine(_env.ContentRootPath, dir);
                var data = new DocumentUploadDto
                {
                    Name = trustedFileNameForDisplay,
                    ParentId = 170,
                    Path = dir,
                    Type = 1, //type 1 = file
                    FileExtensionId = _documentUploadService.GetFileExtIdByPath(fullPath),
                    AllowedModify = false,
                };
                var user = _workerService.GetCurrentUser();
                var fileId = _documentUploadService.SaveFile(data, user?.Email);
                return fileId;
            }
        }
    }
}