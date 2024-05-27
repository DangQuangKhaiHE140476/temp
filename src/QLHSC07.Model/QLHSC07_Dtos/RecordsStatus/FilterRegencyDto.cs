using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Model.QLHSC07_Dtos.RecordsStatus
{
    public class FilterRecordsStatusDto : PagedAndSortResultRequestDto
    {
        public string Name { get; set; }
    }
}
