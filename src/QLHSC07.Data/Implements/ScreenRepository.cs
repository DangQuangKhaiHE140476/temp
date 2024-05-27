using QLHSC07.Data.Interfaces;
using QLHSC07.Data.Repository;
using QLHSC07.Entity.SecurityMatrix;

namespace QLHSC07.Data.Implements
{
    public class ScreenRepository : BaseRepository<Screen>,IScreenRepository
    {
        public ScreenRepository(AppDbContext context) : base(context)
        {
        }
    }
}
