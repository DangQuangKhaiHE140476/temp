using Microsoft.AspNetCore.Mvc;
using QLHSC07.ApiGateway.Controllers.BaseController;
using QLHSC07.ApiGateway.Service.Worker;
using QLHSC07.CORE;
using QLHSC07.CORE.Enum;
using QLHSC07.CORE.Helper;
using QLHSC07.CORE.Resource;
using QLHSC07.Model.QLHSC07_Dtos.MsgExchange;
using QLHSC07.Services.Interfaces;
using QLHSC07.Services.Interfaces.QLHSC07;
using System.Collections.Generic;
using System.Threading.Tasks;
using QLHSC07.Entity.QLHSC07_MSG_Entities;
using QLHSC07.Infrastructure.Interface;
using Microsoft.AspNetCore.Http;
using QLHSC07.Model.QLHSC07_Dtos.MsgExchangeService;
using Microsoft.AspNetCore.Authorization;

namespace QLHSC07.ApiGateway.Controllers.Admin
{
    [Route("api/admin/[controller]")]
    [ApiController]
    [Authorize]
    public class MsgExchangeController : GenericController<string, MsgSession, MsgSessionDto, MsgSessionDto, CreateMsgExchange, UpdateMsgExchangeDto, FilterMsgExchangeDto>
    {
        private readonly IMsgExchangeService _msgExchangeService;
        private readonly IWorkerService _workerService;

        public MsgExchangeController(IMsgExchangeService msgExchangeService,
            ILogHistoryService logHistoryService, IWorkerService workerService) : base(msgExchangeService, logHistoryService, workerService)
        {
            _msgExchangeService = msgExchangeService;
            _workerService = workerService;
        }
        [HttpPost("Create")]
        public override async Task<ActionResult> Create([FromForm] CreateMsgExchange request)
        {
            return Ok(new ResponseData
            {
                Content = "Pleas do not use this function",
                Err = "Pleas do not use this function"
            });
        }

        [HttpPost("CreateMsg")]
        public async Task<ActionResult> CreateMsg([FromForm] CreateMsgExchange request, List<IFormFile> files)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.DataNotValid,
                    ErrorMessage = StringMessage.ErrorMessages.DataNotValid
                });
            }

            ///get current user
            var user = _workerService.GetCurrentUser();
            if (user == null)
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.DataNotValid,
                    ErrorMessage = StringMessage.ErrorMessages.UserInvalid
                });
            }
            var result = await _msgExchangeService.SendDocuments(request, user, files);

            if (!result.Result)
                return BadRequest(result.ResponseError);

            CreateLogHistory(ActionEnum.VIEW.GetHashCode(), $"Create Message Exchange Successfull");

            return Ok(new ResponseData
            {
                Content = new
                {
                    Status = true
                }
            });
        }


        [HttpPut("Update")]
        public override async Task<ActionResult> Update([FromForm] UpdateMsgExchangeDto request)
        {
            return Ok(new ResponseData
            {
                Content = "Pleas do not use this function",
                Err = "Pleas do not use this function"
            });
        }

        [HttpDelete("Delete/{id}")]
        public override async Task<ActionResult> Delete(string id)
        {
            return await base.Delete(id);
        }

        [HttpDelete("DeleteBaseOnSession")]
        public async Task<ActionResult> DeleteBaseOnSession(string session)
        {
            var user = _workerService.GetCurrentUser();
            if (user == null)
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = StringMessage.ErrorMessages.UserInvalid,
                    ErrorMessage = StringMessage.ErrorMessages.DataNotValid
                });
            }

            if (string.IsNullOrEmpty(session))
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = StringMessage.ErrorMessages.SessionOrUserIsNull,
                    ErrorMessage = StringMessage.ErrorMessages.DataNotValid
                });
            }
            var result = await _msgExchangeService.Delete(
                new FilterDetailMsgSessionDto
                {
                    SessionId = session
                }, user.Email);

            if (!result.Result)
                return BadRequest(result.ResponseError);

            CreateLogHistory(ActionEnum.VIEW.GetHashCode(), $"DeleteBaseOnSession Message Exchange Successfull");

            return Ok(new ResponseData
            {
                Content = new
                {
                    Status = true
                }
            });
        }

        [HttpDelete("DeletePermanentBaseOnSession")]
        public async Task<ActionResult> DeletePermanentBaseOnSession(string session)
        {
            var user = _workerService.GetCurrentUser();
            if (user == null)
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = StringMessage.ErrorMessages.UserInvalid,
                    ErrorMessage = StringMessage.ErrorMessages.DataNotValid
                });
            }

            if (string.IsNullOrEmpty(session) )
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = StringMessage.ErrorMessages.SessionOrUserIsNull,
                    ErrorMessage = StringMessage.ErrorMessages.DataNotValid
                });
            }

            var result = await _msgExchangeService.DeletePermanent(new FilterDetailMsgSessionDto
            {
                SessionId = session
            });

            if (!result.Result)
                return BadRequest(result.ResponseError);

            CreateLogHistory(ActionEnum.VIEW.GetHashCode(), $"Delete Message Exchange Successfull");

            return Ok(new ResponseData
            {
                Content = new
                {
                    Status = true
                }
            });
        }

        [HttpGet("GetAll")]
        public override async Task<ActionResult<IPagedList<MsgSessionDto>>> GetAll([FromQuery] FilterMsgExchangeDto filter)
        {
            var result= await base.GetAll(filter);
            return Ok(new ResponseData
            {
                Content = result
            });
        }
        [HttpGet("GetDetail/{id}")]
        public override async Task<ActionResult<MsgSessionDto>> GetById(string id)
        {
            var result= await base.GetById(id);
            return Ok(new ResponseData
            {
                Content = result
            });
        }

        [HttpGet("GetDetailDocumentReceive")]
        public async Task<ActionResult<MsgSessionDictDto>> GetDetailDocumentReceive(string session)
        {
            var user = _workerService.GetCurrentUser();
            if (user == null)
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = StringMessage.ErrorMessages.UserInvalid,
                    ErrorMessage = StringMessage.ErrorMessages.DataNotValid
                });
            }

            if (string.IsNullOrEmpty(session) )
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = StringMessage.ErrorMessages.SessionOrUserIsNull,
                    ErrorMessage = StringMessage.ErrorMessages.DataNotValid
                });
            }
            var result= await _msgExchangeService.GetDetailDocumentReceive(
                new FilterDetailMsgSessionDto
                {
                    SessionId = session
                });
            return Ok(new ResponseData
            {
                Content = result
            });
        }

        [HttpGet("GetDetailDocumentSent")]
        public async Task<ActionResult<MsgSessionDictDto>> GetDetailDocumentSent(string session)
        {
            var user = _workerService.GetCurrentUser();
            if (user == null)
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = StringMessage.ErrorMessages.UserInvalid,
                    ErrorMessage = StringMessage.ErrorMessages.DataNotValid
                });
            }

            if (string.IsNullOrEmpty(session) )
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = StringMessage.ErrorMessages.SessionOrUserIsNull,
                    ErrorMessage = StringMessage.ErrorMessages.DataNotValid
                });
            }
            var result= await _msgExchangeService.GetDetailDocumentSent(
                new FilterDetailMsgSessionDto
                {
                    SessionId = session
                });
            return Ok(new ResponseData
            {
                Content = result
            });
        }

        
        
    }
}
