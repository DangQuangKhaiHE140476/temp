using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.VisualBasic.FileIO;
using QLHSC07.CORE.Extensions;
using QLHSC07.CORE.FileService;
using QLHSC07.CORE.Helper;
using QLHSC07.Data.Implements;
using QLHSC07.Data.Interfaces;
using QLHSC07.Data.Repository;
using QLHSC07.Entity;
using QLHSC07.Model.DocumentUpload;
using QLHSC07.Model.IdentityAccess;
using QLHSC07.Model.User;
using QLHSC07.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
namespace QLHSC07.Services.Implements
{
    public class DocumentUploadService : IDocumentUploadService
    {
        private readonly IDocumentUploadRepository _documentUploadRepository;
        private readonly ILogger<DocumentUploadService> _logger;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IFileExtensionRepository _fileExtensionRepository;
        private readonly IHostEnvironment _env;
        private readonly IMapper _mapper;


        public DocumentUploadService(IDocumentUploadRepository documentUploadRepository,
            ILogger<DocumentUploadService> logger,
            IUnitOfWork unitOfWork, IMapper mapper,
            IHostEnvironment env, IFileExtensionRepository fileExtensionRepository)
        {
            _documentUploadRepository = documentUploadRepository;
            _logger = logger;
            _unitOfWork = unitOfWork;
            _fileExtensionRepository = fileExtensionRepository;
            _env = env;
            _mapper = mapper;
        }

        public long? SaveFile(DocumentUploadDto model, string authorEmail)
        {
            var entity = _mapper.Map<DocumentUpload>(model);
            entity.CreatedBy = authorEmail ?? "Administrator";
            entity.ModifiedBy = authorEmail ?? "Administrator";
            entity.CreatedDate = DateTime.Now;
            entity.ModifiedDate = DateTime.Now;

            _documentUploadRepository.Insert(entity);
            _unitOfWork.Complete();
            return entity.Id;
        }

        public string GetFilePathById(long? fileId)
        {
            return _documentUploadRepository.Find(x => x.Id == fileId)?.Path;
        }

        public async Task<long> DownloadImageByUrl(ExternalLoginInfor user)
        {
            var fileName = $"{ user.LoginProvider}{ Guid.NewGuid()}{ Constant.FileType.ExtentionImage}";
            var relativePath = $"{ Constant.PathName.UserFolder}\\{fileName}";
            var filePath = Path.Combine(_env.ContentRootPath, relativePath);
            var filePathWithoutFileName = Path.Combine(_env.ContentRootPath, Constant.PathName.UserFolder);

            //kiểm tra local path đã tồn tại hay chưa nếu chưa thì tạo mới
            if (!Directory.Exists(filePathWithoutFileName))
            {
                Directory.CreateDirectory(filePathWithoutFileName);
            }
            if (user.LoginProvider == Constant.ExternalLogin.GoogleService)
            {
                filePath = $"{filePath}";
                WebClient client = new WebClient();
                Stream stream = client.OpenRead(user.ImageUrl);
                Bitmap bitmap = new Bitmap(stream);
                bitmap.Save(filePath, ImageFormat.Jpeg);
                stream.Flush();
                stream.Close();
                client.Dispose();
            }
            else if (user.LoginProvider == Constant.ExternalLogin.FacebookService)
            {
                filePath = $"{filePath}";
                await GetFacebookImage(user.ImageUrl, filePath);
            }
            else
            {
                return Constant.FileType.DownloadImageDefaultId;
            }

            ///insert to documentupload
            if (!string.IsNullOrEmpty(filePath))
            {
                var documentUpload = await _documentUploadRepository.InsertAsync(
                    new DocumentUpload
                    {
                        CreatedBy = user.Email ?? "Administrator",
                        ModifiedBy = user.Email ?? "Administrator",
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        Path = relativePath,
                        Name = Path.GetFileName(filePath),
                        Type = Constant.FileType.UserTypeFile,
                        IsDelete = false,
                        AllowedModify = true
                    });
                _unitOfWork.Complete();
                return documentUpload.Id;
            }
            return Constant.FileType.DownloadImageDefaultId;
        }

