using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using QLHSC07.CORE.Helper;

namespace QLHSC07.Entity
{
    [Table(TableFieldNameHelper.Sys.ReferenceType,Schema = Constant.Schema.SYS)]
    public class ReferenceType
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("Name")]
        public string Name { get; set; }
        public virtual ICollection<EmailGenerated> EmailGenerates { get; } = new List<EmailGenerated>();
    }
}
