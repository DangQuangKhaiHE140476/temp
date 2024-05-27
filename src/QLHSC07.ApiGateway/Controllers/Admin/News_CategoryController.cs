using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DATVANG.ApiGateway.Service.Worker;
using DATVANG.CORE;
using DATVANG.CORE.Enum;
using DATVANG.CORE.Helper;
using DATVANG.CORE.Resource;
using DATVANG.Model;
using DATVANG.Model.LogHistory;
using DATVANG.Model.NewsCategories;
using DATVANG.Model.User;
using DATVANG.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace DATVANG.ApiGateway.Controllers.Admin
{
    [Route("api/admin/[controller]/[action]")]
    [Authorize]
    public class News_CategoryController : ControllerBase
    {
        private readonly INews_CategoryService _categoryService;
        private readonly IMapper _mapper;
        private readonly ILogHistoryService _logHistoryService;
        private readonly IWorkerService _workerService;
        
        public News_CategoryController(INews_CategoryService categoryService, IMapper mapper, ILogHistoryService logHistoryService, IWorkerService workerService)
        {
            _categoryService = categoryService;
            _mapper = mapper;
            _logHistoryService = logHistoryService;
            _workerService = workerService;
        }

        [HttpPost]
        [ActionName("Create")]
        public async Task<ActionResult> Create([FromBody] CreateNews_CategoryDto createCategory)
        {
            if (!ModelState.IsValid && ModelState.Root.GetModelStateForProperty("IssuedDate").ValidationState != ModelValidationState.Invalid)
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.DataNotValid,
                    ErrorMessage = StringMessage.ErrorMessages.DataNotValid
                });
            }

            var response = await _categoryService.Create(createCategory);

            if (!response)
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.UnableHandleException,
                    ErrorMessage = StringMessage.ErrorMessages.ErrorProcess
                });

            CreateLogHistory(ActionEnum.VIEW.GetHashCode(), $"Create Category Successfull");

            return Ok(new ResponseData
            {
                Content = new
                {
                    Status = true
                }
            });
        }

        [HttpGet]
        [ActionName("GetListAll")]
        public async Task<ActionResult> GetListAll()
        {
            var data = await _categoryService.List(new FilterNews_CategoryDto
            {
                PageIndex = 1,
                PageSize = int.MaxValue,
                Sorting="Order ASC"
            });
            //var response = _mapper.Map<IPagedList<CMSNewsDto>>(data);
            return Ok(new ResponseData
            {
                Content = data
            });
        }

        private void CreateLogHistory(int action, string description)
        {
            CurrentUserDto currentUserModel = _workerService.GetCurrentUser();
            if (currentUserModel == null) return;
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
