using System.ComponentModel.DataAnnotations;

namespace QLHSC07.Model.IdentityAccess
{
    public class ForgotPasswordDto
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
        public string ReturnUrl { get; set; }
    }
}
