using Microsoft.AspNetCore.Mvc;
using QLHSC07.ApiGateway.Controllers.BaseController;
using QLHSC07.ApiGateway.Service.Worker;
using QLHSC07.CORE;
using QLHSC07.Entity.QLHSC07_Entities;
using QLHSC07.Infrastructure.Interface;
using QLHSC07.Model.QLHSC07_Dtos.RecordTypes;
using QLHSC07.Services.Interfaces;
using QLHSC07.Services.Interfaces.QLHSC07;
using System.Threading.Tasks;

namespace QLHSC07.ApiGateway.Controllers.Admin
{
    [Route("api/admin/[controller]")]
    [ApiController]
    //[Authorize]
    public class RecordsTypeController : GenericController<long, RecordsType, RecordTypesDto, RecordTypesDto, CreateRecordTypesDto, UpdateRecordTypesDto, FilterRecordTypesDto> 
    {
        private readonly IRecordTypesService _recordsTypeService;
        public RecordsTypeController(IRecordTypesService recordsTypeService,
            ILogHistoryService logHistoryService, IWorkerService workerService) : base(recordsTypeService, logHistoryService, workerService)
        {
            _recordsTypeService = recordsTypeService;
        }
        [HttpPost("Create")]
        public override async Task<ActionResult> Create([FromBody] CreateRecordTypesDto request)
        {
            return await base.Create(request);
        }


        [HttpPost("Update")]
        public override async Task<ActionResult> Update([FromBody] UpdateRecordTypesDto request)
        {
            return await base.Update(request);
        }

        [HttpDelete("Delete/{id}")]
        public override async Task<ActionResult> Delete(long id)
        {
            return await base.Delete(id);
        }

        [HttpGet("GetAll")]
        public override async Task<ActionResult<IPagedList<RecordTypesDto>>> GetAll([FromQuery]FilterRecordTypesDto filter)
        {
            return await base.GetAll(filter);
        }
        [HttpGet("GetDetail/{id}")]
        public override async Task<ActionResult<RecordTypesDto>> GetById(long id)
        {
            return await base.GetById(id);
        }

        [HttpGet("GetLookup")]
        public async Task<ActionResult> GetLookup()
        {
            var result = _recordsTypeService.GetLookupRecordTypes();
            //Xử lý nội dung get lookup.
            return Ok(new ResponseData
            {
                Content = result
            });
        }
    }
}
