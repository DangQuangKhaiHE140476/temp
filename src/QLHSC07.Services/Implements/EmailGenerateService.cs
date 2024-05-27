using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using QLHSC07.CORE.Extensions;
using QLHSC07.CORE.Helper;
using QLHSC07.Data.Interfaces;
using QLHSC07.Data.Repository;
using QLHSC07.Entity;
using QLHSC07.Infrastructure.Implements;
using QLHSC07.Infrastructure.Interface;
using QLHSC07.Model.EmailGenerated;
using QLHSC07.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLHSC07.Services.Implements
{
    public class EmailGenerateService : IEmailGeneratedService
    {
        private readonly IEmailGenerateRepository _emailGenerateRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<EmailTemplateService> _logger;
        private readonly IEmailTemplateService _emailTemplateService;
        public EmailGenerateService(ILogger<EmailTemplateService> logger, IEmailGenerateRepository emailGenerateRepository, IMapper mapper,
            IUnitOfWork unitOfWork, IEmailTemplateService emailTemplateService)
        {
            _emailGenerateRepository = emailGenerateRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _logger = logger;
            _emailTemplateService = emailTemplateService;
        }



        public EmailGeneratedDetailDto GetDetailEmailGenerated(int id)
        {
            var emailGenerate = _emailGenerateRepository.Query(x => x.Id == id)
                .Include(x => x.ReferenceType).FirstOrDefault();
            return _mapper.Map<EmailGeneratedDetailDto>(emailGenerate);
        }

        public DetailEmailContactToAdminDto GetDetailContactAdmin(int id, string authorEmail)
        {
            var emailTemplate = _emailTemplateService.GetEmailTemplateByCode(Constant.EmailTemplate.ReplyContact);
            var emailGenerate = _emailGenerateRepository.Query(x => x.Id == id)
                .Include(x => x.ReferenceType).FirstOrDefault();
            var repContent = _emailGenerateRepository.Query(x => x.Message == id.ToString()).FirstOrDefault();
            if (emailGenerate != null)
            {
                return new DetailEmailContactToAdminDto
                {
                    Message = emailGenerate.Message,
                    Id = emailGenerate.Id,
                    Description = emailGenerate.Description,
                    UserName = emailGenerate.UserName,
                    SentDate = emailGenerate.SentDate,
                    PhoneNumber = emailGenerate.PhoneNumber,
                    SendFrom = emailGenerate.SendFrom,
                    IsReplied = emailGenerate.IsReplied,
                    RepliedContent = emailGenerate.IsReplied == false ? new RepliedMessage
                    {
                        Subject = emailTemplate?.Title,
                        Content = emailTemplate?.Description,
                        SendFrom = authorEmail
                    } : new RepliedMessage
                    {
                        Subject = repContent.Title,
                        Content = repContent.Description,
                        SendFrom = repContent.SendFrom
                    }
                };
            }

            return null;
        }


        public bool Create(CreateEmailGeneratedDto model)
        {
            using var dbTransaction = _unitOfWork.BeginTransaction();
            try
            {
                var emailTemplate = _mapper.Map<EmailGenerated>(model);
                _emailGenerateRepository.Insert(emailTemplate);
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

        public async Task<bool> CreateAsync(CreateEmailGeneratedDto model)
        {
            try
            {
                var emailTemplate = _mapper.Map<EmailGenerated>(model);
                await _emailGenerateRepository.InsertAsync(emailTemplate);
                await _unitOfWork.CompleteAsync();
                return true;
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);
                return false;
            }
        }

        public bool UpdateReplyStatus(long userId)
        {
            using var dbTransaction = _unitOfWork.BeginTransaction();
            try
            {
                var data = _emailGenerateRepository.Find(x => x.Id == userId);
                data.IsReplied = true;
                _emailGenerateRepository.Update(data);
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

        public IPagedList<EmailContactToAdminDto> GetListEmailGeneratedContactToAdmin(int pageIndex, int pageSize, string sortExpression, int type, string sendFrom, string userName)
        {
            var filterParams = MapParams(sendFrom, userName);
            var emailGenerates = _emailGenerateRepository.Query(x => x.ReferenceTypeId == type)
                .Include(x => x.ReferenceType).Where(x => x.Status == 1);
            return emailGenerates.AsEnumerable().Select(x => new EmailContactToAdminDto
            {
                PhoneNumber = x.PhoneNumber,
                Id = x.Id,
                SentDate = x.SentDate,
                UserName = x.UserName,
                SendFrom = x.SendFrom,
                Message = x.Message,
                IsReplied = x.IsReplied
            }).FilteredData(filterParams)
                .AsQueryable().Sort(string.IsNullOrWhiteSpace(sortExpression) ? "SentDate desc" : sortExpression)
                .ToPagedList(pageIndex, pageSize);
        }

        public IPagedList<EmailGeneratedViewDto> GetListEmailGenerated(int pageIndex, int pageSize, string sortExpression, string title)
        {
            var filterParams = MapParamsList(title);
            var emailGenerates = _emailGenerateRepository.GetAll()
                .Include(x => x.ReferenceType);
            return emailGenerates?
                .AsEnumerable().Select(x => _mapper.Map<EmailGeneratedViewDto>(x))
                .FilteredData(filterParams)
                .AsQueryable().Sort(string.IsNullOrWhiteSpace(sortExpression) ? "Title desc" : sortExpression)
                .ToPagedList(pageIndex, pageSize);
        }
        private List<FilterExtensions.FilterParams> MapParams(string sendFrom, string userName)
        {
            var filterParams = new List<FilterExtensions.FilterParams>();
            if (!string.IsNullOrEmpty(sendFrom))
                filterParams.Add(new FilterExtensions.FilterParams()
                {
                    ColumnName = "SendFrom",
                    FilterValue = sendFrom
                });
            if (!string.IsNullOrEmpty(userName))
                filterParams.Add(new FilterExtensions.FilterParams()
                {
                    ColumnName = "UserName",
                    FilterValue = userName
                });
            return filterParams;
        }
        private List<FilterExtensions.FilterParams> MapParamsList(string title)
        {
            var filterParams = new List<FilterExtensions.FilterParams>();
            if (!string.IsNullOrEmpty(title))
                filterParams.Add(new FilterExtensions.FilterParams()
                {
                    ColumnName = "Title",
                    FilterValue = title
                });
            return filterParams;
        }
    }
}

