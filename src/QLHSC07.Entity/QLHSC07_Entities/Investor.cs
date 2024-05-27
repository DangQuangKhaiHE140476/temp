using QLHSC07.CORE.Helper;
using QLHSC07.Entity.Administrative;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QLHSC07.Entity.QLHSC07_Entities
{
    [Table(TableFieldNameHelper.QLHSC07.Investor, Schema = Constant.Schema.QLHSC07)]
    public class Investor : BaseFullAuditedEntity<long>
    {
        [Column("name")]
        public string Name { get; set; }
        [Column("address")]
        public string Address { get; set; }
        [Column("tax_code")]
        public string TaxCode { get; set; }
        [Column("phone")]
        public string Phone { get; set; }
        [Column("fax")]
        public string Fax { get; set; }
        [Column("email")]
        public string Email { get; set; }
        [Column("province_id")]
        public int? ProvinceId { get; set; }
        [ForeignKey("province_id")]
        public Province Province { get; set; }
        [Column("district_id")]
        public int? DistrictId { get; set; }
        [ForeignKey("district_id")]
        public virtual District District { get; set; }
        [Column("commune_id")]
        public int? CommuneId { get; set; }
        [ForeignKey("commune_id")]
        public Commune Commune { get; set; }
    }
}
