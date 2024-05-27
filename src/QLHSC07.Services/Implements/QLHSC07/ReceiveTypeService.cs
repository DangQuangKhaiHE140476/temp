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
using QLHSC07.Model.QLHSC07_Dtos.ReceiveType;
using QLHSC07.Services.BaseServices;
using QLHSC07.Services.Interfaces.QLHSC07;

namespace QLHSC07.Services.Implements.QLHSC07
{
    public class ReceiveTypeService : BaseService<long, ReceiveType, ReceiveTypeDto, ReceiveTypeDto, CreateReceiveTypeDto, UpdateReceiveTypeDto, FilterReceiveTypeDto>, IReceiveTypeService
    {
        public ReceiveTypeService(IRepository<ReceiveType, long> repository, IMapper mapper, ILogger<ReceiveTypeService> logger, IUnitOfWork unitOfWork,
            IHttpContextAccessor httpContextAccessor, UserManager<User> userManager) : base(repository, mapper, logger, unitOfWork, httpContextAccessor, userManager)
        { }

        public override async Task<IQueryable<ReceiveType>> QueryFilter()
        {
            var query = _repository.GetAll();

            return query;
        }
        public override async Task<IQueryable<ReceiveType>> QueryFilter(FilterReceiveTypeDto filter)
        {
            if (!filter.IsDelete.HasValue)
            {
                filter.IsDelete = false;
            }

            var query = _repository.GetAll()
                .WhereIf(filter.IsDelete.HasValue, x => x.IsDelete == filter.IsDelete)
                .WhereIf(!string.IsNullOrEmpty(filter.Name), x => x.Name.ToLower().Contains( filter.Name.ToLower()))
                .Where(x => !x.IsDelete);

            if (string.IsNullOrEmpty(filter.Sorting))
                filter.Sorting = "ModifiedDate Desc";
            query = query.Sort(filter.Sorting);

            return await Task.FromResult(query);
        }

        public override async Task<ReceiveTypeDto> GetById(long id, params Expression<Func<ReceiveType, object>>[] includes)
        {
            var response = await base.GetById(id);
            return response;
        }

        public IList<ReceiveTypeLookupDto> GetLookupReceiveType()
        {
            return _repository.GetAll().Where(x => !x.IsDelete).Select(x => new ReceiveTypeLookupDto
            {
                Name = x.Name,
                Id = x.Id,
            }).ToList();
        }
    }
}

