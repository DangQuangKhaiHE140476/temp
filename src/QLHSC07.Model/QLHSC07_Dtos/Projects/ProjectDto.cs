using QLHSC07.Entity.QLHSC07_Entities;
using QLHSC07.Model.BaseModels;
using QLHSC07.Model.QLHSC07_Dtos.Investors;
using QLHSC07.Model.QLHSC07_Dtos.Records;
using System.Collections.Generic;

namespace QLHSC07.Model.QLHSC07_Dtos.Projects
{
    public class ProjectDto: FullAuditedEntityDto<long>
    {
        public string Name { get; set; }
        public long InvestorId { get; set; }
        public InvestorDto Investors { get; set; }

        public long ProjectTypeId { get; set; }
        public string ProjectTypeName { get; set; }

        public long ProjectGroupId { get; set; }
        public string ProjectGroupName { get; set; }

        public string Address { get; set; }

        public List<Positions> Positions { get; set; }

        public string BuildingSite { get; set; }

        public long? ProjectStatusId { get; set; }
        public string ProjectStatusName { get; set; }

        public string Note { get; set; }
        public List<int> ProjectHasCommuneId { get; set; }
        //public long ConstructionTypeId { get; set; }
        //public string ConstructionTypeName { get; set; }
        public ICollection<RecordsDto> Records { get; set; }
    }
    public class Positions
    {
        public PositionKeyValue Commune { get; set; }
        public PositionKeyValue District { get; set; }
        public PositionKeyValue Province { get; set; }
    }
    public class PositionKeyValue
    {
        public int? Id { get; set; }
        public string Value { get; set; }
    }
}
