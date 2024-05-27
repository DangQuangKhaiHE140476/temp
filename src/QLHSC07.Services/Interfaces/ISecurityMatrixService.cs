using System.Collections.Generic;
using System.Threading.Tasks;
using QLHSC07.Infrastructure.Interface;
using QLHSC07.Model.SecurityMatrix;

namespace QLHSC07.Services.Interfaces
{
    public interface ISecurityMatrixService 
    {
        List<ActionLookupDto> GetActionLookup();
        List<ScreenLookupDto> GetScreenLookup();
        IPagedList<SecurityMatrixListViewDto> GetListSecurityMatrix(int pageIndex,int pageSize,string sortExpression,string roleName,string screenName);
        List<ScreenViewDto> GetDetailSecurityMatrix(string Id);
        bool CreateSecurityMatrix(CreateSecurityMatrixDto model);
        bool UpdateSecurityMatrix(CreateSecurityMatrixDto model);
        bool CheckPermission(string roleId, string actionName, string screenName);
        Task<ICollection<ScreenDto>> GetListScreen(string userId);
    }
}
