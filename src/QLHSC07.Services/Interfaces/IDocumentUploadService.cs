using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Threading.Tasks;
using QLHSC07.Entity;
using QLHSC07.Infrastructure.Interface;
using QLHSC07.Model.DocumentUpload;
using QLHSC07.Model.IdentityAccess;
using QLHSC07.Model.User;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Http;

namespace QLHSC07.Services.Interfaces{
    public interface IDocumentUploadResizeJob
    {
        Task CronJobCreateMultiSizeImagePaths();
    }
    public interface IDocumentUploadService
    {
        long? SaveFile(DocumentUploadDto model, string authorEmail);
        string GetFilePathById(long? fileId);
        DocumentDetailDto GetById(long id);
        int? GetFileExtIdByPath(string path);
        //string GetNodePathById(long id);
        bool DeleteFile(DocumentUpload doc);
        bool DeleteFolder(DocumentUpload doc);
        bool Delete(long id, ref int type, ref string path);
        bool CreateFolder(long parentId, string path, string folderName, string authorEmail);
        List<DocumentDetailDto> GetAllDocumentByParentId(long parentId,string type);
        List<DocumentDetailDto> GetParentDocumentById(long id);
        bool MoveDocumentUpdatePath(long documentId, string targetFolderPath);
        bool MoveDocumentUpdateParentId(long documentId, long targetParentId, string authorEmail);
        List<DocumentDetailDto> SearchDocument(string fileName, long? parentId);
        bool RenameDocument(long documentId, string newFileName, string authorEmail);
        string CheckDuplicateDocument(long? documentId, string documentName, int? documentType, long? targetFolderId, string newDocumentName);
        string CheckDocument(List<DownloadDocumentDto> model, CurrentUserDto user);
        long GetCgisId();
        Task<long> DownloadImageByUrl(ExternalLoginInfor user);
        Task<bool> CreateMultiSizeImagePaths(IHostEnvironment _env, long? documentId, string filePath, string outputDirectory, bool ignoreAspectRatio = false);
        Task<long?> UploadAndSave(IFormFile file, string email, string returnPath);
    }
}