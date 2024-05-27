using QLHSC07.CORE.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QLHSC07.Entity.QLHSC07_Entities
{
    [Table(TableFieldNameHelper.QLHSC07.RecordsType, Schema = Constant.Schema.QLHSC07)]
    public class RecordsType : BaseFullAuditedEntity<long>
    {
        public RecordsType()
        {
            Recordses = new HashSet<Records>();
        }
        [Column("name")]
        [StringLength(Constant.Maxlength.Name)]
        public string Name { get; set; }
        
        [Column("is_approval")]
        public bool? IsApproval { get; set; }
        
        [Column("waiting_type")]
        public string Waiting_Type { get; set; } //giờ: h, ngày: d
        [Column("waiting_time")]
        public int WaitingTime { get; set; }
        public virtual ICollection<RecordsTypeFileType> RecordTypeFileTypes { get; set; }
        public virtual ICollection<Records> Recordses { get; set; }
    }
}
