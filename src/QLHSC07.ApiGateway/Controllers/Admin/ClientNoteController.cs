using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using QLHSC07.ApiGateway.Controllers.BaseController;
using QLHSC07.ApiGateway.Service.Worker;
using QLHSC07.CORE;
using QLHSC07.Infrastructure.Interface;
using QLHSC07.Services.Interfaces;
using System.Threading.Tasks;
using QLHSC07.Entity.CRM;
using QLHSC07.Model.CRM.ClientNote;
using QLHSC07.Services.Interfaces.CRM;

namespace QLHSC07.ApiGateway.Controllers.Admin
{
    [Route("api/admin/[controller]")]
    [ApiController]
    [Authorize]
    public class ClientNoteController : GenericController<long, ClientNote, ClientNoteViewDto, ClientNoteViewDto, CreateClientNoteDto, UpdateClientNoteDto, FilterClientNoteDto>
    {
        private readonly IClientNoteService _service;
        public ClientNoteController(IClientNoteService service,
            ILogHistoryService logHistoryService, IWorkerService workerService) : base(service, logHistoryService, workerService)
        {
            _service = service;
        }
        [HttpPost("Create")]
        public override async Task<ActionResult> Create([FromBody] CreateClientNoteDto request)
        {
            return await base.Create(request);
        }


        [HttpPost("Update")]
        public override async Task<ActionResult> Update([FromBody] UpdateClientNoteDto request)
        {
            return await base.Update(request);
        }

        [HttpDelete("Delete/{id}")]
        public override async Task<ActionResult> Delete(long id)
        {
            return await base.Delete(id);
        }

        [HttpGet("GetAll")]
        public override async Task<ActionResult<IPagedList<ClientNoteViewDto>>> GetAll([FromQuery] FilterClientNoteDto filter)
        {
            return await base.GetAll(filter);
        }
        [HttpGet("GetDetail/{id}")]
        public override async Task<ActionResult<ClientNoteViewDto>> GetById(long id)
        {
            return await base.GetById(id);
        }

    }
}
