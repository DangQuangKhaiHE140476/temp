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
using QLHSC07.CORE.Extensions;
using QLHSC07.Data.Repository;
using QLHSC07.Entity.IdentityAccess;
using QLHSC07.Entity.QLHSC07_Entities;
using QLHSC07.Model.QLHSC07_Dtos.Projects;
using QLHSC07.Model.QLHSC07_Dtos.Regency;
using QLHSC07.Services.BaseServices;
using QLHSC07.Services.Interfaces.QLHSC07;

namespace QLHSC07.Services.Implements.QLHSC07
{
    public class RegencyService : BaseService<long, Regency, RegencyDto, RegencyDto, CreateRegencyDto, UpdateRegencyDto, FilterRegencyDto>, IRegencyService
    {
        public RegencyService(IRepository<Regency, long> repository, IMapper mapper, ILogger<RegencyService> logger, IUnitOfWork unitOfWork,
            IHttpContextAccessor httpContextAccessor, UserManager<User> userManager) : base(repository, mapper, logger, unitOfWork, httpContextAccessor, userManager)
        { }

        public override async Task<IQueryable<Regency>> QueryFilter()
        {
            var query = _repository.GetAll();

            return query;
        }
        public override async Task<IQueryable<Regency>> QueryFilter(FilterRegencyDto filter)
        {
            if (!filter.IsDelete.HasValue)
            {
                filter.IsDelete = false;
            }

            var query = _repository.GetAll()
                .WhereIf(filter.IsDelete.HasValue, x => x.IsDelete == filter.IsDelete)
                .WhereIf(!string.IsNullOrEmpty(filter.Name), x => x.Name.ToLower().Contains( filter.Name.ToLower()));

            if (string.IsNullOrEmpty(filter.Sorting))
                filter.Sorting = "ModifiedDate Desc";
            query = query.Sort(filter.Sorting);

            return await Task.FromResult(query);
        }

        public override async Task<RegencyDto> GetById(long id, params Expression<Func<Regency, object>>[] includes)
        {
            var response = await base.GetById(id);
            return response;
        }

        public IList<RegencyLookupDto> GetLookupRegency()
        {
            return _repository.GetAll().Where(x => !x.IsDelete).Select(x => new RegencyLookupDto
            {
                Name = x.Name,
                Id = x.Id,
            }).ToList();
        }
    }
}

