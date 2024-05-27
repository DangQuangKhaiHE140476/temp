using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Model.QLHSC07_Dtos.Regency
{
    public class FilterRegencyDto : PagedAndSortResultRequestDto
    {
        public string Name { get; set; }
    }
}
