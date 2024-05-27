using System;
using System.Collections.Generic;
using AutoMapper;
using System.Linq;
using Microsoft.Extensions.Logging;
using QLHSC07.Services.Interfaces;
using QLHSC07.Data.Interfaces;
using QLHSC07.Data.Repository;
using QLHSC07.Infrastructure.Interface;
using QLHSC07.Model.Province;
using QLHSC07.CORE.Helper;
using QLHSC07.CORE.Extensions;
using QLHSC07.Infrastructure.Implements;
using QLHSC07.Entity.Administrative;

namespace QLHSC07.Services.Implements
{
    public class ProvinceService : IProvinceService
    {
        private readonly IProvinceRepository _provinceRepository;
        private readonly IDistrictRepository _districtRepository;
        private readonly ICommuneRepository _communeRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<ProvinceService> _logger;
        public ProvinceService(ILogger<ProvinceService> logger, IProvinceRepository consultCommunityRepository, IMapper mapper, IUnitOfWork unitOfWork, IDistrictRepository districtRepository, ICommuneRepository communeRepository)
        {
            _provinceRepository = consultCommunityRepository;
            _communeRepository = communeRepository;
            _districtRepository = districtRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public IPagedList<ProvinceViewDto> List(FilterProvince filter)
        {
            try
            {
                filter.Name = filter.Name?.Trim();
                if (filter.PageIndex == 0) filter.PageIndex = Constant.DefaultPageIndex;
                if (filter.PageSize == 0) filter.PageSize = Constant.DefaultPageSize;
                var filterParams = MapParams(filter.Name);
                var consultCommunities = _provinceRepository.GetAll()
                                        .WhereIf(filter.IsDelete.HasValue, c => c.IsDelete == filter.IsDelete)
                                        .WhereIf(filter.OrderNumber.HasValue, c => c.OrderNumber == filter.OrderNumber);
                return consultCommunities?
                    .AsEnumerable()
                    .Select(x => _mapper.Map<ProvinceViewDto>(x)).FilteredData(filterParams)
                    .AsQueryable()
                    .Sort(string.IsNullOrWhiteSpace(filter.SortExpression) ? "DefaultProvince?0:1" : filter.SortExpression)
                    .ToPagedList(filter.PageIndex, filter.PageSize);

            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);
                throw;
            }
        }

        public ProvinceViewDto GetProvinceById(int id)
        {
            var data = _provinceRepository.Query(x => x.Id == id)
                .FirstOrDefault();
            return _mapper.Map<ProvinceViewDto>(data);
        }

        public Province GetById(int id)
        {
            return _provinceRepository.Query(x => x.Id == id)
                .FirstOrDefault();
        }

        public bool Create(Province model)
        {
            using var dbTransaction = _unitOfWork.BeginTransaction();
            try
            {
                var province = _mapper.Map<Province>(model);
                _provinceRepository.Insert(province);
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

        public bool Update(Province model)
        {
            using var dbTransaction = _unitOfWork.BeginTransaction();
            try
            {
                _provinceRepository.Update(model);
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

        public string Delete(DeleteProvinceDto model)
        {
            using (var dbTransaction = _unitOfWork.BeginTransaction())
            {
                try
                {
                    var districts = _districtRepository.Query(x => x.ProvinceId == model.ProvinceId).ToList();
                    foreach (var district in districts)
                    {
                        var communes = _communeRepository.Query(x => x.DistrictId == district.Id).ToList();
                        _communeRepository.DeleteMulti(communes);
                    }
                    _districtRepository.DeleteMulti(districts);
                    var province = _provinceRepository.Find(x => x.Id == model.ProvinceId);
                    _provinceRepository.Delete(province);
                    _unitOfWork.Complete();
                    dbTransaction.Commit();
                    return "OK";
                }
                catch (Exception e)
                {
                    dbTransaction.Rollback();
                    _logger.LogError(e, e.Message);
                    return "False";
                }
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

        public IList<ProvinceLookupDto> GetLookupProvince()
        {
            return _provinceRepository.GetAll().Select(x => new ProvinceLookupDto
            {
                Name = x.Name,
                Id = x.Id,
            }).ToList();
        }
        
        public Dictionary<string, ProvinceWithFirstCommuneAndDistrict> GetProvinceWithFirstCommuneAndDistrict(List<string> filter)
        {
            var unsignFilter = filter.Select(c => UtilHelper.ConvertToUnSign(c.Trim()));
            var query = ((from prov in _provinceRepository.GetAll()
                         join dist in _districtRepository.GetAll()
                             on prov.Id equals dist.ProvinceId into lfdis
                             from lfDis in lfdis.DefaultIfEmpty()
                         join comm in _communeRepository.GetAll()
                             on lfDis.Id equals comm.DistrictId into lfcomm
                             from lfComm in lfcomm.DefaultIfEmpty()
                         where unsignFilter.Contains(prov.UnSignName.ToLower())
                         orderby lfDis.Id , lfComm.Id descending
                         select new ProvinceWithFirstCommuneAndDistrict
                         {
                             Id = prov.Id,
                             Name = prov.Name,
                             UsignName = prov.UnSignName.ToLower(),
                             DistrictId = lfDis.Id,
                             CommuneId = lfComm.Id
                         }).ToList())
                         .GroupBy( x => x.UsignName)
                         .ToDictionary(x => x.Key, x => x.FirstOrDefault());
            return query;
        }

    }
}