using QLHSC07.Entity.QLHSC07_Entities;
using QLHSC07.Model.QLHSC07_Dtos.ProjectGroup;
using QLHSC07.Services.BaseServices;
using System.Collections.Generic;

namespace QLHSC07.Services.Interfaces.QLHSC07
{
    public interface IProjectGroupService : IBaseService<long, ProjectGroup, ProjectGroupDto, ProjectGroupDto, CreateProjectGroupDto, UpdateProjectGroupDto, FilterProjectGroupDto>
    {
        IList<ProjectGroupLookupDto> GetLookupProjectGroup();
    }
}
