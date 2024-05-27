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
using QLHSC07.Model.District;
using QLHSC07.CORE.Extensions;
using QLHSC07.Infrastructure.Implements;
using QLHSC07.Entity.Administrative;

namespace QLHSC07.Services.Implements
{
    public class DistrictService : IDistrictService
    {
        private readonly ICommuneRepository _communeRepository;
        private readonly IDistrictRepository _districtRepository;
        private readonly IProvinceRepository _provinceRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<DistrictService> _logger;
        public DistrictService(ILogger<DistrictService> logger, IDistrictRepository consultCommunityRepository, IMapper mapper, IUnitOfWork unitOfWork, 
            ICommuneRepository communeRepository, IProvinceRepository provinceRepository)
        {
            _districtRepository = consultCommunityRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _logger = logger;
            _communeRepository = communeRepository;
            _provinceRepository = provinceRepository;
        }

        public IPagedList<DistrictViewDto> List(int pageIndex, int pageSize, string sortExpression, string title = null)
        {
            try
            {
                var filterParams = MapParams(title);
                var consultCommunities = _districtRepository.GetAll()
                    .Include(x => x.Province);
                return consultCommunities?
                    .AsEnumerable()
                    .Select(x => _mapper.Map<DistrictViewDto>(x)).FilteredData(filterParams)
                    .AsQueryable()
                    .Sort(string.IsNullOrWhiteSpace(sortExpression) ? "CreatedDate desc" : sortExpression)
                    .ToPagedList(pageIndex, pageSize);

            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);
                throw;
            }
        }

        public DistrictViewDto GetDistrictById(int id)
        {
            var data = _districtRepository.Query(x => x.Id == id)
                .Include(u => u.Province)
                .FirstOrDefault();
            return _mapper.Map<DistrictViewDto>(data);
        }

        public District GetById(int id)
        {
            return _districtRepository.Query(x => x.Id == id)
                .Include(u => u.Province)
                .FirstOrDefault();
        }

        public IList<DistrictLookupDto> GetLookupDistrict()
        {
            var provinceDefault = _provinceRepository.Find(x => x.DefaultProvince);
            var district = _districtRepository.Query(x => x.ProvinceId == provinceDefault.Id).AsQueryable();
            return district.Select(x => new DistrictLookupDto
            {
                Name = x.Name,
                Id = x.Id,
            }).ToList();
        }
        public IList<DistrictLookupDto> GetDistrict(int provinceId) //user site
        {
            var district = _districtRepository.Query(x => x.ProvinceId == provinceId).AsQueryable();
            return district.Select(x => new DistrictLookupDto
            {
                Name = x.Name,
                Id = x.Id,
            }).ToList();
        }
        public IList<DistrictLookupDto> GetDistrict(ICollection< int> provinceIds)
        {
            if (provinceIds == null || provinceIds.Count <= 0) return null;
            var district = _districtRepository.Query(x => provinceIds.Contains(x.ProvinceId)).AsQueryable();
            return district.Select(x => new DistrictLookupDto
            {
                Name = x.Name,
                Id = x.Id,
            }).ToList();
        }

        public bool Create(District model)
        {
            using var dbTransaction = _unitOfWork.BeginTransaction();
            try
            {
                var district = _mapper.Map<District>(model);
                _districtRepository.Insert(district);
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

        public bool Update(District model)
        {
            using var dbTransaction = _unitOfWork.BeginTransaction();
            try
            {
                _districtRepository.Update(model);
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
            using var dbTransaction = _unitOfWork.BeginTransaction();
            try
            {
                var communes = _communeRepository.Query(x => x.DistrictId == id).ToList();
                _communeRepository.DeleteMulti(communes);
                var district = _districtRepository.Find(e => e.Id == id);
                _districtRepository.Delete(district);
                _unitOfWork.Complete();
                dbTransaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                dbTransaction.Rollback();
                _logger.LogError(e, e.Message);
                return false;
                //var planningDistrict = _planningDistrictRepository.Query(x => x.DistrictId == id).ToList();
                //var returnString = "Quận/Huyện đang được quy hoạch tại" + Environment.NewLine;
                //foreach (var plan in planningDistrict)
                //{
                //    var plannings = _planningRepository.Find(x => x.Id == plan.PlanningId);
                //    returnString = string.Concat(returnString, plannings.Name + Environment.NewLine);
                //}
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

        public int GetDistrictByName(string name)
        {
            var district = _districtRepository.Query(x => x.UnSignName == name.Trim()).FirstOrDefault();
            if (district == null) return 0;
            return district.Id;
        }

        //private bool DeleteAll(int districtId)
        //{

        //    try
        //    {
        //        var communes = _communeRepository.Query(x => x.DistrictId == districtId).ToList();
        //        _communeRepository.DeleteMulti(communes);
        //        return true;
        //    }
        //    catch (Exception e)
        //    {

        //        _logger.LogError(e, e.Message);
        //        return false;
        //    }

        //}
    }
}