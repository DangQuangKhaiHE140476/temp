using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QLHSC07.ApiGateway.Service.Worker;
using QLHSC07.CORE.Helper;
using QLHSC07.Model.User;
using QLHSC07.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace QLHSC07.ApiGateway.Attribute
{
    public class RequiresPermissionAttribute : TypeFilterAttribute
    {

        public RequiresPermissionAttribute(string actionName, string screenName) : base(typeof(RequiresPermissionAttributeExecutor))
        {
            //Arguments = new object[] { new PermissionAuthorizationRequirement(new List<string> { actionName, screenName }) };
            Arguments = new object[] { new PermissionAuthorizationRequirement(actionName, screenName) };
        }

        public RequiresPermissionAttribute(string actionName, string screenName, string userType) : base(typeof(RequiresPermissionAttributeExecutor))
        {
            //Arguments = new object[] { new PermissionAuthorizationRequirement(new List<string> { actionName, screenName, userType}) };
            Arguments = new object[] { new PermissionAuthorizationRequirement(actionName, screenName, userType) };
        }

        private class RequiresPermissionAttributeExecutor : System.Attribute, IAsyncResourceFilter
        {
            private readonly IWorkerService _workerService;
            private readonly PermissionAuthorizationRequirement _requiredPermissions;
            private readonly ISecurityMatrixService _securityMatrixService;
            public RequiresPermissionAttributeExecutor(IWorkerService workerService, ISecurityMatrixService securityMatrixService, 
                PermissionAuthorizationRequirement requiredPermissions)
            {
                _workerService = workerService;
                _requiredPermissions = requiredPermissions;
                _securityMatrixService = securityMatrixService;
            }
            public async Task OnResourceExecutionAsync(ResourceExecutingContext context, ResourceExecutionDelegate next)
            {
                var user =  _workerService.GetCurrentUser();
                if (await IsUnAuthorize(user))
                {
                    context.Result = new RedirectToActionResult("ForbiddenAccess", "Error", null);
                    await context.Result.ExecuteResultAsync(context);
                }
                else
                    await next();

                //if (user == null || !user.Roles.Any())
                //{
                //    //context.Result = new RedirectToActionResult("AccessDenied", "Error", null);
                //    context.Result = new RedirectToActionResult("ForbiddenAccess", "Error", null);
                //    await context.Result.ExecuteResultAsync(context);
                //}
                //else
                //if (user != null && user.Roles.Any(x => x.Code == RoleHelper.Admin))
                //{
                //    await next();
                //}
                //else
                //{
                //    if (_requiredPermissions?.RequiredPermissions == null || !_requiredPermissions.RequiredPermissions.Any())
                //    {
                //        //context.Result = new RedirectToActionResult("AccessDenied", "Error", null);
                //        context.Result = new RedirectToActionResult("ForbiddenAccess", "Error", null);
                //        await context.Result.ExecuteResultAsync(context);
                //    }
                //    else if (_requiredPermissions?.RequiredPermissions != null)
                //    {
                //       var isPermission = user != null && _securityMatrixService.CheckPermission(user.Roles.FirstOrDefault()?.Code,
                //           _requiredPermissions?.RequiredPermissions[0], _requiredPermissions?.RequiredPermissions[1]);
                //       if (!isPermission)
                //       {
                //           //context.Result = new RedirectToActionResult("AccessDenied", "Error", null);
                //            context.Result = new RedirectToActionResult("ForbiddenAccess", "Error", null);
                //            await context.Result.ExecuteResultAsync(context);
                //       }
                //       else
                //       {
                //           await next();
                //       }
                //    }
                //    else
                //    {
                //        await next();
                //    }
                //}
            }

            private async Task<bool> IsUnAuthorize(CurrentUserDto currentUser)//Check xem có quyền hay không
            {
                if (currentUser == null || !currentUser.Roles.Any())
                    return true;

                if (currentUser != null && currentUser.Roles.Any(x => x.Code == RoleHelper.Admin))
                    return false;

                if (_requiredPermissions == null)
                    return false;

                if (string.IsNullOrEmpty(_requiredPermissions.ScreentName) && string.IsNullOrEmpty(_requiredPermissions.ActionName))
                    return false;

                if (string.IsNullOrEmpty(_requiredPermissions.ScreentName) || string.IsNullOrEmpty(_requiredPermissions.ActionName))
                    return true;

                if (!string.IsNullOrEmpty(_requiredPermissions.UserType) && _requiredPermissions.UserType!=currentUser.UserType)
                    return true;

                var isPermission = currentUser != null && _securityMatrixService.CheckPermission(currentUser.Roles.FirstOrDefault()?.Code,
                           _requiredPermissions.ActionName, _requiredPermissions.ScreentName);

                return !isPermission;
            }
        }
    }
}
