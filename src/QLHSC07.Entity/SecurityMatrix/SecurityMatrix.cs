using System.ComponentModel.DataAnnotations.Schema;
using QLHSC07.CORE.Helper;
using QLHSC07.Entity.IdentityAccess;

namespace QLHSC07.Entity.SecurityMatrix
{
    [Table(TableFieldNameHelper.Sys.SecurityMatrix, Schema = Constant.Schema.SYS)]
    public class SecurityMatrix
    {
        [Column("id")]
        public int Id { set; get; }
        [Column("action_id")]
        public int ActionId { set; get; }
        [Column("screen_id")]
        public int ScreenId { set; get; }
        [Column("role_id")]
        public string RoleId { set; get; }
        public virtual Action Action { set; get; }
        public virtual Screen Screen { set; get; }
        public virtual Role Role { set; get; }
    }
}
