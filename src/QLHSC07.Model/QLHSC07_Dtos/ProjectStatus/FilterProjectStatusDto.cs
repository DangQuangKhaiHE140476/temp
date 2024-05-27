using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Model.QLHSC07_Dtos.ProjectStatus
{
    public class FilterProjectStatusDto : PagedAndSortResultRequestDto
    {
        public string Name { get; set; }
    }
}
