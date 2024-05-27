namespace QLHSC07.Model.Province
{
    public class ProvinceWithFirstCommuneAndDistrict : BaseLookupDto
    {
        public int CommuneId { get; set; }
        public int DistrictId { get; set; }
        public string UsignName { get; set; }
    }
}
