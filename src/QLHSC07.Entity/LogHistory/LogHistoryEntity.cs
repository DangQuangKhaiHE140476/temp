using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using QLHSC07.CORE.Helper;

namespace QLHSC07.Entity.LogHistory
{
    [Table("log_history", Schema = Constant.Schema.CMS)]
    public class LogHistoryEntity : BaseFullAuditedEntity<int>
    {
        [Column("user_name")]
        public string UserName { get; set; }
        [Column("action")]
        public int Action { get; set; }
        [Column("description")]
        public string Description { get; set; }
    }
}