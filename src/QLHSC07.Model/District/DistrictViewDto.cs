using System;
using System.ComponentModel;

namespace QLHSC07.Model.District
{
    public class DistrictViewDto
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public int AdministrativeUnitCode { set; get; }
        public double Longitude { set; get; }
        public double Latitude { set; get; }
        public int ProvinceId { get; set; }
        [DisplayName("ProvinceName")]
        public string ProvinceName { set; get; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
