using System;
using System.Collections.Generic;
using System.Text;
using QLHSC07.Data.Repository;
using QLHSC07.Entity.Document;

namespace QLHSC07.Data.Implements
{
    public interface IDocumentFileRepository : IBaseRepository<DocumentFile>
    {

    }

    public class DocumentFileRepository : BaseRepository<DocumentFile>, IDocumentFileRepository
    {
        public DocumentFileRepository(AppDbContext context) : base(context)
        {
        }
    }
}
