using QLHSC07.CORE.Enum;
using System;

namespace QLHSC07.Model.User
{
    public class UpdateUserDto
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string RoleId { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public bool? Sex { get; set; }
        public string Address { get; set; }
        //public string Avatar { get; set; }
        public string Description { get; set; }
        public string PhoneNumber { get; set; }
        public RecordPermissionEnum RecordPermission { get; set; }
    }    
}
