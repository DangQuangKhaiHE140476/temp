using QLHSC07.CORE.Helper;
using QLHSC07.Entity.IdentityAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QLHSC07.Entity.QLHSC07_Entities
{
    [Table(TableFieldNameHelper.QLHSC07.Ranks, Schema = Constant.Schema.QLHSC07)]
    public class Rank : BaseFullAuditedEntity<long>
    {
        public Rank()
        {
            User = new HashSet<User>();
        }
        [Column("name")]
        [StringLength(Constant.Maxlength.Name)]
        public string Name { get; set; }
        public virtual ICollection<User> User { get; set; }
    }
}
