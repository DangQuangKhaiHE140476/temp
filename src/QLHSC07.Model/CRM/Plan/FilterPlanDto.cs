using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Model.CRM.Plan
{
    public class FilterPlanDto : PagedAndSortResultRequestDto
    {
        public string Name { get; set; }
    }
}
