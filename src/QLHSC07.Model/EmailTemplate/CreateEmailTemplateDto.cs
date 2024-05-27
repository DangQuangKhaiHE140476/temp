//using QLHSC07.Common.Resources;
using System.ComponentModel.DataAnnotations;

namespace QLHSC07.Model.EmailTemplate
{
    public class CreateEmailTemplateDto
    {
        [Required]
        public bool Status { get; set; }
        [Required]
        //[MaxLength(255, ErrorMessage = StringMessages.ErrorMessages.MaxLengthErrorMessage)]
        public string Title { get; set; }
        //[MaxLength(255, ErrorMessage = StringMessages.ErrorMessages.MaxLengthErrorMessage)]
        public string SendTo { get; set; }
        //[MaxLength(500, ErrorMessage = StringMessages.ErrorMessages.MaxLengthErrorMessage)]
        public string CC { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        //[MaxLength(50, ErrorMessage = StringMessages.ErrorMessages.MaxLengthErrorMessage)]
        public string Code { get; set; }
    }
}
