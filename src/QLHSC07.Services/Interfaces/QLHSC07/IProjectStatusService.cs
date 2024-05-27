using QLHSC07.Entity.QLHSC07_Entities;
using QLHSC07.Model.QLHSC07_Dtos.ProjectStatus;
using QLHSC07.Services.BaseServices;
using System.Collections.Generic;

namespace QLHSC07.Services.Interfaces.QLHSC07
{
    public interface IProjectStatusService : IBaseService<long, ProjectStatus, ProjectStatusDto, ProjectStatusDto, CreateProjectStatusDto, UpdateProjectStatusDto, FilterProjectStatusDto>
    {
        IList<ProjectStatusLookupDto> GetLookupProjectStatus();
    }
}
