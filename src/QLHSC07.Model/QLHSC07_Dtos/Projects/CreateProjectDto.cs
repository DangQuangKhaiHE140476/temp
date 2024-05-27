using QLHSC07.Model.BaseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Model.QLHSC07_Dtos.Projects
{
    public class CreateProjectDto : BaseCreateDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long InvestorId { get; set; }
        public long ProjectTypeId { get; set; }
        public long ProjectGroupId { get; set; }
        public string Address { get; set; }
        public List<int> CommuneIds { get; set; }
        public string BuildingSite { get; set; }
        public long? ProjectStatusId { get; set; }
        public string Note { get; set; }
        //public long ConstructionTypeId { get; set; }
    }
}
