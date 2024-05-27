using QLHSC07.CORE.Helper;
using QLHSC07.Entity.IdentityAccess;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLHSC07.Entity.IdentityExtentions.IdentityMapping
{
    [Table(TableFieldNameHelper.IdentityExtentions.UserLoginLog, Schema = Constant.Schema.AUTHENTICATION)]
    public class UserLoginLog : BaseFullAuditedEntity<int>
    {
        [Column("user_id")]
        public string UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public virtual User User { get; set; }
        
        [Column("api_name")]
        public string ApiName { get; set; }
        
        [Column("ip_address")]
        public string IpAddress { get; set; }

        [Column("full_name")]
        public string FullName { get; set; }
    }
}
