using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Model.Commune
{
    public class FilterCommuneDto : PagedAndSortResultRequestDto
    {
        public int? ProvinceId { get; set; }
        public int? DistrictId { get; set; }
        public string Name { get; set; }
    }
}
