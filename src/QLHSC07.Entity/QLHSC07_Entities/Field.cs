using QLHSC07.CORE.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using static Npgsql.PostgresTypes.PostgresCompositeType;

namespace QLHSC07.Entity.QLHSC07_Entities
{
    [Table(TableFieldNameHelper.QLHSC07.Field, Schema = Constant.Schema.QLHSC07)]
    public class Field : BaseFullAuditedEntity<long>
    {
        public Field()
        {
            RecordsResultProcessings = new HashSet<RecordsResultProcessing>();
        }
        [Column("code")]
        [StringLength(20)]
        public string Code { get; set; }
        [Column("name")]
        [StringLength(Constant.Maxlength.Name)]
        public string Name { get; set; }
        [Column("parent_id")]
        public long ParentId { get; set; }
        public virtual ICollection<RecordsResultProcessing> RecordsResultProcessings { get; set; }
    }
}
