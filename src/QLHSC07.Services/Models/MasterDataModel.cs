using System.Collections.Generic;

namespace QLHSC07.Services.Models
{

    public class MasterDataBaseOnLang
    {
        public int? Id { get; set; }
        public string Name { get; set; }
    }
    
    public class TimeToReloadCache
    {
        public int ReloadTime { get; set; }
    }

    public class MasterDataModel
    {
        public MasterDataModel()
        {
            ProjectProgress = new List<MasterDataBaseOnLang>();
            ProjectStatusCache = new List<MasterDataBaseOnLang>();
            RealEstateTypeCache = new List<MasterDataBaseOnLang>();
            SoilTypeCache = new List<MasterDataBaseOnLang>();
            PostTypeCache = new List<MasterDataBaseOnLang>();
            UtilitiesCache = new List<MasterDataBaseOnLang>();
            DirectionCache = new List<MasterDataBaseOnLang>();
        }
        public List<MasterDataBaseOnLang> ProjectProgress { get; set; }
        public List<MasterDataBaseOnLang> ProjectStatusCache { get; set; }
        public List<MasterDataBaseOnLang> RealEstateTypeCache { get; set; }
        public List<MasterDataBaseOnLang> SoilTypeCache { get; set; }
        public List<MasterDataBaseOnLang> PostTypeCache { get; set; }
        public List<MasterDataBaseOnLang> UtilitiesCache { get; set; }
        public List<MasterDataBaseOnLang> DirectionCache { get; set; }
    }
}
