using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using QLHSC07.CORE.Extensions;
using QLHSC07.Data.Repository;
using QLHSC07.Entity.Administrative;
using QLHSC07.Entity.IdentityAccess;
using QLHSC07.Entity.QLHSC07_Entities;
using QLHSC07.Model.QLHSC07_Dtos.PC07;
using QLHSC07.Services.BaseServices;
using QLHSC07.Services.Interfaces.QLHSC07;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace QLHSC07.Services.Implements.QLHSC07
{
    public class PC07Service : BaseService<long, PC07Local, PC07Dto, PC07Dto, CreatePC07Dto, UpdatePC07Dto, FilterPC07Dto>, IPC07Service
    {
        public PC07Service(IRepository<PC07Local, long> repository, IMapper mapper, ILogger<PC07Service> logger, IUnitOfWork unitOfWork,
            IHttpContextAccessor httpContextAccessor, UserManager<User> userManager) : base(repository, mapper, logger, unitOfWork, httpContextAccessor, userManager)
        { }

        public override async Task<IQueryable<PC07Local>> QueryFilter()
        {
            var query = _repository.GetAll();

            return query;
        }
        public override async Task<IQueryable<PC07Local>> QueryFilter(FilterPC07Dto filter)
        {
            if (!filter.IsDelete.HasValue)
            {
                filter.IsDelete = false;
            }
            
            var query = _repository.GetAll().Include(x=>x.Commune.District).Include(x=>x.Province)
                .WhereIf(filter.IsDelete.HasValue, x => x.IsDelete == filter.IsDelete)
                .WhereIf(!string.IsNullOrEmpty(filter.Address), x => x.Address.ToLower().Contains( filter.Address.ToLower()))
                .WhereIf(!string.IsNullOrEmpty(filter.Name), x => x.Name.ToLower().Contains(filter.Name.ToLower()))
                .WhereIf(!string.IsNullOrEmpty(filter.Phone), x => x.Phone.Contains( filter.Phone))
                .WhereIf(!string.IsNullOrEmpty(filter.Fax), x => x.Fax.Contains( filter.Fax))
                .WhereIf(!string.IsNullOrEmpty(filter.Email), x => x.Email.ToLower().Contains( filter.Email.ToLower()))
                .WhereIf(!string.IsNullOrEmpty(filter.Note), x => x.UnSignName.ToLower().Contains(filter.Note.ToLower()))
                .WhereIf(filter.CommuneId.HasValue, x => x.CommuneId == filter.CommuneId)
                .WhereIf(filter.ProvinceId.HasValue, x => x.ProvinceId == filter.ProvinceId)
                .WhereIf(filter.PC07ManageId.HasValue, x=>x.Id==filter.PC07ManageId)
                .Where(x=>!x.IsDelete);

            var SortBy = filter.Sorting;

            if (!string.IsNullOrEmpty(SortBy))
            {
                var SortOrder = SortBy.Substring(SortBy.IndexOf(" "));
                SortBy = SortBy.Substring(0, SortBy.IndexOf(" ")).Trim();
                switch (SortBy.ToLower())
                {
                    case "communename":
                        SortBy = "Commune.Name " + SortOrder;
                        break;
                    case "provincename":
                        SortBy = "Province.Name " + SortOrder;
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

        public override async Task<PC07Dto> GetById(long id, params Expression<Func<PC07Local, object>>[] includes)
        {
            return await base.GetById(id, x=>x.Province, x=>x.Commune);
        }

        public IList<PC07LookupDto> GetLookupPC07(FilterPC07LookupDto filter)
        {
            return _repository.GetAll()
                .Where(x => !x.IsDelete && (!filter.PC07ManageId.HasValue || x.Id == filter.PC07ManageId))
                .Select(x => new PC07LookupDto
            {
                Name = x.Name,
                Id = x.Id,
            }).ToList();
        }
        public bool UpdateCode()
        {
            var query = _repository.GetAll().ToList();
            List<Province> provinces = new List<Province>
        {
            new Province { UnSignName = "G01.913.307.000", Id = 8 },
            new Province { UnSignName = "G01.897.307.000", Id = 9 },
            new Province { UnSignName = "G01.829.307.000", Id = 10 },
            new Province { UnSignName = "G01.807.306.000", Id = 11 },
            new Province { UnSignName = "G01.923.307.000", Id = 12 },
            new Province { UnSignName = "G01.835.307.000", Id = 13 },
            new Province { UnSignName = "G01.905.307.000", Id = 14 },
            new Province { UnSignName = "G01.869.307.000", Id = 71 },
            new Province { UnSignName = "G01.893.307.000", Id = 16 },
            new Province { UnSignName = "G01.889.307.000", Id = 17 },
            new Province { UnSignName = "G01.877.307.000", Id = 18 },
            new Province { UnSignName = "G01.925.307.000", Id = 19 },
            new Province { UnSignName = "G01.917.307.000", Id = 20 },
            new Province { UnSignName = "G01.805.307.000", Id = 21 },
            new Province { UnSignName = "G01.863.307.000", Id = 6 },
            new Province { UnSignName = "G01.883.307.000", Id = 22 },
            new Province { UnSignName = "G01.885.307.000", Id = 23 },
            new Province { UnSignName = "G01.813.307.000", Id = 24 },
            new Province { UnSignName = "G01.895.307.000", Id = 25 },
            new Province { UnSignName = "G01.911.307.000", Id = 26 },
            new Province { UnSignName = "G01.881.307.000", Id = 27 },
            new Province { UnSignName = "G01.803.307.000", Id = 28 },
            new Province { UnSignName = "G01.845.307.000", Id = 29 },
            new Province { UnSignName = "G01.801.307.000", Id = 5 },
            new Province { UnSignName = "G01.855.307.000", Id = 30 },
            new Province { UnSignName = "G01.837.307.000", Id = 31 },
            new Province { UnSignName = "G01.839.307.000", Id = 32 },
            new Province { UnSignName = "G01.919.307.000", Id = 33 },
            new Province { UnSignName = "G01.899.307.000", Id = 65 },
            new Province { UnSignName = "G01.821.307.000", Id = 34 },
            new Province { UnSignName = "G01.841.307.000", Id = 35 },
            new Province { UnSignName = "G01.873.307.000", Id = 36 },
            new Province { UnSignName = "G01.915.307.000", Id = 37 },
            new Province { UnSignName = "G01.879.307.000", Id = 38 },
            new Province { UnSignName = "G01.815.307.000", Id = 39 },
            new Province { UnSignName = "G01.887.307.000", Id = 40 },
            new Province { UnSignName = "G01.825.307.000", Id = 41 },
            new Province { UnSignName = "G01.811.000.000", Id = 42 },
            new Province { UnSignName = "G01.901.307.000", Id = 43 },
            new Province { UnSignName = "G01.847.307.000", Id = 44 },
            new Province { UnSignName = "G01.853.307.000", Id = 45 },
            new Province { UnSignName = "G01.849.307.000", Id = 46 },
            new Province { UnSignName = "G01.875.307.000", Id = 60 },
            new Province { UnSignName = "G01.831.307.000", Id = 47 },
            new Province { UnSignName = "G01.871.307.000", Id = 48 },
            new Province { UnSignName = "G01.857.307.000", Id = 49 },
            new Province { UnSignName = "G01.865.307.000", Id = 50 },
            new Province { UnSignName = "G01.867.307.000", Id = 51 },
            new Province { UnSignName = "G01.827.307.000", Id = 7 },
            new Province { UnSignName = "G01.859.307.000", Id = 52 },
            new Province { UnSignName = "G01.921.307.000", Id = 53 },
            new Province { UnSignName = "G01.817.307.000", Id = 64 },
            new Province { UnSignName = "G01.891.307.000", Id = 54 },
            new Province { UnSignName = "G01.843.307.000", Id = 55 },
            new Province { UnSignName = "G01.823.307.000", Id = 56 },
            new Province { UnSignName = "G01.851.307.000", Id = 57 },
            new Province { UnSignName = "G01.861.000.000", Id = 58 },
            new Province { UnSignName = "G01.903.307.000", Id = 59 },
            new Province { UnSignName = "G01.907.307.000", Id = 61 },
            new Province { UnSignName = "G01.809.307.000", Id = 62 },
            new Province { UnSignName = "G01.909.307.000", Id = 67 },
            new Province { UnSignName = "G01.833.307.000", Id = 66 },
            new Province { UnSignName = "G01.819.307.000", Id = 63 }
        };
            for (int i = 0; i < query.Count; i++)
            {
                var code = provinces.Where(x => x.Id == query[i].Id).FirstOrDefault();
                if(code !=null )
                    query[i].Note = code.UnSignName;        
            }
            _repository.UpdateMulti(query);
            _unitOfWork.Complete();
            return true;

        }
    }
}

