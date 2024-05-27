using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using QLHSC07.CORE.Helper;

namespace QLHSC07.Entity.Administrative
{
    [Table(TableFieldNameHelper.Cms.Commune, Schema = Constant.Schema.CMS)]
    public class Commune : BaseFullAuditedEntity<int>
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
        [Column("district_id")]
        public int DistrictId { get; set; }
        public virtual District District { set; get; }
        public string GetDistrictName()
        {
            return District.Name;
        }
    }

}
