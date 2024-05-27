using QLHSC07.Entity.QLHSC07_Entities;
using QLHSC07.Model.QLHSC07_Dtos.ProjectType;
using QLHSC07.Services.BaseServices;
using System.Collections.Generic;

namespace QLHSC07.Services.Interfaces.QLHSC07
{
    public interface IProjectTypeService : IBaseService<long, ProjectType, ProjectTypeDto, ProjectTypeDto, CreateProjectTypeDto, UpdateProjectTypeDto, FilterProjectTypeDto>
    {
        IList<ProjectTypeLookupDto> GetLookupProjectType();
    }
}
