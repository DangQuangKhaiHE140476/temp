using System;

namespace QLHSC07.Model.Province
{
    public class UpdateProvinceDto
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public int AdministrativeUnitCode { set; get; }
        public double Longitude { set; get; }
        public double Latitude { set; get; }
        public int OrderNumber { get; set; }
    }
}
