using QLHSC07.CORE.Helper;
using QLHSC07.Entity.Administrative;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QLHSC07.Entity.QLHSC07_Entities
{
    [Table(TableFieldNameHelper.QLHSC07.PC07Local, Schema = Constant.Schema.QLHSC07)]
    public class PC07Local : BaseFullAuditedEntity<long>
    {
        public PC07Local()
        {
            //DocumentInfomations = new HashSet<DocumentInfomations>();
            //MsgConversasions = new HashSet<MsgConversasion>();
        }

        [Column("name")]
        [StringLength(Constant.Maxlength.Name)]
        public string Name { get; set; }
        [StringLength(Constant.Maxlength.Name)]
        [Column("address")]
        public string Address { get; set; }
        [Column("province_id")]
        public int ProvinceId{get;set;}
        [ForeignKey(nameof(ProvinceId))]
        public Province Province { get; set; }
        [Column("commune_id")]
        public int CommuneId { get; set; }
        [ForeignKey(nameof(CommuneId))]
        public Commune Commune { get; set; }
        [StringLength(Constant.Maxlength.Description)]
        [Column("phone")]
        public string Phone { get; set; }
        [StringLength(Constant.Maxlength.PhoneNumber)]
        [Column("fax")]
        public string Fax { get; set; }
        [StringLength(Constant.Maxlength.Description)]
        [Column("email")]
        public string Email { get; set; }
        [StringLength(Constant.Maxlength.Description)]
        [Column("note")]
        public string Note { get; set; }

        [StringLength(Constant.Maxlength.UnitName)]
        [Column("unsign_name")]
        public string UnSignName { get; set; }
        //public virtual ICollection<DocumentInfomations> DocumentInfomations { get; set; }
        //public virtual ICollection<MsgConversasion> MsgConversasions { get; set; }

    }
}
