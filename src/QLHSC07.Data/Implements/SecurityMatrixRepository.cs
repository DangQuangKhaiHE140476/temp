using System.Linq;
using QLHSC07.CORE.Helper;
using QLHSC07.Data.Interfaces;
using QLHSC07.Data.Repository;
using QLHSC07.Entity.SecurityMatrix;

namespace QLHSC07.Data.Implements
{
    public class SecurityMatrixRepository : BaseRepository<SecurityMatrix>,ISecurityMatrixRepository
    {
        public SecurityMatrixRepository(AppDbContext context) : base(context)
        {
        }

        public bool CheckPermission(string roleName, string actionName, string screenName)
        {
            var data = (from t in _dbContext.SecurityMatrix
                join s in _dbContext.Screen on t.ScreenId equals s.Id
                join a in _dbContext.Action on t.ActionId equals a.Id
                join r in _dbContext.Role on t.RoleId equals r.Id 
                where r.Code == roleName && s.Code == screenName && (a.Code == actionName || a.Code== RoleHelper.Action.FullPermission) //add a.Code
                select t).FirstOrDefault();
            return data != null;
        }
    }
}
