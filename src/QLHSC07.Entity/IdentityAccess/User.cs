using Microsoft.AspNetCore.Identity;
using QLHSC07.CORE.Helper;
using QLHSC07.Entity.QLHSC07_Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLHSC07.Entity.IdentityAccess
{
    [Table("AspNetUsers", Schema = "authentication")]
    public class User : IdentityUser<string>
    {
        public string FullName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public bool? Sex { get; set; }
        public string Address { get; set; }
        public DateTime CreatedDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public long? DocumentUploadId { get; set; }
        [ForeignKey(nameof(DocumentUploadId))]
        public DocumentUpload DocumentUpload { get; set; }
        //public string Avatar { get; set; }
        public bool Status { get; set; }
        public string Description { get; set; }
        [StringLength(Constant.Maxlength.UserType)]
        public string UserType { get; set; }
        
        public virtual ICollection<UserRole> UserRoles { get; } = new List<UserRole>();
        public virtual ICollection<UserClaim> UserClaims { get; } = new List<UserClaim>();

        [Column("is_use_2fa")]
        public bool IsUse2FA { get; set; } = false;
        [Column("secret_key")]
        public string SecretKey { get; set; }
    }
}
