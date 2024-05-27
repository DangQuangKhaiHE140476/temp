using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Internal;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using QLHSC07.Services.Interfaces;
using QLHSC07.ApiGateway.Service.Worker;
using QLHSC07.ApiGateway.Attribute;
using QLHSC07.CORE.Helper;
using QLHSC07.CORE.Enum;
using QLHSC07.CORE;
using QLHSC07.Model.SecurityMatrix;
using QLHSC07.CORE.Resource;
using QLHSC07.Model.User;
using QLHSC07.Model.LogHistory;
using System.Threading.Tasks;

namespace QLHSC07.ApiGateway.Controllers.Admin
{
    [Route("api/admin/[controller]/[action]")]
    [ApiController]
    [Authorize]

    public class MenuController : ControllerBase
    {
        private readonly ISecurityMatrixService _securityMatrixService;
        private readonly ILogHistoryService _logHistoryService;
        private readonly IWorkerService _workerService;
        private readonly IRoleService _roleService;
        private readonly IMapper _mapper;
        public MenuController(ISecurityMatrixService securityMatrixService,
            ILogHistoryService logHistoryService, IWorkerService workerService, IRoleService roleService, IMapper mapper)
        {
            _securityMatrixService = securityMatrixService;
            _logHistoryService = logHistoryService;
            _workerService = workerService;
            _roleService = roleService;
            _mapper = mapper;

        }
        [HttpGet]
        [ActionName("GetMenu")]
        public async Task<ActionResult<ICollection<ScreenDto>>> GetMenu()
        {
            CurrentUserDto currentUserModel = _workerService.GetCurrentUser();
            if (currentUserModel == null) return null;

            var actions =await _securityMatrixService.GetListScreen(currentUserModel.Id);
            return Ok(new ResponseData
            {
                Content = actions
            });
        }
    }
}
