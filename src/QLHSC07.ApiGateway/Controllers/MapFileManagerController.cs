using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using QLHSC07.ApiGateway.Service.Worker;
using QLHSC07.CORE.Extensions;
using QLHSC07.CORE.FileService;
using Microsoft.Extensions.Hosting;
using QLHSC07.CORE.Helper;
using QLHSC07.CORE.Resource;
using QLHSC07.Entity.Document;
using QLHSC07.Model;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using QLHSC07.CORE;

namespace QLHSC07.ApiGateway.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MapFileManagerController : ControllerBase
    {
        private readonly IHostEnvironment _env;
        private readonly IWorkerService _workerService;
        private readonly IFileService _fileService;

        public MapFileManagerController(IHostEnvironment env, IWorkerService workerService, IFileService fileService)
        {
            _env = env;
            _workerService = workerService;
            _fileService = fileService;
        }

        [HttpGet]
        [ActionName("GetListFiles")]
        public ActionResult GetListFiles(string sortExpression, string name)
        {
            var folder = Path.Combine(_env.ContentRootPath, "Uploads", "cgis");
            var files = Directory.GetFiles(folder).Where(x => (x.Contains(".tif") || x.Contains(".zip")) && x.Contains(string.IsNullOrEmpty(name)
                ? string.Empty : name)).ToList();
            var result = files.Select(file => new FileInfo(file))
                .Select(data => new InforFile { Name = data.Name, Extension = data.Extension, CreatedDate = data.CreationTime, Size = data.Length }).AsQueryable()
                .Sort(string.IsNullOrEmpty(sortExpression) ? "Extension" : sortExpression).ToList();
            return Ok(new ResponseData
            {
                Content = result
            });
        }

        [HttpPost]
        [ActionName("UploadFiles")]
        public async Task<ActionResult> UploadFiles(IFormFile[] Files)
        {
            var folder = Path.Combine(_env.ContentRootPath, "Uploads", "cgis");
            var existFiles = Directory.GetFiles(folder).Where(x => (x.Contains(".tif") || x.Contains(".zip"))).ToList();
            foreach (var file in Files)
            {
                if (file.ContentType != "image/tiff" && file.ContentType != "application/zip")
                {
                    return BadRequest(new ResponseErrorData
                    {
                        ErrorMessage = string.Format(StringMessage.ErrorMessages.FileNotValid, file.FileName),
                        ErrorType = ErrorTypeConstant.DataNotValid
                    });
                }
                if (existFiles.Any(x => Path.GetFileName(x) == file.FileName))
                {
                    return BadRequest(new ResponseErrorData
                    {
                        ErrorMessage = string.Format(StringMessage.ErrorMessages.FileExisted, file.FileName),
                        ErrorType = ErrorTypeConstant.FileExisted
                    });
                }

                await _fileService.SaveFileAsyncCurrentName(Path.Combine("Uploads", "cgis"), file);
            }

            return Ok(new ResponseData
            {
                Content = new
                {
                    Status = true
                }
            });
        }

        [HttpPost]
        [ActionName("DownloadFile")]
        public async Task<ActionResult> DownloadFile([FromBody] List<string> FileNames)
        {
            var folder = Path.Combine(_env.ContentRootPath, "Uploads", "cgis");
            var nameFolder = "Map Content " + DateTime.Now;
            nameFolder = nameFolder.Replace(":", "-");
            Directory.CreateDirectory(Path.Combine(folder,nameFolder));
            var nameZip = nameFolder + ".zip";
            var files = Directory.GetFiles(folder).Where(x => (x.Contains(".tif") || x.Contains(".zip"))).ToList();
            foreach (var downloadFile in FileNames)
            {
                foreach (var file in files)
                {
                    if (Path.GetFileName(file) == downloadFile)
                    {
                        System.IO.File.Copy(file, Path.Combine(folder, nameFolder, Path.GetFileName(file)),true);
                    }
                }
            }
            ZipFile.CreateFromDirectory(Path.Combine(folder, nameFolder), Path.Combine(folder, nameZip));
            var data = await System.IO.File.ReadAllBytesAsync(Path.Combine(folder, nameZip));
            Directory.Delete(Path.Combine(folder,nameFolder),true);
            System.IO.File.Delete(Path.Combine(folder,nameZip));
            return File(data, "application/octet-stream", nameZip);
        }
    }

    public class InforFile
    {
        public DateTime CreatedDate { get; set; }
        public string Name { get; set; }
        public string Extension { get; set; }
        public long Size { get; set; }
    }
}
