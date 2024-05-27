using System.ComponentModel.DataAnnotations;

namespace QLHSC07.Model.IdentityAccess
{
    public class ResetPasswordDto
    {
        public string UserId { get; set; }
        public string Password { get; set; }
        public string Code { get; set; }
    }
    public class CheckPasswordDto
    {
        public string Password { get; set; }
    }
    public class ResetPasswordAdminDto
    {
        public string UserId { get; set; }
        public string Password { get; set; }
    }
}
