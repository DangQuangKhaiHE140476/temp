using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using QLHSC07.CORE.Helper;
using Microsoft.AspNetCore.Identity;

namespace QLHSC07.Entity.IdentityAccess
{
    [Table("AspNetRoleClaims",Schema = Constant.Schema.AUTHENTICATION)]
    public class RoleClaim : IdentityRoleClaim<string>
    {
        [Key]
        public override string RoleId { get; set; }
        public virtual Role Role { get; set; }
    }
}
