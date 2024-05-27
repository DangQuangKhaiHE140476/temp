using System.Collections.Generic;

namespace QLHSC07.Model.SecurityMatrix
{
    public class SecurityMatrixListViewDto
    {
        public int Id { set; get; }
        public string RoleName { set; get; }
        public string RoleId { set; get; }
        public int ScreenId { set; get; }
        public string ScreenName { set; get; }
        public List<ActionLookupDto> Actions { set; get; }
    }
}
