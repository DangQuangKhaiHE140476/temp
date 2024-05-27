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
using QLHSC07.Infrastructure.Interface;
using QLHSC07.Model;
using QLHSC07.Model.QLHSC07_Dtos.Projects;
using QLHSC07.Model.QLHSC07_Dtos.ProjectType;
using QLHSC07.Services.Interfaces;
using QLHSC07.Services.Interfaces.QLHSC07;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLHSC07.ApiGateway.Controllers.Admin
{
    [Route("api/admin/[controller]")]
    [ApiController]
    [Authorize]
    public class ProjectTypeController : GenericController<long, ProjectType, ProjectTypeDto, ProjectTypeDto, CreateProjectTypeDto, UpdateProjectTypeDto, FilterProjectTypeDto> 
    {
        private readonly IProjectTypeService _projectTypeService;
        public ProjectTypeController(IProjectTypeService projectTypeService,
            ILogHistoryService logHistoryService, IWorkerService workerService) : base(projectTypeService, logHistoryService, workerService)
        {
            _projectTypeService = projectTypeService;
        }
        [HttpPost("Create")]
        [RequiresPermission(RoleHelper.Action.Create, RoleHelper.Screen.ConstructionType)]
        public override async Task<ActionResult> Create([FromBody] CreateProjectTypeDto request)
        {
            return await base.Create(request);
        }

        [HttpPost("Update")]
        [RequiresPermission(RoleHelper.Action.Update, RoleHelper.Screen.ConstructionType)]
        public override async Task<ActionResult> Update([FromBody] UpdateProjectTypeDto request)
        {
            return await base.Update(request);
        }

        [HttpDelete("Delete/{id}")]
        [RequiresPermission(RoleHelper.Action.Delete, RoleHelper.Screen.ConstructionType)]
        public override async Task<ActionResult> Delete(long id)
        {
            return await base.Delete(id);
        }

        [HttpGet("GetAll")]
        [RequiresPermission(RoleHelper.Action.View, RoleHelper.Screen.ConstructionType)]
        public override async Task<ActionResult<IPagedList<ProjectTypeDto>>> GetAll([FromQuery]FilterProjectTypeDto filter)
        {
            return await base.GetAll(filter);
        }
        [HttpGet("GetDetail/{id}")]
        public override async Task<ActionResult<ProjectTypeDto>> GetById(long id)
        {
            return await base.GetById(id);
        }

        [HttpGet("GetLookup")]
        public async Task<ActionResult> GetLookup()
        {
            var result = _projectTypeService.GetLookupProjectType();
            //Xử lý nội dung get lookup.
            return Ok(new ResponseData
            {
                Content = result
            });
        }
    }
}
