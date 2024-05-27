using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Model.QLHSC07_Dtos.RecordTypes
{
    public class FilterRecordTypesDto : PagedAndSortResultRequestDto
    {
        public string Name { get; set; }
    }
}
