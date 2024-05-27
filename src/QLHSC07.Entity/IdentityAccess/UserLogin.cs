using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace QLHSC07.Entity.IdentityAccess
{
    [Table("AspNetUserLogins",Schema = "authentication")]
    public class UserLogin : IdentityUserLogin<string>
    {
        [Key]
        public override string LoginProvider { set; get; }
        public virtual User User { get; set; }
    }
}
