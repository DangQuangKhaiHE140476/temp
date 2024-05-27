using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using QLHSC07.ApiGateway.Attribute;
using QLHSC07.ApiGateway.Controllers.BaseController;
using QLHSC07.ApiGateway.Service.Worker;
using QLHSC07.CORE;
using QLHSC07.CORE.Enum;
using QLHSC07.CORE.Helper;
using QLHSC07.CORE.Resource;
using QLHSC07.Entity.QLHSC07_Entities;
using QLHSC07.Infrastructure.Interface;
using QLHSC07.Model.QLHSC07_Dtos.Records;
using QLHSC07.Services.Interfaces;
using QLHSC07.Services.Interfaces.QLHSC07;
using System;
using System.Threading.Tasks;

namespace QLHSC07.ApiGateway.Controllers.Admin
{
    [Route("api/admin/[controller]")]
    [ApiController]
    [Authorize]
    public class RecordsController : GenericController<long, Records, RecordsDto, RecordsDto, CreateRecordsDto, UpdateRecordsDto, FilterRecordsDto>
    {
        private readonly IWorkerService _workerService;
        private readonly IRecordsService _recordsService;

        public RecordsController(IRecordsService recordsService,
            ILogHistoryService logHistoryService, IHostEnvironment env, IWorkerService workerService) : base(recordsService, logHistoryService, workerService)
        {
            _workerService = workerService;
            _recordsService = recordsService;
        }
        [HttpPost("Create")]
        [RequiresPermission(RoleHelper.Action.Create, RoleHelper.Screen.Records)]
        public override async Task<ActionResult> Create([FromForm] CreateRecordsDto request)
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

            ///get email user
            var uploadFolderPath = Constant.PathName.RecordsFolder;

            var user = _workerService.GetCurrentUser();
            var result = await _recordsService.CreateRecord(request, uploadFolderPath, user);
            if (!result.Result)
                return BadRequest(result.ResponseError);

            CreateLogHistory(ActionEnum.VIEW.GetHashCode(), $"Create {typeof(Records)} Successfull");

            return Ok(new ResponseData
            {
                Content = new
                {
                    Status = result.Result
                }
            });
        }


        [HttpPost("Update")]
        [RequiresPermission(RoleHelper.Action.Update, RoleHelper.Screen.Records)]
        public override async Task<ActionResult> Update([FromForm] UpdateRecordsDto request)
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

            ///get email user
            var uploadFolderPath = Constant.PathName.RecordsFolder;

            var user = _workerService.GetCurrentUser();
            var result = await _recordsService.UpdateRecord(request, uploadFolderPath, user);
            if (!result.Result)
                return BadRequest(result.ResponseError);

            CreateLogHistory(ActionEnum.VIEW.GetHashCode(), $"Create {typeof(Records)} Successfull");

            return Ok(new ResponseData
            {
                Content = new
                {
                    Status = result.Result
                }
            });
        }

        [HttpDelete("Delete/{id}")]
        [RequiresPermission(RoleHelper.Action.Delete, RoleHelper.Screen.Records)]
        public override async Task<ActionResult> Delete(long id)
        {
            var user = _workerService.GetCurrentUser();
            if (user == null)
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.DataNotValid,
                    ErrorMessage = StringMessage.ErrorMessages.UserHasNotLocal07
                });
            }

            var result = await _recordsService.Delete(id, user.Email);
            return Ok(new ResponseData
            {
                Content = new
                {
                    Status = result
                }
            });
        }
        
        [HttpDelete("DeletePermanent/{id}")]
        [RequiresPermission(RoleHelper.Action.Delete, RoleHelper.Screen.Records)]
        public override async Task<ActionResult> DeletePermanent(long id)
        {
            var user = _workerService.GetCurrentUser();
            if (user == null)
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.DataNotValid,
                    ErrorMessage = StringMessage.ErrorMessages.UserHasNotLocal07
                });
            }

            var result = await _recordsService.DeletePermanent(id, user.Email);
            return Ok(new ResponseData
            {
                Content = new
                {
                    Status = result
                }
            });
        }
        
        [HttpGet("GetAll")]
        [RequiresPermission(RoleHelper.Action.View, RoleHelper.Screen.Records)]
        [ServiceFilter(typeof(RecordPermissionAttribute))]
        public override async Task<ActionResult<IPagedList<RecordsDto>>> GetAll([FromQuery] FilterRecordsDto filter)
        {
            return await base.GetAll(filter);
        }
        [HttpGet("GetDetail/{id}")]
        public override async Task<ActionResult<RecordsDto>> GetById(long id)
        {
            return await base.GetById(id);
        }

        [HttpPost("UpdateStatus")]
        public async Task<ActionResult<ResponseItem<bool>>> UpdateStatus([FromBody] UpdateStatusRecordsDto recordsStatus)
        {
            var result = await _recordsService.UpdateStatus(recordsStatus);
            return Ok(new ResponseData
            {
                Content = result.Result
            });
        }

        [HttpPost("ExportFile")]
        [ServiceFilter(typeof(RecordPermissionAttribute))]
        public async Task<ActionResult> ExportFile(string fileExtention, [FromQuery] FilterRecordsDto filter)
        {
            var folder = "download_" + Guid.NewGuid();

            if (string.IsNullOrEmpty(fileExtention))
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.DataNotValid,
                    ErrorMessage = StringMessage.ErrorMessages.FileInvalid
                });
            }
            var file = folder + $".{fileExtention}";
            var result = await _recordsService.Export(filter, fileExtention);
            return File(result, "application/octet-stream", file);
        }

        [HttpPost("ReportRecordChart")]
        [ServiceFilter(typeof(RecordPermissionAttribute))]
        public async Task<ActionResult> ReportRecordChart([FromQuery] ReportRecordChartFilter filter)
        {

            if (filter == null)
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.DataNotValid,
                    ErrorMessage = StringMessage.ErrorMessages.InputInvalid
                });
            }
            var result = await _recordsService.ReportRecordChart(filter);
            if (result == null)
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.DataNotValid,
                    ErrorMessage = StringMessage.ErrorMessages.ProcessError
                });
            }
            return Ok(new ResponseData
            {
                Content = new
                {
                    Status = result
                }
            });
        }

        [HttpGet("RecordInfoAtLocal")]
        [ServiceFilter(typeof(RecordPermissionAttribute))]
        public ActionResult RecordInfoAtLocal([FromQuery] RecordInfoAtLocalFilter filter)
        {
            var result = _recordsService.RecordInfoAtLocal(filter);
            return Ok(new ResponseData
            {
                Content = new
                {
                    Status = result
                }
            });
        }
    }
}
