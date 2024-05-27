using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Model
{
    public class PagedAndSortResultRequestDto : PagedResultRequestDto, ISortResultRequestDto
    {
        public string Sorting { get; set; }
        public bool? IsDelete { get; set; }
    }
}
