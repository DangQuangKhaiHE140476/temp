using QLHSC07.Data.Interfaces;
using QLHSC07.Data.Repository;
using QLHSC07.Entity.Administrative;
using QLHSC07.Entity.SecurityMatrix;

namespace QLHSC07.Data.Implements
{
    public class CommuneRepository : BaseRepository<Commune>, ICommuneRepository
    {
        public CommuneRepository(AppDbContext context) : base(context)
        {
        }
    }
}