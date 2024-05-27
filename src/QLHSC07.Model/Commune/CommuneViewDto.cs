using System;
using System.ComponentModel;
using System.Dynamic;

namespace QLHSC07.Model.Commune
{
    public class CommuneViewDto
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public int AdministrativeUnitCode { set; get; }
        public double Longitude { set; get; }
        public double Latitude { set; get; }
        public int DistrictId { set; get; }
        public string DistrictName { set; get; }
        public int ProvinceId { get; set; }
        //[DisplayName("ProvinceName")]
        public string ProvinceName { set; get; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
