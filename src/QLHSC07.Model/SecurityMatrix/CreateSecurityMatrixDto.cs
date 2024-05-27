using System.Collections.Generic;

namespace QLHSC07.Model.SecurityMatrix
{
    public class CreateSecurityMatrixDto
    {
        public string RoleId { set; get; }
        public List<Screen> Screens { set; get; }
    }

    public class Screen
    {
        public int ScreenId { get; set; }
        public List<Action> Actions { set; get; }
    }

    public class Action
    {
        public int ActionId { get; set; }
    }
}
