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
using QLHSC07.Model.QLHSC07_Dtos.AttachFileType;
using QLHSC07.Services.BaseServices;
using QLHSC07.Services.Interfaces.QLHSC07;
using System.Linq.Dynamic.Core;

namespace QLHSC07.Services.Implements.QLHSC07
{
    public class AttachFileTypeService : BaseService<long, FileTypeAttachment, AttachFileTypeDto, AttachFileTypeDto, CreateAttachFileTypeDto, UpdateAttachFileTypeDto, FilterAttachFileTypeDto>, IAttachFileTypeService
    {
        private readonly IRepository<RecordsTypeFileType, long> _recordsTypeFileType;

        public AttachFileTypeService(IRepository<FileTypeAttachment, long> repository, IMapper mapper, ILogger<AttachFileTypeService> logger, IUnitOfWork unitOfWork,
            IHttpContextAccessor httpContextAccessor, UserManager<User> userManager, IRepository<RecordsTypeFileType, long> recordsTypeFileType) : base(repository, mapper, logger, unitOfWork, httpContextAccessor, userManager)
        {
            _recordsTypeFileType = recordsTypeFileType;
        }

        public override async Task<IQueryable<FileTypeAttachment>> QueryFilter()
        {
            var query = _repository.GetAll();

            return query;
        }
        public override async Task<IQueryable<FileTypeAttachment>> QueryFilter(FilterAttachFileTypeDto filter)
        {
            var query = _repository.GetAll()
                .Where(c => !c.IsDelete)
                .WhereIf(!string.IsNullOrEmpty(filter.Name), x => x.Name == filter.Name);

            var SortBy = filter.Sorting;

            if (!string.IsNullOrEmpty(SortBy))
            {
                var SortOrder = SortBy.Substring(SortBy.IndexOf(" "));
                SortBy = SortBy.Substring(0, SortBy.IndexOf(" ")).Trim();
                switch (SortBy)
                {
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

        public override async Task<AttachFileTypeDto> GetById(long id, params Expression<Func<FileTypeAttachment, object>>[] includes)
        {
            var response = await base.GetById(id);
            return response;
        }
        public async Task<IList<AttachFileTypeLookupDto>> GetLookupAttachFileType()
        {
            var result = await(from repo in _repository.GetAll()
                               join rety in _recordsTypeFileType.GetAll()
                                  on repo.Id equals rety.RecordsTypeId
                               select new AttachFileTypeLookupDto
                               {
                                   Id = repo.Id,
                                   Name = repo.Name,
                                   IsRequired = rety.IsRequired
                               }).ToListAsync();
            return result;
        }
        
        public async Task<IList<AttachFileTypeLookupDto>> GetLookupByReCordType(long recordsTypeId)
        {
            var result = await (from repo in _repository.GetAll()
                         join rety in _recordsTypeFileType.GetAll().Where(c => c.RecordsTypeId == recordsTypeId)
                            on repo.Id equals rety.FileTypeAttachmentId
                         select new AttachFileTypeLookupDto
                         {
                             Id = repo.Id,
                             Name = repo.Name,
                             IsRequired = rety.IsRequired
                         }).ToListAsync();
            return result;
        }
    }
}

