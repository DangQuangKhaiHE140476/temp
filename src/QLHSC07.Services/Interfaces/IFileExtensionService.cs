using QLHSC07.Entity.Document;

namespace QLHSC07.Services.Interfaces
{
    public interface IFileExtensionService
    {
        FileExtension GetExtensionByName(string name);
        FileExtension GetExtensionById(int id);
    }
}
