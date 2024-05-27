using QLHSC07.Data.Interfaces;
using QLHSC07.Data.Repository;
using QLHSC07.Entity.IdentityAccess;

namespace QLHSC07.Data.Implements
{
    public class UserRepository : BaseRepository<User>,IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context)
        {
        }
    }
}
