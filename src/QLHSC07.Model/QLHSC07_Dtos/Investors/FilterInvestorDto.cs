using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Model.QLHSC07_Dtos.Investors
{
    public class FilterInvestorDto : PagedAndSortResultRequestDto
    {
        public string Keyword { get; set; }
        public int? ProvinceId { get; set; }
        public int? DistrictId { get; set; }
        public int? CommuneId { get; set; }
    }
}
