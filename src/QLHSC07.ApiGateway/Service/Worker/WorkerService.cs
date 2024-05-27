using System.Linq;
using System.Security.Claims;
using QLHSC07.Entity.IdentityAccess;
using QLHSC07.Model.User;
using QLHSC07.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace QLHSC07.ApiGateway.Service.Worker
{
    public class WorkerService : IWorkerService
    {
        private readonly UserManager<User> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IUserService _userService;
        public WorkerService(UserManager<User> userManager, IHttpContextAccessor httpContextAccessor, IUserService userService)
        {
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
            _userService = userService;
        }

        public CurrentUserDto GetCurrentUser()
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirst(claim => claim.Type.Equals("userId"))?.Value; //"userId"
            if (userId == null)
            {
                return null;
            }
            var user = _userManager.Users.Include(u => u.UserRoles)
                .ThenInclude(ur => ur.Role)
                .Where(u => u.Id == userId).Select(e => new CurrentUserDto
                {
                    Id = e.Id,
                    UserName = e.UserName,
                    Email = e.Email,
                    FullName = e.FullName,
                    UserType = e.UserType,
                    Roles = e.UserRoles.Select(c => new RoleDto
                    {
                        Id = c.Role.Id,
                        Code = c.Role.Code
                    }).ToList()
                }).FirstOrDefault();
            return user;
        }

    }
}
