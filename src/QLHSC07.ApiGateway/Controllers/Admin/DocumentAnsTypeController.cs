using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using QLHSC07.ApiGateway.Controllers.BaseController;
using QLHSC07.ApiGateway.Service.Worker;
using QLHSC07.CORE;
using QLHSC07.Entity.QLHSC07_Entities;
using QLHSC07.Infrastructure.Interface;
using QLHSC07.Model.QLHSC07_Dtos.DocumentAnsType;
using QLHSC07.Services.Interfaces;
using QLHSC07.Services.Interfaces.QLHSC07;
using System.Threading.Tasks;

namespace QLHSC07.ApiGateway.Controllers.Admin
{
    [Route("api/admin/[controller]")]
    [ApiController]
    [Authorize]
    public class DocumentAnsTypeController : GenericController<long, DocumentAnsType, DocumentAnsTypeDto, DocumentAnsTypeDto, CreateDocumentAnsTypeDto, UpdateDocumentAnsTypeDto, FilterDocumentAnsTypeDto> 
    {
        private readonly IDocumentAnsTypeService _documentAnsTypeService;
        public DocumentAnsTypeController(IDocumentAnsTypeService documentAnsTypeService,
            ILogHistoryService logHistoryService, IWorkerService workerService) : base(documentAnsTypeService, logHistoryService, workerService)
        {
            _documentAnsTypeService = documentAnsTypeService;
        }
        [HttpPost("Create")]
        public override async Task<ActionResult> Create([FromBody] CreateDocumentAnsTypeDto request)
        {
            return await base.Create(request);
        }


        [HttpPost("Update")]
        public override async Task<ActionResult> Update([FromBody] UpdateDocumentAnsTypeDto request)
        {
            return await base.Update(request);
        }

        [HttpDelete("Delete/{id}")]
        public override async Task<ActionResult> Delete(long id)
        {
            return await base.Delete(id);
        }

        [HttpGet("GetAll")]
        public override async Task<ActionResult<IPagedList<DocumentAnsTypeDto>>> GetAll([FromQuery] FilterDocumentAnsTypeDto filter)
        {
            return await base.GetAll(filter);
        }
        [HttpGet("GetDetail/{id}")]
        public override async Task<ActionResult<DocumentAnsTypeDto>> GetById(long id)
        {
            return await base.GetById(id);
        }

        [HttpGet("GetLookup")]
        public async Task<ActionResult> GetLookup()
        {
            var result = _documentAnsTypeService.GetLookupDocumentAnsType();
            //Xử lý nội dung get lookup.
            return Ok(new ResponseData
            {
                Content = result
            });
        }
    }
}
