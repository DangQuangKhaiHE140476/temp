using QLHSC07.Data.Repository;
using QLHSC07.Entity.IdentityAccess;
using System;
using System.Threading.Tasks;

namespace QLHSC07.Data.Interfaces
{
    public interface IUserTokenRepository : IBaseRepository<UserTokens>
    {
        Task<bool> ConcurrencyLogin(string userId, string device, string userType);
        Task<bool> IsExistAccessToken(string userId, string device, string accessToken);
    }
}