﻿
using AutoMapper;
using Microsoft.Extensions.Logging;
using QLHSC07.CORE.Extensions;
using QLHSC07.Data.Interfaces;
using QLHSC07.Data.Repository;
using QLHSC07.Entity.IdentityAccess;
using QLHSC07.Infrastructure.Implements;
using QLHSC07.Infrastructure.Interface;
using QLHSC07.Model.Role;
using QLHSC07.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QLHSC07.Services.Implements
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<RoleService> _logger;
        public RoleService(ILogger<RoleService> logger, IRoleRepository roleRepository, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _roleRepository = roleRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public IPagedList<RoleViewDto> List(int pageIndex, int pageSize, string sortExpression, string code, string name)
        {
            var roles = _roleRepository.GetAll();
            var filterParams = BuildParams(code, name);

            return roles?.AsEnumerable().Select(x => _mapper.Map<RoleViewDto>(x))
                .FilteredData(filterParams)
                .AsQueryable()
                .Sort(sortExpression ?? "Code asc")
                .ToPagedList(pageIndex, pageSize);
        }

        public RoleViewDto GetDetail(string id)
        {
            return _roleRepository.Query(x => x.Id == id).Select(x => _mapper.Map<RoleViewDto>(x)).FirstOrDefault();
        }

        public string GetRoleNameById(string id)
        {
            var data = _roleRepository.Find(x => x.Id == id);
            return data != null ? data.Name : null;
        }

        public IList<RoleLookupDto> GetRoleLookup()
        {
            return _roleRepository.GetAll().Select(x => new RoleLookupDto
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();
        }

        public Role GetById(string id)
        {
            return _roleRepository.Query(x => x.Id == id)
                .FirstOrDefault();
        }

        public bool GetByCode(string code)
        {
            return _roleRepository.Query(x => x.Code == code)
                       .FirstOrDefault() != null;
        }

        public bool CreateRole(Role entity)
        {
            var dbTransaction = _unitOfWork.BeginTransaction();
            try
            {
                //var roleCreate = _roleRepository.GetById(entity.Id);
                //roleCreate.Code = entity.Code;
                //roleCreate.Name = entity.Name;
                //roleCreate.CreatedBy = "admin";
                //roleCreate.CreatedDate = DateTime.Now;
                _roleRepository.Insert(entity);
                _unitOfWork.Complete();
                dbTransaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);
                dbTransaction.Rollback();
                return false;
            }
        }

        public bool UpdateRole(Role entity)
        {
            var dbTransaction = _unitOfWork.BeginTransaction();
            try
            {
                //var roleUpdate = _roleRepository.GetById(entity.Id);
                //roleUpdate.Code = entity.Code;
                //roleUpdate.Name = entity.Name;
                //roleUpdate.ModifiedBy = "admin";
                //roleUpdate.ModifiedDate = DateTime.Now;
                _roleRepository.Update(entity);
                _unitOfWork.Complete();
                dbTransaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);
                dbTransaction.Rollback();
                return false;
            }
        }

        public bool RemoveRole(string id)
        {
            var dbTransaction = _unitOfWork.BeginTransaction();
            try
            {
                _roleRepository.Delete(id);
                _unitOfWork.Complete();
                dbTransaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);
                dbTransaction.Rollback();
                return false;
            }
        }

        public bool CheckRoleById(string id, string roleCode)
        {
            return _roleRepository.Find(x => x.Id == id)?.Code == roleCode;
        }
        #region private

        private static List<FilterExtensions.FilterParams> BuildParams(string code, string name)
        {
            var filterParams = new List<FilterExtensions.FilterParams>();
            if (!string.IsNullOrEmpty(code))
                filterParams.Add(new FilterExtensions.FilterParams
                {
                    ColumnName = "Code",
                    FilterValue = code,
                    FilterOption = FilterExtensions.FilterOptions.Contains
                });
            if (!string.IsNullOrEmpty(name))
                filterParams.Add(new FilterExtensions.FilterParams()
                {
                    ColumnName = "Name",
                    FilterValue = name,
                    FilterOption = FilterExtensions.FilterOptions.Contains
                });
            return filterParams;
        }

        #endregion
    }
}
