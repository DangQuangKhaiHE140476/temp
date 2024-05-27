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
using QLHSC07.Model.QLHSC07_Dtos.PC07;
using QLHSC07.Services.Interfaces;
using QLHSC07.Services.Interfaces.QLHSC07;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QLHSC07.Infrastructure.Interface;
using DATVANG.ApiGateway.Middlewares;
using Microsoft.EntityFrameworkCore.Update.Internal;

namespace QLHSC07.ApiGateway.Controllers.Admin
{
    [Route("api/admin/[controller]")]
    [ApiController]
    [Authorize]
    public class PC07Controller : GenericController<long, PC07Local, PC07Dto, PC07Dto, CreatePC07Dto, UpdatePC07Dto, FilterPC07Dto> 
    {
        private readonly IPC07Service _pc07Service;
        public PC07Controller(IPC07Service pc07Service,
            ILogHistoryService logHistoryService, IWorkerService workerService) : base(pc07Service, logHistoryService, workerService)
        {
            _pc07Service = pc07Service;
        }
        [HttpPost("Create")]
        [RequiresPermission(RoleHelper.Action.Create, RoleHelper.Screen.PC07Local)]
        public override async Task<ActionResult> Create([FromBody] CreatePC07Dto request)
        {
            return await base.Create(request);
        }

        [HttpPost("Update")]
        [RequiresPermission(RoleHelper.Action.Update, RoleHelper.Screen.PC07Local)]
        public override async Task<ActionResult> Update([FromBody] UpdatePC07Dto request)
        {
            return await base.Update(request);
        }

        [HttpDelete("Delete/{id}")]
        [RequiresPermission(RoleHelper.Action.Delete, RoleHelper.Screen.PC07Local)]
        public override async Task<ActionResult> Delete(long id)
        {
            return await base.Delete(id);
        }

        [HttpGet("GetAll")]
        [RequiresPermission(RoleHelper.Action.View, RoleHelper.Screen.PC07Local)]
        [ServiceFilter(typeof(RecordPermissionAttribute))]
        public override async Task<ActionResult<IPagedList<PC07Dto>>> GetAll([FromQuery]FilterPC07Dto filter)
        {
            return await base.GetAll(filter);
        }

        [HttpGet("GetDetail/{id}")]
        public override async Task<ActionResult<PC07Dto>> GetById(long id)
        {
            return await base.GetById(id);
        }

        [HttpGet("GetLookup")]
        [ServiceFilter(typeof(RecordPermissionAttribute))]
        public async Task<ActionResult> GetLookup([FromQuery] FilterPC07LookupDto filter)
        {
            var result = _pc07Service.GetLookupPC07(filter);
            //Xử lý nội dung get lookup.
            return Ok(new ResponseData
            {
                Content = result
            });
        }

        [HttpGet("GetLookupNotFilter")]
        public async Task<ActionResult> GetLookupNotFilter()
        {
            var result = _pc07Service.GetLookupPC07(new FilterPC07LookupDto {  PC07ManageId=null});
            //Xử lý nội dung get lookup.
            return Ok(new ResponseData
            {
                Content = result
            });
        }
        [HttpPost("UpdateCode")]
        public async Task<ActionResult> UpdateCode()
        {
            var result = _pc07Service.UpdateCode();
            //Xử lý nội dung get lookup.
            return Ok(new ResponseData
            {
                Content = result
            });
        }
    }
}
