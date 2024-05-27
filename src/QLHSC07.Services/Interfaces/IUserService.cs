using Microsoft.AspNetCore.Identity;
using QLHSC07.Entity.IdentityAccess;
using QLHSC07.Infrastructure.Interface;
using QLHSC07.Model.IdentityAccess;
using QLHSC07.Model.User;
using QLHSC07.Services.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QLHSC07.Services.Interfaces
{
    public interface IUserService
    {
        User GetByUserid(string id);
        string GetRoleByUserId(string id);
        IPagedList<UserListViewDto> List(int pageIndex, int pageSize, string sortExpression, string email, string userType, string fullName, long? pc07LocalId);
        DetailUserDto GetUserDetail(string id);
        public string GetCurrentUserId();
        public string GetCurrentUserName();
        //Task<bool> SendMailToActive(ActivationAccountRequest activationAccountRequest);
        Task<bool> KickOutUser(string userId);
        Task<bool> Delete(string userId);
        Task<bool> UserLogin(User user, ExternalLoginInfor externalLoginInfor, UserLoginInfo userInfo);
        string GetUserClaimByUserId(string id);
        List<UserAutoGenDto> GetUserNameToCreate();
    }
}
