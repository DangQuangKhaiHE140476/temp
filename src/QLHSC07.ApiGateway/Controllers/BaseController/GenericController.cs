using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QLHSC07.ApiGateway.Service.Worker;
using QLHSC07.CORE;
using QLHSC07.CORE.Enum;
using QLHSC07.CORE.Helper;
using QLHSC07.CORE.Resource;
using QLHSC07.Infrastructure.Interface;
using QLHSC07.Model;
using QLHSC07.Model.BaseModels;
using QLHSC07.Services.BaseServices;
using QLHSC07.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLHSC07.ApiGateway.Controllers.BaseController
{
    public abstract class GenericController<T, TEntity, TEntityDto, TListEntityDto, TCreateDto, TUpdateDto, TFilterDto> : QLHSBaseController
       where TEntity : class, new()
       where TEntityDto : FullAuditedEntityDto<T>, new()
       where TListEntityDto : FullAuditedEntityDto<T>, new()
       where TCreateDto : BaseCreateDto, new()
       where TUpdateDto : EntityDto<T>, new()
       where TFilterDto : PagedAndSortResultRequestDto, new()
    {
        protected readonly IBaseService<T, TEntity, TEntityDto, TListEntityDto, TCreateDto, TUpdateDto, TFilterDto> _baseService;
        protected GenericController(IBaseService<T, TEntity, TEntityDto, TListEntityDto, TCreateDto, TUpdateDto, TFilterDto> baseService,
            ILogHistoryService logHistoryService, IWorkerService workerService) : base(logHistoryService, workerService)
        {
            _baseService = baseService;
        }
        [HttpPost("Create")]
        public virtual async Task<ActionResult> Create([FromForm] TCreateDto request)
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
            var result = await _baseService.Create(request);

            if (!result.Result)
                return BadRequest(result.ResponseError);

            CreateLogHistory(ActionEnum.VIEW.GetHashCode(), $"Create {typeof(TEntity)} Successfull");

            return Ok(new ResponseData
            {
                Content = new
                {
                    Status = true
                }
            });
        }
        [HttpPost("Update")]
        public virtual async Task<ActionResult> Update([FromForm] TUpdateDto request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.DataNotValid,
                    ErrorMessage = StringMessage.ErrorMessages.DataNotValid
                });
            }

            var result = await _baseService.Update(request);
            if (!result.Result)
                return BadRequest(result.ResponseError);

            CreateLogHistory(ActionEnum.VIEW.GetHashCode(), $"Update {typeof(TEntity)} with Id={request.Id} Successfull");

            return Ok(new ResponseData
            {
                Content = new
                {
                    Status = true
                }
            });
        }
        [HttpDelete("Delete/{id}")]
        public virtual async Task<ActionResult> Delete(T id)
        {
            var result = await _baseService.Delete(id);
            if (!result.Result)
                return BadRequest(result.ResponseError);

            CreateLogHistory(ActionEnum.DELETE.GetHashCode(), $"Delete {typeof(TEntity)} Id={id} permanent Successfull");
            return Ok(new ResponseData
            {
                Content = new
                {
                    Status = true
                }
            });
        }

        [HttpDelete("DeletePermanent/{id}")]
        public virtual async Task<ActionResult> DeletePermanent(T id)
        {
            var result = await _baseService.DeletePermanent(id);

            if (!result.Result)
                return BadRequest(result.ResponseError);

            CreateLogHistory(ActionEnum.DELETE.GetHashCode(), $"Delete {typeof(TEntity)} Id={id} permanent Successfull");
            return Ok(new ResponseData
            {
                Content = new
                {
                    Status = true
                }
            });
        }

        [HttpGet("GetAll")]
        public virtual async Task<ActionResult<IPagedList<TListEntityDto>>> GetAll([FromQuery] TFilterDto filter)
        {
            var result = await _baseService.GetAll(filter);
            return Ok(new ResponseData
            {
                Content = result
            });
        }

        [HttpGet("GetDetail/{id}")]
        public virtual async Task<ActionResult<TEntityDto>> GetById(T id)
        {
            var result = await _baseService.GetById(id);

            return Ok(new ResponseData
            {
                Content = result
            });
        }
    }
}
