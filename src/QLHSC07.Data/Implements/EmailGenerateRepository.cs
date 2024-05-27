using QLHSC07.Data.Interfaces;
using QLHSC07.Data.Repository;
using QLHSC07.Entity;

namespace QLHSC07.Data.Implements
{
    public class EmailGenerateRepository : BaseRepository<EmailGenerated>, IEmailGenerateRepository
    {
        public EmailGenerateRepository(AppDbContext context) : base(context)
        {
        }
    }
}
