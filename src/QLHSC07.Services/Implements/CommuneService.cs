using System;
using System.Collections.Generic;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.Extensions.Logging;
using QLHSC07.Services.Interfaces;
using QLHSC07.Data.Interfaces;
using QLHSC07.Data.Repository;
using QLHSC07.Infrastructure.Interface;
using QLHSC07.Model.Commune;
using QLHSC07.CORE.Extensions;
using QLHSC07.Entity.Administrative;
using QLHSC07.Infrastructure.Implements;
using QLHSC07.Services.BaseServices;
using QLHSC07.CORE.Helper;
using System.Threading.Tasks;

namespace QLHSC07.Services.Implements
{
    public class CommuneService : ICommuneService
    {
        private readonly ICommuneRepository _communeRepository;
        private readonly IDistrictRepository _districtRepository;
        private readonly IProvinceRepository _provinceRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CommuneService> _logger;
        private readonly IDistrictService _districtService;
        public CommuneService(ILogger<CommuneService> logger, ICommuneRepository communeRepository, IDistrictRepository districtRepository, 
            IProvinceRepository provinceRepository, IMapper mapper, IUnitOfWork unitOfWork, IDistrictService districtService) 
        {
            _communeRepository = communeRepository;
            _districtRepository = districtRepository;
            _provinceRepository = provinceRepository;
            _districtService = districtService;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public IPagedList<CommuneViewDto> List(FilterCommuneDto filter)
        {
            try
            {
                var filterParams = MapParams(filter.Name);
                if (filter.PageSize == 0) filter.PageSize = Constant.DefaultPageSize;
                if (filter.PageIndex == 0) filter.PageIndex = Constant.DefaultPageIndex;
         
                List<CommuneViewDto> data = new List<CommuneViewDto>();
                var communes = _communeRepository.GetAll()
                    .Include(x => x.District.Province)
                    .WhereIf(filter.DistrictId.HasValue, x => x.DistrictId == filter.DistrictId)
                    .WhereIf(filter.ProvinceId.HasValue, x => x.District.ProvinceId == filter.ProvinceId)
                    .Sort(string.IsNullOrWhiteSpace(filter.Sorting) ? "CreatedDate desc" : filter.Sorting)
                    .ToPagedList(filter.PageIndex, filter.PageSize);
                var reslt = communes.Map<CommuneViewDto, Commune>(_mapper);
                return reslt;
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);
                throw;
            }
        }

        
        public CommuneViewDto GetCommuneById(int id)
        {
            var commune = _communeRepository.Query(x => x.Id == id)
                .Include(u => u.District.Province)
                .FirstOrDefault();
            return _mapper.Map<CommuneViewDto>(commune);
        }
        
        public async Task<IQueryable<Commune>>  GetCommuneByIds(List<int> ids)
        {
            var commune = _communeRepository.Query(x => ids.Contains(x.Id))
                .Include(u => u.District.Province);
            return commune;
        }

        public Commune GetById(int id)
        {
            return  _communeRepository.Query(x => x.Id == id)
                .Include(u => u.District)
                .FirstOrDefault(); 
        }
        
        public int GetCommuneByName(string name)
        {
            var commune =  _communeRepository.Query(x => x.UnSignName == name.Trim()).FirstOrDefault();
            if (commune == null) return 0;
            return commune.Id;
        }
        public IList<CommuneLookupDto> GetLookupCommune(int districtId)
        {
            var data = _communeRepository.Query(x => x.DistrictId == districtId).AsQueryable();
            return data.Select(x => new CommuneLookupDto
            {
                Name = x.Name,
                Id = x.Id,
            }).ToList();
        }

        public IList<CommuneLookupDto> GetLookupCommune(ICollection< int > districtIds)
        {
            if (districtIds == null || districtIds.Count <= 0) return null;
            var data = _communeRepository.Query(x => districtIds.Contains( x.DistrictId)).AsQueryable();
            return data.Select(x => new CommuneLookupDto
            {
                Name = x.Name,
                Id = x.Id,
            }).ToList();
        }

        public bool Create(Commune model)
        {
            using var dbTransaction = _unitOfWork.BeginTransaction();
            try
            {
                var commune = _mapper.Map<Commune>(model);
                _communeRepository.Insert(commune);
                _unitOfWork.Complete();
                dbTransaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                dbTransaction.Rollback();
                _logger.LogError(e, e.Message);
                return false;
            }
        }

        public bool Update(Commune model)
        {
            using var dbTransaction = _unitOfWork.BeginTransaction();
            try
            {
                _communeRepository.Update(model);
                _unitOfWork.Complete();
                dbTransaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                dbTransaction.Rollback();
                _logger.LogError(e, e.Message);
                return false;
            }
        }

        public bool Delete(int id)
        {
            using (var dbTransaction = _unitOfWork.BeginTransaction())
            {
                try
                {
                    var commune = _communeRepository
                        .Find(x => x.Id == id);
                    _communeRepository.Delete(commune);
                    _unitOfWork.Complete();
                    dbTransaction.Commit();
                    return true;
                }
                catch (Exception e)
                {
                    dbTransaction.Rollback();
                    _logger.LogError(e, e.Message);
                    return false;
                }
            }
            
        }

        public bool DeleteAll(int districtId)
        {
            
            try
            {
                var communes = _communeRepository.Query(x => x.DistrictId == districtId).ToList();
                _communeRepository.DeleteMulti(communes);
                return true;
            }
            catch (Exception e)
            {
                    
                _logger.LogError(e, e.Message);
                return false;
            }
            
        }
        private List<FilterExtensions.FilterParams> MapParams(string name)
        {
            var filterParams = new List<FilterExtensions.FilterParams>();
            if (!string.IsNullOrEmpty(name))
                filterParams.Add(new FilterExtensions.FilterParams()
                {
                    ColumnName = "Name",
                    FilterValue = name
                });
            return filterParams;
        }
    }
}