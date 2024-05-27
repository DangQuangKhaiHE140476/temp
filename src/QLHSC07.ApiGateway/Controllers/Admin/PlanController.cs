using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using QLHSC07.ApiGateway.Controllers.BaseController;
using QLHSC07.ApiGateway.Service.Worker;
using QLHSC07.CORE;
using QLHSC07.Infrastructure.Interface;
using QLHSC07.Services.Interfaces;
using System.Threading.Tasks;
using QLHSC07.Entity.CRM;
using QLHSC07.Model.CRM.Plan;
using QLHSC07.Services.Interfaces.CRM;

namespace QLHSC07.ApiGateway.Controllers.Admin
{
    [Route("api/admin/[controller]")]
    [ApiController]
    [Authorize]
    public class PlanController : GenericController<long, Plan, PlanViewDto, PlanViewDto, CreatePlanDto, UpdatePlanDto, FilterPlanDto>
    {
        private readonly IPlanService _service;
        public PlanController(IPlanService service,
            ILogHistoryService logHistoryService, IWorkerService workerService) : base(service, logHistoryService, workerService)
        {
            _service = service;
        }
        [HttpPost("Create")]
        public override async Task<ActionResult> Create([FromBody] CreatePlanDto request)
        {
            return await base.Create(request);
        }


        [HttpPost("Update")]
        public override async Task<ActionResult> Update([FromBody] UpdatePlanDto request)
        {
            return await base.Update(request);
        }

        [HttpDelete("Delete/{id}")]
        public override async Task<ActionResult> Delete(long id)
        {
            return await base.Delete(id);
        }

        [HttpGet("GetAll")]
        public override async Task<ActionResult<IPagedList<PlanViewDto>>> GetAll([FromQuery] FilterPlanDto filter)
        {
            return await base.GetAll(filter);
        }
        [HttpGet("GetDetail/{id}")]
        public override async Task<ActionResult<PlanViewDto>> GetById(long id)
        {
            return await base.GetById(id);
        }

    }
}
