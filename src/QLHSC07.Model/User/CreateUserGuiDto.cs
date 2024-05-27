using System;
using System.ComponentModel.DataAnnotations;

namespace QLHSC07.Model.User
{
    public class CreateUserGuiDto
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }
        public bool? Sex { get; set; }
        public string Address { get; set; }
        public long DocumentUploadId {get;set;}
        public string Description { get; set; }
        public string PhoneNumber { get; set; }
    }
}
