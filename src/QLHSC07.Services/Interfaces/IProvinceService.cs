using QLHSC07.Data.Repository;
using QLHSC07.Entity.Administrative;
using QLHSC07.Infrastructure.Interface;
using QLHSC07.Model.Province;
using System.Collections.Generic;

namespace QLHSC07.Services.Interfaces
{
    public interface IProvinceService 
    {
        IPagedList<ProvinceViewDto> List(FilterProvince filter);
        ProvinceViewDto GetProvinceById(int id);
        IList<ProvinceLookupDto> GetLookupProvince();
        Province GetById(int id);
        bool Create(Province model);
        bool Update(Province model);
        string Delete(DeleteProvinceDto model);
        Dictionary<string, ProvinceWithFirstCommuneAndDistrict> GetProvinceWithFirstCommuneAndDistrict(List<string> filter);
    }
}