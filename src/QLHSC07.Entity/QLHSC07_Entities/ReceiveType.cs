using QLHSC07.CORE.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QLHSC07.Entity.QLHSC07_Entities
{
    [Table(TableFieldNameHelper.QLHSC07.FormalityRecieveProfile, Schema = Constant.Schema.QLHSC07)]
    public class ReceiveType : BaseFullAuditedEntity<long>
    {
        public ReceiveType()
        {
            Recordses = new HashSet<Records>();
        }
        [Column("name")]
        [StringLength(Constant.Maxlength.Name)]
        public string Name { get; set; }
        public virtual ICollection<Records> Recordses { get; set; }

    }
}
