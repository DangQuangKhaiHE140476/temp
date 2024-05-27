using System.Collections.Generic;
using QLHSC07.Data.Repository;
using QLHSC07.Entity.Administrative;
using QLHSC07.Infrastructure.Interface;
using QLHSC07.Model.District;

namespace QLHSC07.Services.Interfaces
{
    public interface IDistrictService
    {
        IPagedList<DistrictViewDto> List(int pageIndex, int pageSize, string sortExpression, string title = null);
        DistrictViewDto GetDistrictById(int id);
        District GetById(int id);
        IList<DistrictLookupDto> GetLookupDistrict();
        IList<DistrictLookupDto> GetDistrict(int provinceId);
        IList<DistrictLookupDto> GetDistrict(ICollection< int> provinceIds);
        bool Create(District model);
        bool Update(District model);
        bool Delete(int id);
        int GetDistrictByName(string name);
    }
}