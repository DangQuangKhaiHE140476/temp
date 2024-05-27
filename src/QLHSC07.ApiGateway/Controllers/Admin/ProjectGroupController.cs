using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using QLHSC07.ApiGateway.Attribute;
using QLHSC07.ApiGateway.Controllers.BaseController;
using QLHSC07.ApiGateway.Service.Worker;
using QLHSC07.CORE;
using QLHSC07.CORE.Enum;
using QLHSC07.CORE.Helper;
using QLHSC07.CORE.Resource;
using QLHSC07.Entity.QLHSC07_Entities;
using QLHSC07.Model;
using QLHSC07.Model.QLHSC07_Dtos.Projects;
using QLHSC07.Model.QLHSC07_Dtos.ProjectGroup;
using QLHSC07.Services.Interfaces;
using QLHSC07.Services.Interfaces.QLHSC07;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QLHSC07.Infrastructure.Interface;

namespace QLHSC07.ApiGateway.Controllers.Admin
{
    [Route("api/admin/[controller]")]
    [ApiController]
    [Authorize]
    public class ProjectGroupController : GenericController<long, ProjectGroup, ProjectGroupDto, ProjectGroupDto, CreateProjectGroupDto, UpdateProjectGroupDto, FilterProjectGroupDto> 
    {
        private readonly IProjectGroupService _projectGroupService;
        public ProjectGroupController(IProjectGroupService projectGroupService,
            ILogHistoryService logHistoryService, IWorkerService workerService) : base(projectGroupService, logHistoryService, workerService)
        {
            _projectGroupService = projectGroupService;
        }
        [HttpPost("Create")]
        public override async Task<ActionResult> Create([FromBody] CreateProjectGroupDto request)
        {
            return await base.Create(request);
        }


        [HttpPost("Update")]
        public override async Task<ActionResult> Update([FromBody] UpdateProjectGroupDto request)
        {
            return await base.Update(request);
        }

        [HttpDelete("Delete/{id}")]
        public override async Task<ActionResult> Delete(long id)
        {
            return await base.Delete(id);
        }

        [HttpGet("GetAll")]
        public override async Task<ActionResult<IPagedList<ProjectGroupDto>>> GetAll([FromQuery]FilterProjectGroupDto filter)
        {
            return await base.GetAll(filter);
        }

        [HttpGet("GetDetail/{id}")]
        public override async Task<ActionResult<ProjectGroupDto>> GetById(long id)
        {
            return await base.GetById(id);
        }

        [HttpGet("GetLookup")]
        public async Task<ActionResult> GetLookup()
        {
            var result = _projectGroupService.GetLookupProjectGroup();
            //Xử lý nội dung get lookup.
            return Ok(new ResponseData
            {
                Content = result
            });
        }
    }
}
