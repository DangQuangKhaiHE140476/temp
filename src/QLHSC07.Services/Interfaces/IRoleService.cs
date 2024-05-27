using System.Collections.Generic;
using QLHSC07.Data.Repository;
using QLHSC07.Entity.IdentityAccess;
using QLHSC07.Infrastructure.Interface;
using QLHSC07.Model.Role;

namespace QLHSC07.Services.Interfaces
{
    public interface IRoleService 
    {
        IPagedList<RoleViewDto> List(int pageIndex, int pageSize, string sortExpression, string code, string name);
        RoleViewDto GetDetail(string id);
        IList<RoleLookupDto> GetRoleLookup();
        Role GetById(string id);
        bool GetByCode(string code);
        bool CreateRole(Role entity);
        bool UpdateRole(Role entity);
        bool RemoveRole(string id);
        string GetRoleNameById(string id);
        bool CheckRoleById(string id, string roleCode);
    }
}
