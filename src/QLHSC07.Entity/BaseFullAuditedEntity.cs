using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLHSC07.Entity
{
    public class BaseFullAuditedEntity<T>: BaseEntity<T>
    {
        public virtual void SetDefaultValue( string createBy)
        {
            CreatedDate = DateTime.Now;
            CreatedBy = createBy;
        }
        public virtual void SetValueUpdate(string updateBy)
        {
            ModifiedDate = DateTime.Now;
            ModifiedBy = updateBy;
        }

        [Column("created_by")]
        public string CreatedBy { get; set; }

        [Column("created_date")]
        public DateTime CreatedDate { get; set; }

        [Column("modified_by")]
        public string ModifiedBy { get; set; }

        [Column("modified_date")]
        public DateTime ModifiedDate { get; set; }
        [Column("is_delete")]
        public bool IsDelete { get; set; }
    }
}
