using QLHSC07.Data.Interfaces;
using QLHSC07.Data.Repository;

namespace QLHSC07.Data.Implements
{
    public class ActionRepository : BaseRepository<Entity.SecurityMatrix.Action>,IActionRepository
    {
        public ActionRepository(AppDbContext context) : base(context)
        {
        }
    }
}