        private async Task GetFacebookImage(string url, string pathLocal)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(url))
                using (Stream streamToReadFrom = await response.Content.ReadAsStreamAsync())
                {
                    Bitmap bitmap = new Bitmap(streamToReadFrom);
                    bitmap.Save(pathLocal, ImageFormat.Jpeg);

                }
            }
        }

        public DocumentDetailDto GetById(long id)
        {
            var entity = _documentUploadRepository.Find(x => x.Id == id);
            var data = _mapper.Map<DocumentDetailDto>(entity);
            if (data == null) return null;
            data.TypeName = data.Type == 0 ? "Folder" : "File";
            var filePath = Path.Combine(_env.ContentRootPath, data.Path);
            if (File.Exists(filePath))
                data.FileSize = data.Type == 1 ? new FileInfo(filePath).Length / 1024 : 0;
            data.HasChild = HasChild(data.Id);
            return data;
        }

        public int? GetFileExtIdByPath(string path)
        {
            var ext = Path.GetExtension(path);
            var data = _fileExtensionRepository.Find(x => x.Name.Equals(ext.Replace(".", "").ToUpper()))?.Id;
            return data;
        }

        // public string GetNodePathById(long id)
        // {
        //     return _documentUploadRepository.GetNodePathById(id)?.Path;
        // }

        public bool DeleteFile(DocumentUpload doc)
        {
            //using var dbTransaction = _unitOfWork.BeginTransaction();
            try
            {
                _documentUploadRepository.Delete(doc);
                //dbTransaction.Commit();
                _unitOfWork.Complete();
                return true;
            }
            catch (Exception e)
            {
                //dbTransaction.Rollback();
                _logger.LogError(e.Message, e);
                return false;
            }
        }

        public bool DeleteFolder(DocumentUpload doc)
        {
            // using var dbTransaction = _unitOfWork.BeginTransaction();
            try
            {
                var entity = _documentUploadRepository.Query(x => x.ParentId == doc.Id)?.ToList();
                if (entity != null)
                {
                    foreach (var entry in entity)
                    {
                        var data = _documentUploadRepository.Query(x => x.ParentId == entry.Id)?.Any();
                        if (data == true)
                        {
                            DeleteFolder(entry); //recursive
                        }
                        _documentUploadRepository.Delete(entry);
                    }
                }

                _documentUploadRepository.Delete(doc);
                // dbTransaction.Commit();
                _unitOfWork.Complete();
                return true;
            }
            catch (Exception e)
            {
                //dbTransaction.Rollback();
                _logger.LogError(e.Message, e);
                return false;
            }
        }

        public bool Delete(long id, ref int type, ref string path)
        {
            var entity = _documentUploadRepository.Find(x => x.Id == id);
            if (entity == null) return false;
            type = entity.Type;
            path = entity.Path;
            return entity.Type == 0 ? DeleteFolder(entity) : DeleteFile(entity);
        }

        public bool CreateFolder(long parentId, string path, string folderName, string authorEmail)
        {
            using var dbTransaction = _unitOfWork.BeginTransaction();
            try
            {
                var entity = new DocumentUpload
                {
                    ParentId = parentId,
                    Path = path,
                    Type = 0, //folder
                    CreatedBy = authorEmail ?? "Administrator",
                    ModifiedBy = authorEmail ?? "Administrator",
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    Name = folderName,
                    FileExtensionId = null
                };
                _documentUploadRepository.Insert(entity);
                dbTransaction.Commit();
                _unitOfWork.Complete();
                return true;
            }
            catch (Exception e)
            {
                dbTransaction.Rollback();
                _logger.LogError(e.Message, e);
                return false;
            }
        }

        public List<DocumentDetailDto> GetAllDocumentByParentId(long parentId, string type)
        {
            var entity = _documentUploadRepository.Query(x => x.ParentId == parentId)
                .Include(x => x.FileExtension).Sort("Name");
            if (!string.IsNullOrEmpty(type) && type == "TIF" || type == "ZIP")
            {
                entity = entity.Where(x => x.FileExtension.Name == type);
                //i cant findout type constant. 11= tif, 18 = zip
            }
            var data = entity?.Select(x => _mapper.Map<DocumentDetailDto>(x)).ToList();
            if (data == null) return null;
            foreach (var d in data)
            {
                d.TypeName = d.Type == 0 ? "Folder" : "File";
                var filePath = Path.Combine(_env.ContentRootPath, d.Path);
                if (File.Exists(filePath))
                {
                    d.FileSize = d.Type == 1 ? new FileInfo(filePath).Length / 1024 : 0;
                }
                d.HasChild = HasChild(d.Id);
            }

            return data;
        }

        public List<DocumentDetailDto> GetParentDocumentById(long id)
        {
            var listId = new List<long>();
            do
            {
                var item = _documentUploadRepository.Find(x => x.Id == id).ParentId;
                listId.Add(item);
                id = item;
            } while (id > 0);
            var data = new List<DocumentDetailDto>();
            // for (var i = listId.Count; i > 0; i++)
            // {
            //     data.Add(GetById(listId[i]));
            // }
            foreach (var item in listId)
            {
                data.Add(GetById(item));
            }
            var result = Enumerable.Reverse(data).ToList();
            return result;
        }


        public bool MoveDocumentUpdatePath(long documentId, string targetFolderPath)
        {
            try
            {
                var document = _documentUploadRepository.Find(x => x.Id == documentId);
                var documentChild = _documentUploadRepository.Query(x => x.ParentId == documentId).ToList();
                foreach (var doc in documentChild)
                {
                    var entry = _documentUploadRepository.Query(x => x.ParentId == doc.Id)?.Any();
                    if (entry == true)
                    {
                        MoveDocumentUpdatePath(doc.Id, targetFolderPath + document.Name);
                    }

                    doc.Path = Path.Combine(targetFolderPath, document.Name, doc.Name);
                    _documentUploadRepository.Update(doc);
                }

                if (document != null) document.Path = Path.Combine(targetFolderPath, document.Name);
                _documentUploadRepository.Update(document);
                _unitOfWork.Complete();
                return true;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, e);
                return false;
            }
        }

        public bool MoveDocumentUpdateParentId(long documentId, long targetParentId, string authorEmail)
        {
            var document = _documentUploadRepository.Find(x => x.Id == documentId);
            using var dbTransaction = _unitOfWork.BeginTransaction();
            try
            {
                if (document == null) return false;
                document.ParentId = targetParentId;
                document.ModifiedBy = authorEmail ?? "Administrator";
                document.ModifiedDate = DateTime.Now;
                _documentUploadRepository.Update(document);
                dbTransaction.Commit();
                _unitOfWork.Complete();
                return true;
            }
            catch (Exception e)
            {
                dbTransaction.Rollback();
                _logger.LogError(e.Message, e);
                return false;
            }
        }

        public List<DocumentDetailDto> SearchDocument(string fileName, long? parentId)
        {
            try
            {
                var document = _documentUploadRepository.GetAll().Include(x => x.FileExtension).AsQueryable();
                if (!string.IsNullOrEmpty(fileName))
                {
                    var filenames = fileName.Split(' ');
                    document = filenames.Aggregate(document, (current, f) => current.AsEnumerable()
                        .Where(delegate (DocumentUpload doc)
                        {
                            return UtilHelper.ConvertToUnSign(doc.Name).Contains(UtilHelper.ConvertToUnSign(f));
                        })
                        .AsQueryable());
                }

                if (parentId.HasValue && parentId != 0)
                {
                    var parentPath = _documentUploadRepository.Find(x => x.Id == parentId)?.Path;
                    document = document.Where(x => x.Path.Contains(parentPath)).AsQueryable();
                }

                var data = document?.AsEnumerable().Select(x => new DocumentDetailDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    ParentId = x.ParentId,
                    Path = x.Path,
                    Type = x.Type,
                    TypeName = x.Type == 0 ? "Folder" : "File",
                    FileExtension = x.FileExtension,
                    CreatedDate = x.CreatedDate,
                    CreatedBy = x.CreatedBy,
                    ModifiedBy = x.ModifiedBy,
                    ModifiedDate = x.ModifiedDate,
                    AllowedModify = x.AllowedModify
                }).OrderBy(x => x.Type).ToList();
                foreach (var d in data)
                {
                    var path = Path.Combine(_env.ContentRootPath, d.Path ?? string.Empty);
                    if (d.Type == 1 && File.Exists(path))
                        d.FileSize = new FileInfo(path).Length / 1024;
                    d.HasChild = HasChild(d.Id);
                }

                return data;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, e);
                return null;
            }
        }

        private bool HasChild(long id)
        {
            return _documentUploadRepository.Find(x => x.ParentId == id && x.Type == 0) != null;
        }

        public bool RenameDocument(long documentId, string newFileName, string authorEmail)
        {
            //using var dbTransaction = _unitOfWork.BeginTransaction();
            try
            {
                var document = _documentUploadRepository.Find(x => x.Id == documentId);
                if (document == null) return false;
                var oldPath = Path.Combine(_env.ContentRootPath, document.Path);
                var listChild = _documentUploadRepository.Query(x => x.Path.Contains(document.Path))?.ToList();
                if (listChild != null)
                    foreach (var entry in listChild)
                    {
                        entry.Path = entry.Path.Replace(document.Name, newFileName);
                        _documentUploadRepository.Update(entry);
                    }

                //document.Path = document.Path.Replace(document.Name, newFileName);
                document.Name = newFileName;
                document.ModifiedBy = authorEmail ?? "Administrator";
                document.ModifiedDate = DateTime.Now;
                switch (document.Type)
                {
                    case 0:
                        FileSystem.RenameDirectory(oldPath, newFileName);
                        break;
                    case 1:
                        FileSystem.RenameFile(oldPath, newFileName);
                        break;
                }
                _documentUploadRepository.Update(document);
                //dbTransaction.Commit();
                _unitOfWork.Complete();
                return true;
            }
            catch (Exception e)
            {
                //dbTransaction.Rollback();
                _logger.LogError(e.Message, e);
                return false;
            }
        }

        public string CheckDuplicateDocument(long? documentId, string documentName, int? documentType, long? targetFolderId, string newDocumentName)
        {
            var checkDocument = new DocumentUpload();
            if (documentId.HasValue)
            {
                if (string.IsNullOrEmpty(newDocumentName))
                {
                    var document = _documentUploadRepository.Find(x => x.Id == documentId);
                    documentName = document.Name;
                    documentType = document.Type;
                    checkDocument = _documentUploadRepository.Find(x => x.Type == documentType && x.Name == documentName
                        && x.ParentId == targetFolderId);
                }
                else
                {
                    var document = _documentUploadRepository.Find(x => x.Id == documentId);
                    checkDocument = _documentUploadRepository.Find(x => x.Type == document.Type && x.Name == newDocumentName
                        && x.ParentId == document.ParentId);
                }
            }
            else
            {
                checkDocument = _documentUploadRepository.Find(x => x.Type == documentType && x.Name == documentName
                    && x.ParentId == targetFolderId);
            }

            if (checkDocument == null) return null;
            var type = checkDocument.Type == 0 ? "Folder " : "File ";
            return $"{type} \"{checkDocument.Name}\" trùng tên.";
        }
        public string CheckDocument(List<DownloadDocumentDto> model, CurrentUserDto user)
        {
            if (user.Roles.Any(x => x.Code == RoleHelper.Admin)) return null;
            return (from entry in model
                    select _documentUploadRepository.Find(x => x.Path == entry.FilePath) into doc
                    where doc != null && doc.CreatedBy != user.Email
                    select doc.Name).FirstOrDefault();
        }

        public long GetCgisId()
        {
            return _documentUploadRepository.Find(x => x.Path == @"Uploads\cgis").Id;
        }

        public async Task<bool> CreateMultiSizeImagePaths(IHostEnvironment _env, long? documentId, string filePath, string outputDirectory, bool ignoreAspectRatio = false)
        {
            var outputDirectoryPath = $"{outputDirectory}{documentId}";
            if (!Directory.Exists(outputDirectoryPath)) Directory.CreateDirectory(outputDirectoryPath);

            var multiSizeImagePaths = new List<MultiSizeImagePaths>();

            foreach (var image in Constant.SizeImage.ImageSize)
            {
                var ignoreAspRatio = ignoreAspectRatio;
                if (image.Width == 0 || image.Height == 0) ignoreAspRatio = false;//Nếu width hoặc height = 0 thì chiều còn lại phải scale theo
                var pathResized = await ImageOptimization.ResizeImage(_env, filePath, outputDirectoryPath, ignoreAspRatio, image.Width, image.Height);
                var fileName = $"{Path.GetRandomFileName()}{Path.GetExtension(pathResized)}";
                await ImageOptimization.CompressImage(fileName, pathResized, outputDirectoryPath);
                multiSizeImagePaths.Add(new MultiSizeImagePaths
                {
                    Name = fileName,
                    Path = Path.Combine(outputDirectoryPath, fileName),
                    Size = new ImageSize
                    {
                        Height = image.Height,
                        Width = image.Width
                    }
                });
                File.Delete(pathResized);
            }

            var documentUpload = await _documentUploadRepository.GetAll().SingleOrDefaultAsync(c => c.Id == documentId);
            if (documentUpload == null) return false;
            documentUpload.IsResizeImage = true;
            documentUpload.MultiSizeImagePaths = multiSizeImagePaths;
            _documentUploadRepository.Update(documentUpload);
            await _unitOfWork.CompleteAsync();
            return true;
        }

        public async Task<long?> UploadAndSave(IFormFile file, string email, string returnPath)
        {
            var fullPath = Path.Combine(_env.ContentRootPath, returnPath);

            var data = new DocumentUploadDto
            {
                Name = Path.GetFileName(fullPath), //file.FileName,
                ParentId = 170,
                Path = returnPath,
                Type = 1,
                //Title = File.FileName,
                FileExtensionId = GetFileExtIdByPath(fullPath)
            };
            var fileId = SaveFile(data, email);
            return await Task.FromResult(fileId);
        }
    }
}

