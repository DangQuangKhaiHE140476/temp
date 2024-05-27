using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

namespace QLHSC07.CORE.FileService
{
    public interface IFileService
    {
        Task<string> SaveFileAsync(string targetFolder, IFormFile file);
        Task<string> SaveFileAsync(string targetFolder, byte[] buffer, string fileName);
        Task<string> SaveFileAsyncCurrentName(string targetFolder, IFormFile file);
        void RemoveFile(string urlFile);
        string CreateFolder(string targetFolder, string folderName);

        bool RenameFolder(string pathFolderOld, string pathFolderNew);
        bool RenameFile(string pathFolderOld, string pathFolderNew);
        bool DeleteFolder(string path);
        string ConvertToBase64(string path);
    }
}
