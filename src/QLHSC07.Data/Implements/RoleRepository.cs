using QLHSC07.Data.Interfaces;
using QLHSC07.Data.Repository;
using QLHSC07.Entity.IdentityAccess;

namespace QLHSC07.Data.Implements
{
    public class RoleRepository : BaseRepository<Role>,IRoleRepository
    {
        public RoleRepository(AppDbContext context) : base(context)
        {
        }
    }
}
