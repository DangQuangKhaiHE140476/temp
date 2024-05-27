using QLHSC07.Data.Interfaces;
using QLHSC07.Entity.Document;
using QLHSC07.Services.Interfaces;
using System.Linq;

namespace QLHSC07.Services.Implements
{
    public class FileExtensionService : IFileExtensionService
    {
        private readonly IFileExtensionRepository _extensionRepository;

        public FileExtensionService(IFileExtensionRepository extensionRepository)
        {
            _extensionRepository = extensionRepository;
        }

        public FileExtension GetExtensionByName(string name)
        {
            return _extensionRepository.Query(x => x.Name == name)
                .FirstOrDefault();
        }

        public FileExtension GetExtensionById(int id)
        {
            return _extensionRepository.Query(e => e.Id == id).FirstOrDefault();
        }
    }
}
