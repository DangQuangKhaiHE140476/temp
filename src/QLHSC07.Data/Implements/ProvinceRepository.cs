using QLHSC07.Data.Interfaces;
using QLHSC07.Data.Repository;
using QLHSC07.Entity.Administrative;
using QLHSC07.Entity.SecurityMatrix;

namespace QLHSC07.Data.Implements
{
    public class ProvinceRepository : BaseRepository<Province>, IProvinceRepository
    {
        public ProvinceRepository(AppDbContext context) : base(context)
        {
        }
    }
}