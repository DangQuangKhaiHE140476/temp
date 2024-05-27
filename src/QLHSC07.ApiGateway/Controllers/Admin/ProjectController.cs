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
    public class ProjectController : GenericController<long, Project, ProjectDto, ProjectDto, CreateProjectDto, UpdateProjectDto, FilterProjectDto>
    {
        private readonly IProjectService _projectService;
        public ProjectController(IProjectService projectService,
            ILogHistoryService logHistoryService, IWorkerService workerService) : base(projectService, logHistoryService, workerService)
        {
            _projectService = projectService;
        }

        [HttpPost("Create")]
        public override async Task<ActionResult> Create([FromBody] CreateProjectDto request)
        {
            var result = await _projectService.CreateProject(request, Constant.Admin);
            return Ok(new ResponseData
            {
                Content = result.Result
            });
        }

        [HttpPost("Update")]
        public override async Task<ActionResult> Update([FromBody] UpdateProjectDto request)
        {
            var result = await _projectService.UpdateProject(request, Constant.Admin);
            return Ok(new ResponseData
            {
                Content = result.Result
            });
        }

        [HttpDelete("Delete/{id}")]
        public override async Task<ActionResult> Delete(long id)
        {
            return await base.Delete(id);
        }

        [HttpDelete("DeletePermanent/{id}")]
        public override async Task<ActionResult> DeletePermanent(long id)
        {
            return await base.DeletePermanent(id);
        }

        [HttpGet("GetAll")]
        public override async Task<ActionResult<IPagedList<ProjectDto>>> GetAll([FromQuery] FilterProjectDto filter)
        {
            return await base.GetAll(filter);
        }

        [HttpGet("GetDetail/{id}")]
        public override async Task<ActionResult<ProjectDto>> GetById(long id)
        {
            return await base.GetById(id);
        }

        [HttpGet("GetLookup")]
        public async Task<ActionResult<BaseLookup<long>>> GetLookup([FromQuery] FilterProjectDto filter)
        {
            var result = (await _projectService.QueryFilter(filter))
                        .Select(c => new BaseLookup<long>
                        {
                            Id = c.Id,
                            Name = c.Name
                        });

            return Ok(new ResponseData
            {
                Content = result
            });
        }
        
        [HttpPut("UpdateStatus")]
        public async Task<ActionResult<ResponseItem<bool>>> UpdateStatus(long id, long statusId)
        {
            var result = await _projectService.UpdateStatus(id, statusId);
            return Ok(new ResponseData
            {
                Content = result.Result
            });
        }

        [HttpPost("ExportFile")]
        public async Task<ActionResult> ExportFile(string fileExtention, [FromQuery] FilterProjectDto filter)
        {
            var folder = "download_" + Guid.NewGuid();

            if (string.IsNullOrEmpty(fileExtention))
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.DataNotValid,
                    ErrorMessage = StringMessage.ErrorMessages.FileInvalid
                });
            }
            var file = folder + $".{fileExtention}";
            var result = await _projectService.Export(filter, fileExtention);
            return File(result, "application/octet-stream", file);
        }
    }
}
