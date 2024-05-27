using System.Collections.Generic;

namespace QLHSC07.Model.User
{
    public class CurrentUserDto
    {
        public string Id { set; get; }
        public string UserName { set; get; }
        public string Email { set; get; }
        public string FullName { set; get; }
        public List<RoleDto> Roles { set; get; }
        public string UserType { get; set; }
    }

    public class RoleDto
    {
        public string Code { set; get; }
        public string Id { set; get; }
    }
}
