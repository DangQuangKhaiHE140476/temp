using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using QLHSC07.ApiGateway.Controllers.BaseController;
using QLHSC07.ApiGateway.Service.Worker;
using QLHSC07.CORE;
using QLHSC07.Infrastructure.Interface;
using QLHSC07.Services.Interfaces;
using System.Threading.Tasks;
using QLHSC07.Entity.CRM;
using QLHSC07.Model.CRM.Client;
using QLHSC07.Services.Interfaces.CRM;

namespace QLHSC07.ApiGateway.Controllers.Admin
{
    [Route("api/admin/[controller]")]
    [ApiController]
    [Authorize]
    public class ClientController : GenericController<long, Client, ClientViewDto, ClientViewDto, CreateClientDto, UpdateClientDto, FilterClientDto>
    {
        private readonly IClientService _service;
        public ClientController(IClientService service,
            ILogHistoryService logHistoryService, IWorkerService workerService) : base(service, logHistoryService, workerService)
        {
            _service = service;
        }
        [HttpPost("Create")]
        public override async Task<ActionResult> Create([FromBody] CreateClientDto request)
        {
            return await base.Create(request);
        }


        [HttpPost("Update")]
        public override async Task<ActionResult> Update([FromBody] UpdateClientDto request)
        {
            return await base.Update(request);
        }

        [HttpDelete("Delete/{id}")]
        public override async Task<ActionResult> Delete(long id)
        {
            return await base.Delete(id);
        }

        [HttpGet("GetAll")]
        public override async Task<ActionResult<IPagedList<ClientViewDto>>> GetAll([FromQuery] FilterClientDto filter)
        {
            return await base.GetAll(filter);
        }
        [HttpGet("GetDetail/{id}")]
        public override async Task<ActionResult<ClientViewDto>> GetById(long id)
        {
            return await base.GetById(id);
        }

        [HttpGet("GetLookup")]
        public async Task<ActionResult> GetLookup()
        {
            var result = _service.GetLookup();
            //Xử lý nội dung get lookup.
            return Ok(new ResponseData
            {
                Content = result
            });
        }
    }
}
