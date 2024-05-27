using System;

namespace QLHSC07.Model.Commune
{
    public class UpdateCommuneDto
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public int AdministrativeUnitCode { set; get; }
        public double Longitude { set; get; }
        public double Latitude { set; get; }
        public int DistrictId { get; set; }
    }
}
