using QLHSC07.Model.BaseModels;
using System;

namespace QLHSC07.Model.District
{
    public class CreateDistrictDto : BaseCreateDto
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public int AdministrativeUnitCode { set; get; }
        public double Longitude { set; get; }
        public double Latitude { set; get; }
        public int ProvinceId { get; set; }
    }
}