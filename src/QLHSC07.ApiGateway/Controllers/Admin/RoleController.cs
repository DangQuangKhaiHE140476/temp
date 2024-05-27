using System;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using QLHSC07.ApiGateway.Attribute;
using QLHSC07.ApiGateway.Service.Worker;
using QLHSC07.CORE;
using QLHSC07.CORE.Enum;
using QLHSC07.CORE.Helper;
using QLHSC07.CORE.Resource;
using QLHSC07.Entity.IdentityAccess;
using QLHSC07.Model.LogHistory;
using QLHSC07.Model.Role;
using QLHSC07.Model.User;
using QLHSC07.Services.Interfaces;

namespace QLHSC07.ApiGateway.Controllers.Admin
{
    [Route("api/admin/[controller]/[action]")]
    [ApiController]
    [Authorize]

    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService;
        private readonly IMapper _mapper;
        private readonly ILogHistoryService _logHistoryService;
        private readonly IWorkerService _workerService;
        public RoleController(IRoleService roleService, IMapper mapper, ILogHistoryService logHistoryService, IWorkerService workerService)
        {
            _roleService = roleService;
            _mapper = mapper;
            _logHistoryService = logHistoryService;
            _workerService = workerService;
        }
        [HttpGet]
        [ActionName("GetListRole")]
        [RequiresPermission(RoleHelper.Action.View, RoleHelper.Screen.RoleManagement)]
        public ActionResult GetListRole(int pageIndex, int pageSize, string sortExpression,string code,string name)
        {
            var data = _roleService.List(pageIndex, pageSize, sortExpression, code , name);
            CreateLogHistory(ActionEnum.VIEW.GetHashCode(), "GetListRole");
            return Ok(new ResponseData
            {
                Content = data
            });
        }

        [HttpGet]
        [ActionName("GetRoleLookup")]
        [RequiresPermission(RoleHelper.Action.View, RoleHelper.Screen.RoleManagement)]
        public ActionResult GetRoleLookup(){
            var data = _roleService.GetRoleLookup();
            CreateLogHistory(ActionEnum.VIEW.GetHashCode(), "GetRoleLookup");
            return Ok(new ResponseData
            {
                Content = data
            });
        }
        [HttpGet]
        [ActionName("GetDetailRole")]
        [RequiresPermission(RoleHelper.Action.View, RoleHelper.Screen.RoleManagement)]
        public ActionResult GetDetailRole(string id)
        {
            var data = _roleService.GetDetail(id);
            CreateLogHistory(ActionEnum.VIEW.GetHashCode(), "GetDetailRole");
            return Ok(new ResponseData
            {
                Content = data
            });
        }
        [HttpPost]
        [ActionName("CreateRole")]
        [RequiresPermission(RoleHelper.Action.Create, RoleHelper.Screen.RoleManagement)]
        public ActionResult CreateRole([FromBody]CreateRoleDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.DataNotValid,
                    ErrorMessage = StringMessage.ErrorMessages.DataNotValid
                });
            }

            var existedRole = _roleService.GetByCode(model.Code);
            if (existedRole)
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.ExistsRoleCode,
                    ErrorMessage = StringMessage.ErrorMessages.ExistsRoleCode
                });
            }
            var entity = new Role
            {
                Name = model.Name,
                NormalizedName = model.Code,
                Id = Guid.NewGuid().ToString(),
                Code = model.Code,
                CreatedDate = DateTime.Now,
                ModifiedBy = "Administrator",
                ModifiedDate = DateTime.Now,
                CreatedBy = "Administrator"
            };
            var isCreated = _roleService.CreateRole(entity);
            if (!isCreated)
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.ErrorProcess,
                    ErrorMessage = StringMessage.ErrorMessages.ErrorProcess
                });
            CreateLogHistory(ActionEnum.CREATE.GetHashCode(), "CreateRole");
            return Ok(new ResponseData
            {
                Content = new
                {
                    Status = true
                }
            });
        }
        [HttpPost]
        [ActionName("UpdateRole")]
        [RequiresPermission(RoleHelper.Action.Update, RoleHelper.Screen.RoleManagement)]
        public ActionResult UpdateRole([FromBody] UpdateRoleDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.DataNotValid,
                    ErrorMessage = StringMessage.ErrorMessages.DataNotValid
                });
            }
            
            var entity = _roleService.GetById(model.Id);

            entity.ModifiedDate = DateTime.Now;
            entity.Code = model.Code;
            entity.Name = model.Name;

            var isUpdate = _roleService.UpdateRole(entity);
            if (!isUpdate)
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.ErrorProcess,
                    ErrorMessage = StringMessage.ErrorMessages.ErrorProcess
                });
            CreateLogHistory(ActionEnum.UPDATE.GetHashCode(), "UpdateRole");
            return Ok(new ResponseData
            {
                Content = new
                {
                    Status = true
                }
            });
        }
        [HttpPost]
        [ActionName("DeleteRole")]
        [RequiresPermission(RoleHelper.Action.Delete, RoleHelper.Screen.RoleManagement)]
        public ActionResult DeleteRole(string id)
        {
            if (!ModelState.IsValid) return BadRequest(new ResponseErrorData
            {
                ErrorType = ErrorTypeConstant.DataNotValid,
                ErrorMessage = StringMessage.ErrorMessages.DataNotValid
            });
            var isDeleted = _roleService.RemoveRole(id);
            if (!isDeleted)
                return BadRequest(new ResponseErrorData
                {
                    ErrorMessage = StringMessage.ErrorMessages.ErrorProcess,
                    ErrorType = ErrorTypeConstant.ErrorProcess
                });
            CreateLogHistory(ActionEnum.DELETE.GetHashCode(), "DeleteRole");
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
