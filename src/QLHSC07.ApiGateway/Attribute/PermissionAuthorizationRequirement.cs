using System.Collections.Generic;
using System.Linq;

namespace QLHSC07.ApiGateway.Attribute
{
    public class PermissionAuthorizationRequirement
    {
        //public List<string> RequiredPermissions { get; set; }
        //public PermissionAuthorizationRequirement(IEnumerable<string> permission)
        //{
        //    RequiredPermissions = permission.ToList();
        //}

        public string ActionName { get; set; }
        public string ScreentName { get; set; }
        public string UserType { get; set; }
        public PermissionAuthorizationRequirement(string actionName, string screentName)
        {
            ActionName = actionName;
            ScreentName = screentName;
            UserType = "";
        }

        public PermissionAuthorizationRequirement(string actionName, string screentName, string userType)
        {
            ActionName = actionName;
            ScreentName = screentName;
            UserType = userType;
        }
    }
}
