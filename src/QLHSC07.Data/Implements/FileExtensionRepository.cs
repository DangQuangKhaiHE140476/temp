using QLHSC07.Data.Interfaces;
using QLHSC07.Data.Repository;
using QLHSC07.Entity.Document;

namespace QLHSC07.Data.Implements
{
    public class FileExtensionRepository : BaseRepository<FileExtension>, IFileExtensionRepository
    {
        public FileExtensionRepository(AppDbContext context) : base(context)
        {
        }
    }
}
