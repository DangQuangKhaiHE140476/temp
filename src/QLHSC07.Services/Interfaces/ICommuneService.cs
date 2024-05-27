using QLHSC07.Data.Repository;
using QLHSC07.Entity.Administrative;
using QLHSC07.Infrastructure.Interface;
using QLHSC07.Model.Commune;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLHSC07.Services.Interfaces
{
    public interface ICommuneService 
    {
        IPagedList<CommuneViewDto> List(FilterCommuneDto filter);
        CommuneViewDto GetCommuneById(int id);
        IList<CommuneLookupDto> GetLookupCommune(int districtId);
        IList<CommuneLookupDto> GetLookupCommune(ICollection< int> districtIds);
        Commune GetById(int id);
        bool Create(Commune model);
        bool Update(Commune model);
        bool Delete(int id);
        int GetCommuneByName(string name);
        Task<IQueryable<Commune>> GetCommuneByIds(List<int> ids);
        //List<CommuneLookupDto> GetLookupCommune();
    }
}