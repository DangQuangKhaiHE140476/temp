
using System;
using System.Threading.Tasks;
using AutoMapper;
using System.Linq;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DATVANG.Services.Interfaces;
using DATVANG.ApiGateway.Service.Worker;
using DATVANG.CORE.FileService;
using DATVANG.Model.Newses;
using DATVANG.Model;
using DATVANG.CORE.Resource;
using DATVANG.CORE.Helper;
using DATVANG.CORE.Enum;
using DATVANG.Model.User;
using DATVANG.Model.LogHistory;
using DATVANG.CORE;

namespace DATVANG.ApiGateway.Controllers.Admin
{
    [Route("api/admin/[controller]/[action]")]
    [Authorize]
    public class NewsController : ControllerBase
    {
        private readonly INewsService _newsService;
        private readonly IMapper _mapper;
        private readonly ILogHistoryService _logHistoryService;
        private readonly IWorkerService _workerService;
        private readonly IFileService _fileService;
        public NewsController(INewsService newsService, IMapper mapper, ILogHistoryService logHistoryService, IWorkerService workerService, IFileService fileService)
        {
            _newsService = newsService;
            _mapper = mapper;
            _logHistoryService = logHistoryService;
            _workerService = workerService;
            _fileService = fileService;
        }

        [HttpPost]
        [ActionName("Create")]
        public async Task<ActionResult> Create([FromForm] CreateNewsDto createNews)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.DataNotValid,
                    ErrorMessage = StringMessage.ErrorMessages.DataNotValid
                });
            }

            var response = await _newsService.Create(createNews);

            if (!response)
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.UnableHandleException,
                    ErrorMessage = StringMessage.ErrorMessages.ErrorProcess
                });

            CreateLogHistory(ActionEnum.VIEW.GetHashCode(), $"Create News Successfull");
            return Ok(new ResponseData
            {
                Content = new
                {
                    Status = true
                }
            });
        }

        [HttpPost]
        [ActionName("Update")]
        public async Task<ActionResult> Update([FromForm] UpdateNewsDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.DataNotValid,
                    ErrorMessage = StringMessage.ErrorMessages.DataNotValid
                });
            }

            var isUpdate = await _newsService.Update(model);

            if (!isUpdate)
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.UnableHandleException,
                    ErrorMessage = StringMessage.ErrorMessages.ErrorProcess
                });

            CreateLogHistory(ActionEnum.UPDATE.GetHashCode(), "Update News Successfull");
            return Ok(new ResponseData
            {
                Content = new
                {
                    Status = true
                }
            });
        }

        [HttpPost]
        [ActionName("Delete/{id}/{xmin}")]
        public async Task<ActionResult> Delete(long id, uint xmin)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.DataNotValid,
                    ErrorMessage = StringMessage.ErrorMessages.DataNotValid
                });
            }

            var isDelete = await _newsService.Delete(id, xmin);

            if (!isDelete)
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.UnableHandleException,
                    ErrorMessage = StringMessage.ErrorMessages.ErrorProcess
                });
            CreateLogHistory(ActionEnum.DELETE.GetHashCode(), "DeleteStatement");
            return Ok(new ResponseData
            {
                Content = new
                {
                    Status = true
                }
            });
        }

        [HttpPost]
        [ActionName("Restore/{id}")]
        public async Task<ActionResult> Restore(long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.DataNotValid,
                    ErrorMessage = StringMessage.ErrorMessages.DataNotValid
                });
            }

            var isRestore = await _newsService.Restore(id);

            if (!isRestore)
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.UnableHandleException,
                    ErrorMessage = StringMessage.ErrorMessages.ErrorProcess
                });
            CreateLogHistory(ActionEnum.DELETE.GetHashCode(), "Restore Layer Category Parent");
            return Ok(new ResponseData
            {
                Content = new
                {
                    Status = true
                }
            });
        }

        [HttpPost]
        [ActionName("EmptyTrash")]
        public async Task<ActionResult> EmptyTrash()
        {
            var isDelete = await _newsService.EmptyTrash();

            if (!isDelete)
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.UnableHandleException,
                    ErrorMessage = StringMessage.ErrorMessages.ErrorProcess
                });
            CreateLogHistory(ActionEnum.DELETE.GetHashCode(), "Empty Trash");
            return Ok(new ResponseData
            {
                Content = new
                {
                    Status = true
                }
            });
        }

        [HttpPost]
        [ActionName("ChangeActiveStatus")]
        public async Task<ActionResult> ChangeStatus(NewsChangeStatusRequestDto input)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.DataNotValid,
                    ErrorMessage = StringMessage.ErrorMessages.DataNotValid
                });
            }

            var isDelete = await _newsService.ChangeActiveStatus(input.Ids, input.Status);

            if (!isDelete)
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.UnableHandleException,
                    ErrorMessage = StringMessage.ErrorMessages.ErrorProcess
                });
            CreateLogHistory(ActionEnum.DELETE.GetHashCode(), $"Change Active Status to {input.Status} follow newses: {input.Ids.Select(x=>x.ToString()).Join(",")}");
            return Ok(new ResponseData
            {
                Content = new
                {
                    Status = true
                }
            });
        }

        [HttpPost]
        [ActionName("ChangeHotStatus")]
        public async Task<ActionResult> ChangeHotStatus(NewsChangeStatusRequestDto input)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.DataNotValid,
                    ErrorMessage = StringMessage.ErrorMessages.DataNotValid
                });
            }

            var isDelete = await _newsService.ChangeHotStatus(input.Ids, input.Status);

            if (!isDelete)
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.UnableHandleException,
                    ErrorMessage = StringMessage.ErrorMessages.ErrorProcess
                });
            CreateLogHistory(ActionEnum.DELETE.GetHashCode(), $"Change Active Status to {input.Status} follow newses: {input.Ids.Select(x => x.ToString()).Join(",")}");
            return Ok(new ResponseData
            {
                Content = new
                {
                    Status = true
                }
            });
        }

        [HttpPost]
        [ActionName("ChangeFeatureStatus")]
        public async Task<ActionResult> ChangeFeatureStatus(NewsChangeStatusRequestDto input)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.DataNotValid,
                    ErrorMessage = StringMessage.ErrorMessages.DataNotValid
                });
            }

            var isDelete = await _newsService.ChangeFeatureStatus(input.Ids, input.Status);

            if (!isDelete)
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.UnableHandleException,
                    ErrorMessage = StringMessage.ErrorMessages.ErrorProcess
                });
            CreateLogHistory(ActionEnum.DELETE.GetHashCode(), $"Change Active Status to {input.Status} follow newses: {input.Ids.Select(x => x.ToString()).Join(",")}");
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
        public async Task<ActionResult> GetListAll(FilterNewsAdminDto input)
        {
            var data = await _newsService.ListAll(input);
            return Ok(new ResponseData
            {
                Content = data
            });
        }

        [HttpGet]
        [ActionName("GetListByCat")]
        public async Task<ActionResult> GetListByCat(FilterNewsByCatetoryDto input)
        {
            var data = await _newsService.ListByCategory(input);

            return Ok(new ResponseData
            {
                Content = data
            });
        }

        [HttpGet]
        [ActionName("GetListHot")]
        public async Task<ActionResult> GetListHot(FilterHotNewsDto input)
        {
            var data = await _newsService.ListHotNews(input);

            return Ok(new ResponseData
            {
                Content = data
            });
        }

        [HttpGet]
        [ActionName("GetListFeature")]
        public async Task<ActionResult> GetListFeature(FilterFeatureNewsDto input)
        {
            var data = await _newsService.ListFeatureNews(input);

            return Ok(new ResponseData
            {
                Content = data
            });
        }

        [HttpGet]
        [ActionName("GetListByStatus")]
        public async Task<ActionResult> GetListByStatus(FilterNewsByStatusDto input)
        {
            var data = await _newsService.ListByStatus(input);

            return Ok(new ResponseData
            {
                Content = data
            });
        }

        [HttpGet]
        [ActionName("GetDetail/{id}")]
        public async Task<ActionResult> GetDetail(long id)
        {
            var data = await _newsService.GetById(id);

            return Ok(new ResponseData
            {
                Content = data
            });
        }
        private void CreateLogHistory(int action, string description)
        {
            CurrentUserDto currentUserModel = _workerService.GetCurrentUser();
            if (currentUserModel == null)
                return;
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
