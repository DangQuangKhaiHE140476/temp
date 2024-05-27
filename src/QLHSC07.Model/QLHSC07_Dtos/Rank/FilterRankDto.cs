using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Model.QLHSC07_Dtos.Rank
{
    public class FilterRankDto : PagedAndSortResultRequestDto
    {
        public string Name { get; set; }
    }
}
