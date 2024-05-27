using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using QLHSC07.CORE;
using QLHSC07.CORE.Extensions;
using QLHSC07.CORE.Helper;
using QLHSC07.CORE.Resource;
using QLHSC07.Data.Repository;
using QLHSC07.Entity.IdentityAccess;
using QLHSC07.Entity.QLHSC07_Entities;
using QLHSC07.Model.QLHSC07_Dtos.Investors;
using QLHSC07.Model.QLHSC07_Dtos.Projects;
using QLHSC07.Services.BaseServices;
using QLHSC07.Services.Interfaces;
using QLHSC07.Services.Interfaces.QLHSC07;

namespace QLHSC07.Services.Implements.QLHSC07
{
    public class InvestorService : BaseService<long, Investor, InvestorDto, InvestorDto, CreateInvestorDto, UpdateInvestorDto, FilterInvestorDto>, IInvestorService
    {
        private readonly IProvinceService _provinceService;
        private readonly IDistrictService _districtService;
        private readonly ICommuneService _communeService;
        public InvestorService(IRepository<Investor, long> repository, IMapper mapper, ILogger<InvestorService> logger,IUnitOfWork unitOfWork,
            IHttpContextAccessor httpContextAccessor, UserManager<User> userManager, IProvinceService provinceService,
            IDistrictService districtService, ICommuneService communeService) : base(repository, mapper, logger, unitOfWork, httpContextAccessor,userManager)
        {
            _provinceService = provinceService;
            _districtService = districtService;
            _communeService = communeService;
        }

        public override async Task<IQueryable<Investor>> QueryFilter()
        {
            var query = _repository.GetAll()
                .Include(x => x.Province)
                .Include(x => x.District)
                .Include(x => x.Commune);

            return await Task.FromResult(query);
        }
        public override async Task<IQueryable<Investor>> QueryFilter(FilterInvestorDto filter)
        {
            if (!filter.IsDelete.HasValue)
            {
                filter.IsDelete = false;
            }

            var query = _repository.GetAll()
                .Include(x => x.Province)
                .Include(x => x.District)
                .Include(x => x.Commune)
                .WhereIf(filter.IsDelete.HasValue, x => x.IsDelete == filter.IsDelete)
                .WhereIf(filter.CommuneId.HasValue, x => x.CommuneId == filter.CommuneId)
                .WhereIf(filter.DistrictId.HasValue, x => x.Commune.DistrictId == filter.DistrictId)
                .WhereIf(filter.ProvinceId.HasValue, x => x.Commune.District.ProvinceId == filter.ProvinceId)
                .WhereIf(!string.IsNullOrEmpty(filter.Keyword), x => x.Name.ToLower().Contains(filter.Keyword.ToLower()));

            var SortBy = filter.Sorting;

            if (!string.IsNullOrEmpty(SortBy))
            {
                var SortOrder = SortBy.Substring(SortBy.IndexOf(" "));
                SortBy = SortBy.Substring(0, SortBy.IndexOf(" ")).Trim();
                switch (SortBy)
                {
                    case "ProvinceName":
                        SortBy = "Commune.District.Province.Name " + SortOrder; 
                        break;
                    case "DistrictName":
                        SortBy = "Commune.District.Name " + SortOrder;
                        break;
                    case "CommuneName":
                        SortBy = "Commune.Name " + SortOrder;
                        break;
                    case "Name":
                        SortBy = "Name " + SortOrder;
                        break;
                    default:
                        SortBy = filter.Sorting;
                        break;
                }    
            }
            else SortBy = "ModifiedDate Desc";

            if (!string.IsNullOrEmpty(SortBy))
                query = query.Sort(SortBy);
            return await Task.FromResult(query);
        }

        public override async Task<InvestorDto> GetById(long id, params Expression<Func<Investor, object>>[] includes)
        {
            var response = await base.GetById(id, x => x.Commune, x => x.Province, x => x.District);
            return response;
        }
        public IList<InvestorsLookupDto> GetLookupInvestors()
        {
            return _repository.GetAll().Select(x => new InvestorsLookupDto
            {
                Name = x.Name,
                Id = x.Id,
            }).ToList();
        }
        
        public IList<InvestorAndAddressDto> GetInvestorAndAddress()
        {
            return _repository.GetAll().Select(x => new InvestorAndAddressDto
            {
                Name = x.Name,
                Address = x.Address,
                Id = x.Id,
            }).ToList();
        }

        public async Task<ResponseItem<InvestorDto>> CreateReturnInvestor(CreateInvestorDto request)
        {
            try
            {
                if (request == null)
                {
                    return new ResponseItem<InvestorDto>
                    {
                        Result = null,
                        Err = 1,
                        ResponseError = new ResponseErrorData
                        {
                            ErrorMessage = StringMessage.ErrorMessages.RequestInvalid,
                            ErrorType = ErrorTypeConstant.InvalidRequest
                        },
                    };
                }
                var entity = _mapper.Map<Investor>(request);
                var result = await _repository.InsertAsync(entity);

                if (result == null)
                {
                    return new ResponseItem<InvestorDto>
                    {
                        Result = null,
                        Err = 2,
                        ResponseError = new ResponseErrorData
                        {
                            ErrorMessage = StringMessage.ErrorMessages.DataWrong,
                            ErrorType = ErrorTypeConstant.InvalidRequest
                        },
                    };
                }
                await _unitOfWork.CompleteAsync();
                var investorDto = _mapper.Map<Investor, InvestorDto>(result);
                ///mapping name location
                investorDto.ProvinceName = result.ProvinceId.HasValue ? _provinceService.GetById(result.ProvinceId ?? 0)?.Name : "";
                investorDto.CommuneName = result.CommuneId.HasValue ? _communeService.GetById(result.CommuneId ?? 0)?.Name : "";
                investorDto.DistrictName = result.ProvinceId.HasValue ? _districtService.GetById(result.DistrictId ?? 0)?.Name : "";
                _logger.LogInformation($"Tạo mới thành công InvestorId = {result.Id}");

                return new ResponseItem<InvestorDto>
                {
                    Result = investorDto
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(StringMessage.ErrorMessages.ProcessError, ex);
                return new ResponseItem<InvestorDto>
                {
                    Result = null,
                    Err = 1,
                    ResponseError = new ResponseErrorData
                    {
                        ErrorMessage = StringMessage.ErrorMessages.ProcessError,
                        ErrorType = ErrorTypeConstant.InvalidRequest
                    },
                };
            }
        }
    }
}
