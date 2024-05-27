using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Model.QLHSC07_Dtos.Projects
{
    public class FilterProjectDto : PagedAndSortResultRequestDto
    {
        public string Keyword { get; set; }
        public long? ConstructionTypeId { get; set; }
        public int? ProvinceId { get; set; }
        public int? DistrictId { get; set; }
        public int? CommuneId { get; set; }
        public long? ProjectStatusId { get; set; }
        public long? ProjectTypeId { get; set; }
        public bool? IsNewProject { get; set; }
    }
}
