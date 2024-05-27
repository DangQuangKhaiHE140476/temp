using System.Collections.Generic;
using NetTopologySuite.Geometries.Utilities;

namespace QLHSC07.Model.SecurityMatrix
{
    public class ActionViewDto
    {
        public int ActionId { get; set; }
        public string ActionName { get; set; }
    }

    public class ScreenViewDto
    {
        public int ScreenId { get; set; }
        public string ScreenName { get; set; }
        public List<ActionViewDto> Actions { get; set; }
    }
}
