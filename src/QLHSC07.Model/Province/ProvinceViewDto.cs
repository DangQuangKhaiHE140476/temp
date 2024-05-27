using System;
using System.ComponentModel;

namespace QLHSC07.Model.Province
{
    public class ProvinceViewDto
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public int AdministrativeUnitCode { set; get; }
        public double Longitude { set; get; }
        public double Latitude { set; get; }
        public string CreatedBy { get; set; }
        public bool DefaultProvince { get; set; }
        public int OrderNumber { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
