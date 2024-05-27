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
using QLHSC07.Model.QLHSC07_Dtos.AttachFileType;
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
    public class AttachFileTypeController : GenericController<long, FileTypeAttachment, AttachFileTypeDto, AttachFileTypeDto, CreateAttachFileTypeDto, UpdateAttachFileTypeDto, FilterAttachFileTypeDto> 
    {
        private readonly IAttachFileTypeService _attachFileTypeService;
        public AttachFileTypeController(IAttachFileTypeService attachFileTypeService,
            ILogHistoryService logHistoryService, IWorkerService workerService) : base(attachFileTypeService, logHistoryService, workerService)
        {
            _attachFileTypeService = attachFileTypeService;
        }
        [HttpPost("Create")]
        [RequiresPermission(RoleHelper.Action.Create, RoleHelper.Screen.AttachFileType)]
        public override async Task<ActionResult> Create([FromBody] CreateAttachFileTypeDto request)
        {
            return await base.Create(request);
        }


        [HttpPost("Update")]
        [RequiresPermission(RoleHelper.Action.Update, RoleHelper.Screen.AttachFileType)]
        public override async Task<ActionResult> Update([FromBody] UpdateAttachFileTypeDto request)
        {
            return await base.Update(request);
        }

        [HttpDelete("Delete/{id}")]
        [RequiresPermission(RoleHelper.Action.Delete, RoleHelper.Screen.AttachFileType)]
        public override async Task<ActionResult> Delete(long id)
        {
            return await base.Delete(id);
        }


        [HttpDelete("DeletePermanent/{id}")]
        [RequiresPermission(RoleHelper.Action.Delete, RoleHelper.Screen.AttachFileType)]
        public override async Task<ActionResult> DeletePermanent(long id)
        {
            return await base.DeletePermanent(id);
        }

        [HttpGet("GetAll")]
        [RequiresPermission(RoleHelper.Action.View, RoleHelper.Screen.AttachFileType)]
        public override async Task<ActionResult<IPagedList<AttachFileTypeDto>>> GetAll(FilterAttachFileTypeDto filter)
        {
            return await base.GetAll(filter);
        }
        [HttpGet("GetDetail/{id}")]
        public override async Task<ActionResult<AttachFileTypeDto>> GetById(long id)
        {
            return await base.GetById(id);
        }

        [HttpGet("GetLookup")]
        public  async Task<ActionResult<IList<AttachFileTypeLookupDto>>> GetLookup()
        {
            var result = await _attachFileTypeService.GetLookupAttachFileType();
            //Xử lý nội dung get lookup.
            return Ok(new ResponseData
            {
                Content = result
            });
        }
        
        [HttpGet("GetLookupRecordsType")]
        public  async Task<ActionResult<IList<AttachFileTypeLookupDto>>> GetLookupByRecordsType(long recordsTypeId)
        {
            var result = await _attachFileTypeService.GetLookupByReCordType(recordsTypeId);
            //Xử lý nội dung get lookup.
            return Ok(new ResponseData
            {
                Content = result
            });
        }
    }
}
