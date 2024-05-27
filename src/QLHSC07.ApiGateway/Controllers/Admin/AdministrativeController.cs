using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using QLHSC07.ApiGateway.Attribute;
using QLHSC07.ApiGateway.Service.Worker;
using QLHSC07.CORE;
using QLHSC07.CORE.Enum;
using QLHSC07.CORE.FileService;
using QLHSC07.CORE.Helper;
using QLHSC07.CORE.Resource;
using QLHSC07.Entity.Administrative;
using QLHSC07.Model.Commune;
using QLHSC07.Model.District;
using QLHSC07.Model.Province;
using QLHSC07.Services.Interfaces;

namespace QLHSC07.ApiGateway.Controllers.Admin
{
    [Route("api/admin/[controller]/[action]")]
    [Authorize]
    public class AdministrativeController : QLHSBaseController
    {
        private readonly IProvinceService _provinceService;
        private readonly IDistrictService _districtService;
        private readonly ICommuneService _communeService;
        private readonly IMapper _mapper;
        private readonly IWorkerService _workerService;
        private readonly IFileService _fileService;

        public AdministrativeController(IProvinceService provinceService, IMapper mapper, IDistrictService districtService,
            ICommuneService communeService, ILogHistoryService logHistoryService, IWorkerService workerService, IFileService fileService): base(logHistoryService, workerService)
        {
            _provinceService = provinceService;
            _mapper = mapper;
            _districtService = districtService;
            _communeService = communeService;
            _workerService = workerService;
            _fileService = fileService;
        }

        

        [HttpGet]
        [ActionName("GetLookupProvince")]
        [AllowAnonymous]
        public ActionResult GetLookupProvince()
        {
            var data = _provinceService.GetLookupProvince();
            //CreateLogHistory(ActionEnum.VIEW.GetHashCode(), "GetDetailProvince");
            return Ok(new ResponseData
            {
                Content = data
            });
        }
        [HttpGet]
        [ActionName("GetListProvince")]
        [RequiresPermission(RoleHelper.Action.View, RoleHelper.Screen.Province)]
        public ActionResult GetListProvince(FilterProvince filter)
        {
            var data = _provinceService.List(filter);
            //CreateLogHistory(ActionEnum.VIEW.GetHashCode(), "GetListProvince");
            return Ok(new ResponseData
            {
                Content = data
            });
        }
        [HttpGet]
        [ActionName("GetDetailProvince")]
        public ActionResult GetDetailProvince(int id)
        {
            var data = _provinceService.GetProvinceById(id);
            //CreateLogHistory(ActionEnum.VIEW.GetHashCode(), "GetDetailProvince");
            return Ok(new ResponseData
            {
                Content = data
            });
        }

