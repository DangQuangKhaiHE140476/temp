using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace QLHSC07.Entity.IdentityAccess
{
    [Table("AspNetUserTokens", Schema = "authentication")]
    public class UserTokens : IdentityUserToken<string>
    {
        public DateTime? ExpiredTime { get; set; }
    }
}
