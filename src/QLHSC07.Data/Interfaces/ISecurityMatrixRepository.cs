using QLHSC07.Data.Repository;
using QLHSC07.Entity.SecurityMatrix;

namespace QLHSC07.Data.Interfaces
{
    public interface ISecurityMatrixRepository : IBaseRepository<SecurityMatrix>
    {
        bool CheckPermission(string roleName,string actionName,string screenName);
    }
}
