using System.Collections.Generic;

namespace QLHSC07.Model.SecurityMatrix
{
    public class UpdateSecurityMatrixDto
    {
        public int Id { set; get; }
        public string RoleId { set; get; }
        public int ScreenId { set; get; }
        public List<int> Actions { set; get; }
    }
}
