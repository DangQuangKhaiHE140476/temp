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

namespace QLHSC07.ApiGateway.Controllers.Admin
{
    [Route("api/admin/[controller]/[action]")]
    [ApiController]
    [Authorize]

    public class PermissionController : ControllerBase
    {
        private readonly ISecurityMatrixService _securityMatrixService;
        private readonly ILogHistoryService _logHistoryService;
        private readonly IWorkerService _workerService;
        private readonly IRoleService _roleService;
        private readonly IMapper _mapper;
        public PermissionController(ISecurityMatrixService securityMatrixService,
            ILogHistoryService logHistoryService, IWorkerService workerService, IRoleService roleService, IMapper mapper)
        {
            _securityMatrixService = securityMatrixService;
            _logHistoryService = logHistoryService;
            _workerService = workerService;
            _roleService = roleService;
            _mapper = mapper;

        }
        [HttpGet]
        [ActionName("GetActionLookup")]
        [RequiresPermission(RoleHelper.Action.View, RoleHelper.Screen.SecurityMatrix)]
        public ActionResult GetActionLookup()
        {
            var actions = _securityMatrixService.GetActionLookup();
            CreateLogHistory(ActionEnum.VIEW.GetHashCode(), "GetActionLookup");
            return Ok(new ResponseData
            {
                Content = actions
            });
        }
        [HttpGet]
        [ActionName("GetScreenLookup")]
        [RequiresPermission(RoleHelper.Action.View, RoleHelper.Screen.SecurityMatrix)]
        public ActionResult GetScreenLookup()
        {
            var screens = _securityMatrixService.GetScreenLookup();
            CreateLogHistory(ActionEnum.VIEW.GetHashCode(), "GetScreenLookup");
            return Ok(new ResponseData
            {
                Content = screens
            });
        }
        [HttpGet]
        [ActionName("GetSecurityMatrix")]
        [RequiresPermission(RoleHelper.Action.View, RoleHelper.Screen.SecurityMatrix)]
        public ActionResult GetSecurityMatrix(int pageIndex, int pageSize, string sortExpression, string roleName, string screenName)
        {
            var securityMatrices = _securityMatrixService.GetListSecurityMatrix(pageIndex, pageSize, sortExpression, roleName, screenName);
            CreateLogHistory(ActionEnum.VIEW.GetHashCode(), "GetSecurityMatrix");
            return Ok(new ResponseData
            {
                Content = securityMatrices
            });
        }
        [HttpGet]
        [ActionName("GetSecurityMatrixDetail")]
        [RequiresPermission(RoleHelper.Action.View, RoleHelper.Screen.SecurityMatrix)]
        public ActionResult GetSecurityMatrixDetail(string RoleId)
        {
            var securityMatrices = _securityMatrixService.GetDetailSecurityMatrix(RoleId);
            CreateLogHistory(ActionEnum.VIEW.GetHashCode(), "GetSecurityMatrixDetail");
            return Ok(new ResponseData
            {
                Content = securityMatrices
            });
        }
        [HttpPost]
        [ActionName("UpdateSecurityMatrix")]
        [RequiresPermission(RoleHelper.Action.Update, RoleHelper.Screen.SecurityMatrix)]//require admin permission
        public ActionResult UpdateSecurityMatrix(CreateSecurityMatrixDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.DataNotValid,
                    ErrorMessage = StringMessage.ErrorMessages.DataNotValid
                });
            }
            var listIds = model.Screens.Select(entry => entry.ScreenId).ToList();
            if (listIds.Any() && listIds.Distinct().Count() != model.Screens.Count())
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.DuplicateScreens,
                    ErrorMessage = StringMessage.ErrorMessages.DuplicateScreens
                });
            }

            var isUpdated = _securityMatrixService.UpdateSecurityMatrix(model);
            if (!isUpdated)
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorMessage = StringMessage.ErrorMessages.ErrorProcess,
                    ErrorType = ErrorTypeConstant.ErrorProcess
                });
            }
            return Ok(new ResponseData
            {
                Content = new
                {
                    Status = true
                }
            });
        }

        //[HttpPost]
        //[ActionName("CreateSecurityMatrix")]
        //[RequiresPermission(RoleHelper.Action.Create, RoleHelper.Screen.SecurityMatrix)]//require admin permission
        //public ActionResult CreateSecurityMatrix(CreateSecurityMatrixModel model)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(new ResponseErrorData
        //        {
        //            ErrorType = ErrorTypeConstant.DataNotValid,
        //            ErrorMessage = StringMessage.ErrorMessages.DataNotValid
        //        });
        //    }
        //    var isCreated = _securityMatrixService.CreateSecurityMatrix(model);
        //    if (!isCreated)
        //    {
        //        return BadRequest(new ResponseErrorData
        //        {
        //            ErrorMessage = StringMessage.ErrorMessages.ErrorProcess,
        //            ErrorType = ErrorTypeConstant.ErrorProcess
        //        });
        //    }
        //    return Ok(new ResponseData
        //    {
        //        Content = new
        //        {
        //            Status = true
        //        }
        //    });
        //}

        [HttpGet]
        [ActionName("CheckPermission")]
        public ActionResult CheckPermission(string roleName, string actionName, string screenName)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.DataNotValid,
                    ErrorMessage = StringMessage.ErrorMessages.DataNotValid
                });
            }

            bool havePermission = false;

            if (string.IsNullOrEmpty(roleName))
            {
                CurrentUserDto currentUserModel = _workerService.GetCurrentUser();
                foreach (var item in currentUserModel.Roles)
                {
                    havePermission = _securityMatrixService.CheckPermission(item.Code, actionName, screenName);
                    if (havePermission) break;
                }
            }

            //havePermission = _securityMatrixService.CheckPermission(roleName,actionName,screenName);

            if (!havePermission)
            {
                return Ok(new ResponseData
                {
                    Content = new
                    {
                        Status = false
                    }
                });
            }
            return Ok(new ResponseData
            {
                Content = new
                {
                    Status = true
                }
            });
        }

        private void CreateLogHistory(int action, string description)
        {
            CurrentUserDto currentUserModel = _workerService.GetCurrentUser();
            LogHistoryDto logHistoryModel = new LogHistoryDto
            {
                Action = action,
                Description = description,
                UserName = currentUserModel.FullName
            };
            _logHistoryService.Create(logHistoryModel, currentUserModel);
        }
    }
}