        [HttpPost]
        [ActionName("CreateProvince")]
        [RequiresPermission(RoleHelper.Action.Create, RoleHelper.Screen.Province)]
        public ActionResult CreateProvince([FromBody] CreateProvinceDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.DataNotValid,
                    ErrorMessage = StringMessage.ErrorMessages.DataNotValid
                });
            }

            var entity = _mapper.Map<Province>(model);
            entity.CreatedDate = DateTime.Now;
            entity.CreatedBy = "Administrator";
            entity.ModifiedBy = "Administrator";
            entity.ModifiedDate = DateTime.Now;

            var isCreated = _provinceService.Create(entity);
            if (!isCreated)
                return BadRequest(new ResponseErrorData
                {
                    ErrorMessage = StringMessage.ErrorMessages.ErrorProcess,
                    ErrorType = ErrorTypeConstant.ErrorProcess
                });
            CreateLogHistory(ActionEnum.CREATE.GetHashCode(), "Create Province Successfull");
            return Ok(new ResponseData
            {
                Content = new
                {
                    Status = true
                }
            });
        }
        [HttpPost]
        [ActionName("UpdateProvince")]
        [RequiresPermission(RoleHelper.Action.Update, RoleHelper.Screen.Province)]
        public ActionResult UpdateProvince([FromBody] UpdateProvinceDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.DataNotValid,
                    ErrorMessage = StringMessage.ErrorMessages.DataNotValid
                });
            }

            var entityExits = _provinceService.GetById(model.Id);
            var entity = MapModelToEntity(model, entityExits);
            entity.ModifiedBy = "Administrator";
            entity.ModifiedDate = DateTime.Now;
            var isUpdate = _provinceService.Update(entity);

            if (!isUpdate)
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.UnableHandleException,
                    ErrorMessage = StringMessage.ErrorMessages.ErrorProcess
                });
            CreateLogHistory(ActionEnum.UPDATE.GetHashCode(), "Update Province Successfull");
            return Ok(new ResponseData
            {
                Content = new
                {
                    Status = true
                }
            });
        }

        [HttpPost]
        [ActionName("DeleteProvince")]
        [RequiresPermission(RoleHelper.Action.Delete, RoleHelper.Screen.Province)]
        public ActionResult DeleteProvince(DeleteProvinceDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.DataNotValid,
                    ErrorMessage = StringMessage.ErrorMessages.DataNotValid
                });
            }

            var isDelete = _provinceService.Delete(model);

            if (isDelete == "OK")
            {
                CreateLogHistory(ActionEnum.UPDATE.GetHashCode(), $"Delete Province {model.ProvinceId} Successfull");
                return Ok(new ResponseData
                {
                    Content = new
                    {
                        Status = true
                    }
                });
            }
            return Ok(new ResponseErrorData
            {
                ErrorType = ErrorTypeConstant.ProvinceIsUsed,
                ErrorMessage = "Tỉnh chứa Quận/Huyện đang được quy hoạch. Bạn không thể xóa bản ghi này!"  //isDelete
            });

        }

        [HttpGet]
        [ActionName("GetListDistrict")]
        [RequiresPermission(RoleHelper.Action.View, RoleHelper.Screen.District)]
        public ActionResult GetListDistrict(int pageIndex, int pageSize, string sortExpression, string name = null)
        {
            var data = _districtService.List(pageIndex, pageSize, sortExpression, name?.Trim());
            //CreateLogHistory(ActionEnum.UPDATE.GetHashCode(), "GetListDistrict");
            return Ok(new ResponseData
            {
                Content = data
            });
        }
        [HttpGet]
        [ActionName("GetLookupDistrict")]
        [AllowAnonymous]
        public ActionResult GetLookupDistrict(int provinceId)
        {
            var data = _districtService.GetDistrict(provinceId);
            return Ok(new ResponseData
            {
                Content = data
            });
        }

        [HttpGet]
        [ActionName("GetLookupDistrictMultiProvince")]
        [AllowAnonymous]
        public ActionResult GetLookupDistrictMultiProvince(ICollection<int> provinceIds)
        {
            if (provinceIds == null || provinceIds.Count <= 0)
                return Ok(new ResponseData
                {
                    Content = new List<DistrictLookupDto>()
                });
            var data = _districtService.GetDistrict(provinceIds);
            return Ok(new ResponseData
            {
                Content = data
            });
        }

        [HttpGet]
        [ActionName("GetDetailDistrict")]
        public ActionResult GetDetailDistrict(int id)
        {
            var data = _districtService.GetDistrictById(id);
            return Ok(new ResponseData
            {
                Content = data
            });
        }

        [HttpPost]
        [ActionName("CreateDistrict")]
        [RequiresPermission(RoleHelper.Action.Create, RoleHelper.Screen.District)]
        public ActionResult CreateDistrict([FromBody] CreateDistrictDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.DataNotValid,
                    ErrorMessage = StringMessage.ErrorMessages.DataNotValid
                });
            }

            var entity = _mapper.Map<District>(model);
            entity.CreatedDate = DateTime.Now;
            entity.CreatedBy = "Administrator";
            entity.ModifiedBy = "Administrator";
            entity.ModifiedDate = DateTime.Now;
            var isCreated = _districtService.Create(entity);
            if (!isCreated)
                return BadRequest(new ResponseErrorData
                {
                    ErrorMessage = StringMessage.ErrorMessages.ErrorProcess,
                    ErrorType = ErrorTypeConstant.ErrorProcess
                });
            CreateLogHistory(ActionEnum.CREATE.GetHashCode(), "Create District Successfull");
            return Ok(new ResponseData
            {
                Content = new
                {
                    Status = true
                }
            });
        }

        [HttpPost]
        [ActionName("UpdateDistrict")]
        [RequiresPermission(RoleHelper.Action.Update, RoleHelper.Screen.District)]
        public ActionResult UpdateDistrict([FromBody] UpdateDistrictDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.DataNotValid,
                    ErrorMessage = StringMessage.ErrorMessages.DataNotValid
                });
            }

            var entityExits = _districtService.GetById(model.Id);

            var entity = MapModelToEntity(model, entityExits);
            entity.ModifiedBy = "Administrator";
            entity.ModifiedDate = DateTime.Now;
            var isUpdate = _districtService.Update(entity);

            if (!isUpdate)
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.UnableHandleException,
                    ErrorMessage = StringMessage.ErrorMessages.ErrorProcess
                });
            CreateLogHistory(ActionEnum.UPDATE.GetHashCode(), $"Update District {model.Id} Successfull");
            return Ok(new ResponseData
            {
                Content = new
                {
                    Status = true
                }
            });
        }

        [HttpPost]
        [ActionName("DeleteDistrict")]
        [RequiresPermission(RoleHelper.Action.Delete, RoleHelper.Screen.District)]
        public ActionResult DeleteDistrict(DeleteDistrictDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.DataNotValid,
                    ErrorMessage = StringMessage.ErrorMessages.DataNotValid
                });
            }

            var isDelete = _districtService.Delete(model.Id);

            if (!isDelete)
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.DistrictIsUsed,
                    ErrorMessage = StringMessage.ErrorMessages.DistrictIsUsed
                });
            }
            CreateLogHistory(ActionEnum.DELETE.GetHashCode(), $"Delete District {model.Id} Successfull");
            return Ok(new ResponseData
            {
                Content = new
                {
                    Status = true
                }
            });
            
        }

        [HttpGet]
        [ActionName("GetListCommune")]
        [RequiresPermission(RoleHelper.Action.View, RoleHelper.Screen.Commune)]
        public ActionResult GetListCommune(FilterCommuneDto filter)
        {
            var data = _communeService.List(filter);
            //CreateLogHistory(ActionEnum.VIEW.GetHashCode(), "GetListCommune");
            return Ok(new ResponseData
            {
                Content = data
            });
        }
        [HttpGet]
        [ActionName("GetLookupCommune")]
        [AllowAnonymous]
        public ActionResult GetLookupCommune(int districtId)
        {
            if (districtId == 0) return null;

            var data = _communeService.GetLookupCommune(districtId);
            //CreateLogHistory(ActionEnum.VIEW.GetHashCode(), "GetLookupCommune");
            return Ok(new ResponseData
            {
                Content = data
            });
        }
        [HttpGet]
        [ActionName("GetLookupCommuneMultiDistrict")]
        [AllowAnonymous]
        public ActionResult GetLookupCommuneMultiDistrict(ICollection<int> districtIds)
        {
            if (districtIds == null || districtIds.Count <= 0)
                return Ok(new ResponseData
                {
                    Content = new List<CommuneLookupDto>()
                });

            var data = _communeService.GetLookupCommune(districtIds);
            return Ok(new ResponseData
            {
                Content = data
            });
        }

        [HttpGet]
        [ActionName("GetDetailCommune")]
        public ActionResult GetDetailCommune(int id)
        {
            var data = _communeService.GetCommuneById(id);
            //CreateLogHistory(ActionEnum.VIEW.GetHashCode(), "GetDetailCommune");
            return Ok(new ResponseData
            {
                Content = data
            });
        }

        [HttpPost]
        [ActionName("CreateCommune")]
        [RequiresPermission(RoleHelper.Action.Create, RoleHelper.Screen.Commune)]
        public ActionResult CreateCommune([FromBody] CreateCommuneDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.DataNotValid,
                    ErrorMessage = StringMessage.ErrorMessages.DataNotValid
                });
            }

            var entity = _mapper.Map<Commune>(model);
            entity.CreatedDate = DateTime.Now;
            entity.CreatedBy = "Administrator";
            entity.ModifiedBy = "Administrator";
            entity.ModifiedDate = DateTime.Now;
            var isCreated = _communeService.Create(entity);
            if (!isCreated)
                return BadRequest(new ResponseErrorData
                {
                    ErrorMessage = StringMessage.ErrorMessages.ErrorProcess,
                    ErrorType = ErrorTypeConstant.ErrorProcess
                });
            CreateLogHistory(ActionEnum.CREATE.GetHashCode(), "Create Commune Successfull");
            return Ok(new ResponseData
            {
                Content = new
                {
                    Status = true
                }
            });
        }
        [HttpPost]
        [ActionName("UpdateCommune")]
        [RequiresPermission(RoleHelper.Action.Update, RoleHelper.Screen.Commune)]
        public ActionResult UpdateCommune([FromBody] UpdateCommuneDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.DataNotValid,
                    ErrorMessage = StringMessage.ErrorMessages.DataNotValid
                });
            }

            var entityExits = _communeService.GetById(model.Id);

            var entity = MapModelToEntity(model, entityExits);
            entity.ModifiedBy = "Administrator";
            entity.ModifiedDate = DateTime.Now;
            var isUpdate = _communeService.Update(entity);

            if (!isUpdate)
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.UnableHandleException,
                    ErrorMessage = StringMessage.ErrorMessages.ErrorProcess
                });
            CreateLogHistory(ActionEnum.UPDATE.GetHashCode(), $"Update Commune {model.Id} Successfull");
            return Ok(new ResponseData
            {
                Content = new
                {
                    Status = true
                }
            });
        }

        [HttpPost]
        [ActionName("DeleteCommune")]
        [RequiresPermission(RoleHelper.Action.Delete, RoleHelper.Screen.Commune)]
        public ActionResult DeleteCommune(DeleteCommuneDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.DataNotValid,
                    ErrorMessage = StringMessage.ErrorMessages.DataNotValid
                });
            }

            var isDelete = _communeService.Delete(model.Id);

            if (!isDelete)
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.UnableHandleException,
                    ErrorMessage = StringMessage.ErrorMessages.ErrorProcess
                });
            CreateLogHistory(ActionEnum.DELETE.GetHashCode(), $"Delete Commune {model.Id} Successfull");
            return Ok(new ResponseData
            {
                Content = new
                {
                    Status = true
                }
            });
        }

        #region Private
        private static Province MapModelToEntity(UpdateProvinceDto model, Province entity)
        {
            entity.Id = model.Id;
            entity.Name = model.Name;
            entity.AdministrativeUnitCode = model.AdministrativeUnitCode;
            entity.Longitude = model.Longitude;
            entity.Latitude = model.Latitude;
            entity.OrderNumber = model.OrderNumber;
            return entity;
        }
       
        private static District MapModelToEntity(UpdateDistrictDto model, District entity)
        {
            entity.Id = model.Id;
            entity.Name = model.Name;
            entity.AdministrativeUnitCode = model.AdministrativeUnitCode;
            entity.Longitude = model.Longitude;
            entity.Latitude = model.Latitude;
            entity.ProvinceId = model.ProvinceId;
            return entity;
        }

        private static Commune MapModelToEntity(UpdateCommuneDto model, Commune entity)
        {
            entity.Id = model.Id;
            entity.Name = model.Name;
            entity.AdministrativeUnitCode = model.AdministrativeUnitCode;
            entity.Longitude = model.Longitude;
            entity.Latitude = model.Latitude;
            entity.DistrictId = model.DistrictId;
            return entity;
        }
        #endregion
        //private void CreateLogHistory(int action, string description)
        //{
        //    try
        //    {
        //        CurrentUserModel currentUserModel = _workerService.GetCurrentUser();
        //        LogHistoryModel logHistoryModel = new LogHistoryModel
        //        {
        //            Action = action,
        //            Description = description,
        //            UserName = currentUserModel.FullName
        //        };
        //        _logHistoryService.Create(logHistoryModel, currentUserModel);
        //    }
        //    catch (Exception e)
        //    {
        //    }
        //}
    }
}
