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
using QLHSC07.Model.QLHSC07_Dtos.Investors;
using QLHSC07.Services.Interfaces;
using QLHSC07.Services.Interfaces.QLHSC07;
using System.Threading.Tasks;

namespace QLHSC07.ApiGateway.Controllers.Admin
{
    [Route("api/admin/[controller]")]
    [ApiController]
    [Authorize]
    public class InvestorController : GenericController<long, Investor, InvestorDto, InvestorDto, CreateInvestorDto, UpdateInvestorDto, FilterInvestorDto> 
    {
        private readonly IInvestorService _investorService;
        public InvestorController(IInvestorService investorService,
            ILogHistoryService logHistoryService, IWorkerService workerService) : base(investorService, logHistoryService, workerService)
        {
            _investorService = investorService;
        }
        [HttpPost("Create")]
        [RequiresPermission(RoleHelper.Action.Create, RoleHelper.Screen.Investor)]
        public override async Task<ActionResult> Create([FromBody] CreateInvestorDto request)
        {
            return await base.Create(request);
        }


        [HttpPost("Update")]
        [RequiresPermission(RoleHelper.Action.Update, RoleHelper.Screen.Investor)]
        public override async Task<ActionResult> Update([FromBody] UpdateInvestorDto request)
        {
            return await base.Update(request);
        }

        [HttpDelete("Delete/{id}")]
        [RequiresPermission(RoleHelper.Action.Delete, RoleHelper.Screen.Investor)]
        public override async Task<ActionResult> Delete(long id)
        {
            return await base.Delete(id);
        }

        [HttpGet("GetAll")]
        [RequiresPermission(RoleHelper.Action.View, RoleHelper.Screen.Investor)]
        public override async Task<ActionResult<IPagedList<InvestorDto>>> GetAll([FromQuery] FilterInvestorDto filter)
        {
            return await base.GetAll(filter);
        }
        [HttpGet("GetDetail/{id}")]
        public override async Task<ActionResult<InvestorDto>> GetById(long id)
        {
            return await base.GetById(id);
        }

        [HttpGet("GetLookup")]
        public  async Task<ActionResult> GetLookup()
        {
            var result = _investorService.GetLookupInvestors();
            //Xử lý nội dung get lookup.
            return Ok(new ResponseData
            {
                Content = result
            });
        }
        
        [HttpPost("CreateReturnInvestor")]
        public  async Task<ActionResult> CreateReturnInvestor([FromBody] CreateInvestorDto request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.DataNotValid,
                    ErrorMessage = StringMessage.ErrorMessages.DataNotValid
                });
            }

            if (null == request)
                return BadRequest();
            var result = await _investorService.CreateReturnInvestor(request);

            if (result.Result == null)
                return BadRequest(result.ResponseError);

            CreateLogHistory(ActionEnum.VIEW.GetHashCode(), $"Create {typeof(Investor)} Successfull");
            return Ok(new ResponseData
            {
                Content = result.Result
            });
        }
    }
}
