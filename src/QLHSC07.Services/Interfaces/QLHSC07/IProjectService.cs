using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLHSC07.CORE;
using QLHSC07.Entity.QLHSC07_Entities;
using QLHSC07.Infrastructure.Interface;
using QLHSC07.Model.QLHSC07_Dtos.Projects;
using QLHSC07.Services.BaseServices;
namespace QLHSC07.Services.Interfaces.QLHSC07
{
    public interface IProjectService: IBaseService<long, Project, ProjectDto, ProjectDto, CreateProjectDto, UpdateProjectDto, FilterProjectDto>
    {
        Task<IQueryable<Project>> QueryFilter(FilterProjectDto filter);
        Task<ResponseItem<bool>> UpdateStatus(long id, long statusId);
        Task<byte[]> Export(FilterProjectDto filter, string fileExtention);
        Dictionary<string, long> GetProjectDictionary(List<string> projectName);
        Task<ResponseItem<bool>> CreateProject(CreateProjectDto request, string createUser);
        Task<ResponseItem<bool>> UpdateProject(UpdateProjectDto request, string createUser);
    }
}
