using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using QLHSC07.CORE.Helper;

namespace QLHSC07.Entity.Administrative
{
    [Table(TableFieldNameHelper.Cms.Province, Schema = Constant.Schema.CMS)]
    public class Province : BaseFullAuditedEntity<int>
    {
        [StringLength(Constant.Maxlength.UnitName)]
        [Column("name")]
        public string Name { get; set; }
        [StringLength(Constant.Maxlength.UnitName)]
        [Column("unsign_name")]
        public string UnSignName { get; set; }

        [Column("administrative_unit_code")]
        public int AdministrativeUnitCode { get; set; }
        [Column("longitude")]
        public double Longitude { get; set; }
        [Column("latitude")]
        public double Latitude { get; set; }
        [Column("default_province")]
        public bool DefaultProvince { get; set; }
        [Column("order_number")]
        public int OrderNumber { get; set; }
        public virtual ICollection<District> Districts { get; } = new List<District>();
    }
}
