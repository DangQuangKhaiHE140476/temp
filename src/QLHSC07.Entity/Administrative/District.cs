using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using QLHSC07.CORE.Helper;

namespace QLHSC07.Entity.Administrative
{
    [Table(TableFieldNameHelper.Cms.District, Schema = Constant.Schema.CMS)]
    public class District : BaseFullAuditedEntity<int>
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
        [Column("province_id")]
        public int ProvinceId { get; set; }
        public virtual Province Province { set; get; }
        public virtual ICollection<Commune> Communes { get; } = new List<Commune>();
        public string GetProvinceName()
        {
            return Province.Name;
        }
    }
}
