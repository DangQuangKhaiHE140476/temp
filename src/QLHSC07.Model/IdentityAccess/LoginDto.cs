using System.ComponentModel.DataAnnotations;

namespace QLHSC07.Model.IdentityAccess
{
    public class LoginDto
    {
        [Required]
        [Display(Name = "Email")]
        //[EmailAddress]
        public string Email { get; set; }

        [Required]        
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
        public string ReturnUrl { get; set; }
    }
    public class Verify2FADto
    {
        [Required]
        [Display(Name = "Email")]
        //[EmailAddress]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "VerifyCode")]
        public string VerifyCode { get; set; }
        public string ReturnUrl { get; set; }
    }
    public class Enable2FADto
    {
        public string VerifyCode { get; set; }
        public string SecretKey { get; set; }
    }
}
