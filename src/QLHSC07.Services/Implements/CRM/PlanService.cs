using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using QLHSC07.CORE.Extensions;
using QLHSC07.Data.Repository;
using QLHSC07.Entity.CRM;
using QLHSC07.Entity.IdentityAccess;
using QLHSC07.Model.CRM.Plan;
using QLHSC07.Services.BaseServices;
using QLHSC07.Services.Interfaces.CRM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace QLHSC07.Services.Implements.QLHSC07
{
    public class PlanService : BaseService<long, Plan, PlanViewDto, PlanViewDto, CreatePlanDto, UpdatePlanDto, FilterPlanDto>, IPlanService
    {
        public PlanService(IRepository<Plan, long> repository, IMapper mapper, ILogger<PlanService> logger, IUnitOfWork unitOfWork,
            IHttpContextAccessor httpContextAccessor, UserManager<User> userManager) : base(repository, mapper, logger, unitOfWork, httpContextAccessor, userManager)
        { }

        public override async Task<IQueryable<Plan>> QueryFilter()
        {
            var query = _repository.GetAll();

            return query;
        }
        public override async Task<IQueryable<Plan>> QueryFilter(FilterPlanDto filter)
        {
            if (!filter.IsDelete.HasValue)
            {
                filter.IsDelete = false;
            }

            var query = _repository.GetAll()
                .WhereIf(filter.IsDelete.HasValue, x => x.IsDelete == filter.IsDelete)
                .Where(x => !x.IsDelete);

            if (string.IsNullOrEmpty(filter.Sorting))
                filter.Sorting = "ModifiedDate Desc";
            query = query.Sort(filter.Sorting);

            return await Task.FromResult(query);
        }
    }
}

