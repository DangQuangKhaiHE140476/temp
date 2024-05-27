using Microsoft.Extensions.Logging;
using QLHSC07.CORE.Extensions;
using QLHSC07.Data.Interfaces;
using QLHSC07.Data.Repository;
using QLHSC07.Entity;
using QLHSC07.Infrastructure.Implements;
using QLHSC07.Model.EmailTemplate;
using QLHSC07.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QLHSC07.Services.Implements
{
    public class EmailTemplateService : IEmailTemplateService
    {
        private readonly IEmailTemplateRepository _emailTemplateRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<EmailTemplateService> _logger;
        public EmailTemplateService(ILogger<EmailTemplateService> logger, IUnitOfWork unitOfWork, IEmailTemplateRepository emailTemplateRepository)
        {
            _emailTemplateRepository = emailTemplateRepository;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }


        public EmailTemplatePagedListViewModel List(int pageIndex, int pageSize, string sortExpression, string code, string title)
        {
            var emailTemplates = _emailTemplateRepository.GetListAllAsync();
            var filterParams = BuildParams(code, title);
            var result = emailTemplates.Select(MapEntityToViewModel)
                .FilteredData(filterParams)
                .AsQueryable()
                .Sort(string.IsNullOrWhiteSpace(sortExpression) ? "Title desc" : sortExpression).ToPagedList(pageIndex, pageSize, false);
            return new EmailTemplatePagedListViewModel(result);
        }

        public EmailTemplateViewDto GetEmailTemplateByCode(string code)
        {
            var response = _emailTemplateRepository.Query(x =>
                  x.Code.Equals(code)).FirstOrDefault();
            if (response == null) return null;
            return MapEntityToViewModel(response);
        }

        public bool Create(CreateEmailTemplateDto model)
        {
            using var dbTransaction = _unitOfWork.BeginTransaction();
            try
            {
                var emailTemplate = MapCreateModelToEntity(model);

                emailTemplate.CreatedBy = "Administrator";
                emailTemplate.CreatedDate = DateTime.Now;
                emailTemplate.ModifiedBy = "Administrator";
                emailTemplate.ModifiedDate = DateTime.Now;

                _emailTemplateRepository.Insert(emailTemplate);
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

        public bool Update(UpdateEmailTemplateDto model)
        {
            using var dbTransaction = _unitOfWork.BeginTransaction();
            try
            {
                var emailTemplate = _emailTemplateRepository
                    .Find(x => x.Code.Equals(model.Code));

                MapUpdateModelToEntity(model, emailTemplate);
                emailTemplate.ModifiedBy = "Administrator";
                emailTemplate.ModifiedDate = DateTime.Now;

                _emailTemplateRepository.Update(emailTemplate);
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

        public bool Delete(DeleteEmailTemplateDto model)
        {
            using var dbTransaction = _unitOfWork.BeginTransaction();
            try
            {
                var emailTemplate = _emailTemplateRepository
                    .Find(x => x.Code.Equals(model.Code));

                _emailTemplateRepository.Delete(emailTemplate);
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

        public bool GetByCode(string code)
        {
            return _emailTemplateRepository.Query(x => x.Code.Equals(code)).FirstOrDefault() != null;
        }

        #region mapping
        private static EmailTemplateViewDto MapEntityToViewModel(EmailTemplate e)
        {
            return new EmailTemplateViewDto
            {
                CC = e.CC,
                Code = e.Code,
                CreatedBy = e.CreatedBy,
                CreatedDate = e.CreatedDate,
                Description = e.Description,
                ModifiedBy = e.ModifiedBy,
                ModifiedDate = e.ModifiedDate,
                SendTo = e.SendTo,
                Status = e.Status,
                Title = e.Title
            };
        }

        private static EmailTemplate MapCreateModelToEntity(CreateEmailTemplateDto model)
        {

            return new EmailTemplate
            {
                CC = model.CC,
                Code = model.Code,
                Description = model.Description,
                SendTo = model.SendTo,
                Status = model.Status,
                Title = model.Title
            };
        }
        private static void MapUpdateModelToEntity(UpdateEmailTemplateDto model, EmailTemplate entity)
        {
            entity.CC = model.CC;
            //entity.Code = model.Code;
            entity.Description = model.Description;
            entity.SendTo = model.SendTo;
            entity.Status = model.Status;
            entity.Title = model.Title;
        }
        #endregion
        #region private

        private static List<FilterExtensions.FilterParams> BuildParams(string code, string title)
        {
            var filterParams = new List<FilterExtensions.FilterParams>();
            if (!string.IsNullOrEmpty(title))
                filterParams.Add(new FilterExtensions.FilterParams
                {
                    ColumnName = "Title",
                    FilterValue = title,
                    FilterOption = FilterExtensions.FilterOptions.Contains
                });
            if (!string.IsNullOrEmpty(code))
                filterParams.Add(new FilterExtensions.FilterParams()
                {
                    ColumnName = "Code",
                    FilterValue = code,
                    FilterOption = FilterExtensions.FilterOptions.Contains
                });
            return filterParams;
        }

        #endregion
    }
}
