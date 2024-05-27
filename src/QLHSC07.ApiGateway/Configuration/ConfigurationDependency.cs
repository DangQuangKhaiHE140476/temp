using Microsoft.Extensions.DependencyInjection;
using QLHSC07.Data.Implements;
using QLHSC07.Data.Interfaces;
using QLHSC07.Data.Repository;
using QLHSC07.Entity.QLHSC07_MSG_Entities;
using QLHSC07.Services.Helper;
using QLHSC07.Services.Implements;
using QLHSC07.Services.Implements.QLHSC07;
using QLHSC07.Services.Interfaces;
using QLHSC07.Services.Interfaces.CRM;
using QLHSC07.Services.Interfaces.QLHSC07;
using QLHSC07.Services.Models;

namespace QLHSC07.ApiGateway.Configuration
{
    public class ConfigurationDependency
    {
        public static void Configuration(IServiceCollection services)
        {
            #region core
            // unitOfWork
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<RootFile>();
            //email template
            services.AddScoped<IEmailTemplateRepository, EmailTemplateRepository>();
            services.AddScoped<IEmailTemplateService, EmailTemplateService>();

            //email generated
            services.AddScoped<IEmailGenerateRepository, EmailGenerateRepository>();
            services.AddScoped<IEmailGeneratedService, EmailGenerateService>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            // consult community
            services.AddScoped<IFormTemplateRepository, FormTemplateRepository>();
            services.AddScoped<IFormTemplateQuestionRepository, FormTemplateQuestionRepository>();
            services.AddScoped<IFormTemplateAnswerRepository, FormTemplateAnswerRepository>();
            services.AddScoped<IPersonInfoAnswerRepository, PersonInfoAnswerRepository>();
            services.AddScoped<IAnswerExtensionRepository, AnswerExtensionRepository>();

            // role 
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<IRoleService, RoleService>();

            // User
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserRepository, UserRepository>();

            // security matrix
            services.AddScoped<IActionRepository, ActionRepository>();
            services.AddScoped<IScreenRepository, ScreenRepository>();

            services.AddScoped<ISecurityMatrixRepository, SecurityMatrixRepository>();
            services.AddScoped<ISecurityMatrixService, SecurityMatrixService>();
            services.AddScoped<IScreenRepository, ScreenRepository>();
            services.AddScoped<IScreenService, ScreenService>();

            // Administrative
            services.AddScoped<IProvinceRepository, ProvinceRepository>();
            services.AddScoped<IProvinceService, ProvinceService>();
            services.AddScoped<IDistrictRepository, DistrictRepository>();
            services.AddScoped<IDistrictService, DistrictService>();
            services.AddScoped<ICommuneRepository, CommuneRepository>();
            services.AddScoped<ICommuneService, CommuneService>();

            services.AddScoped<IDocumentUploadRepository, DocumentUploadRepository>();

            //document
            services.AddScoped<IDocumentFileRepository, DocumentFileRepository>();

            services.AddScoped<IFileExtensionRepository, FileExtensionRepository>();
            services.AddScoped<IFileExtensionService, FileExtensionService>();

            //log history
            services.AddScoped<ILogHistoryRepository, LogHistoryRepository>();

            services.AddScoped<ILogHistoryService, LogHistoryService>();
            services.AddScoped(typeof(IRepository<,>), typeof(Repository<,>));
            services.AddTransient<IWebHelper, WebHelper>();
            services.AddTransient<IAspNetRefreshTokensRepository, AspNetRefreshTokensRepository>();
            services.AddScoped<IUserTokenRepository, UserTokenRepository>();
            services.AddScoped<IDocumentUploadService, DocumentUploadService>();
            #endregion

            services.AddScoped<IProjectService, ProjectService>();
            services.AddScoped<IMsgExchangeService, MsgExchangeService>();
            services.AddScoped<IAttachFileTypeService, AttachFileTypeService>();
            services.AddScoped<IInvestorService, InvestorService>();
            services.AddScoped<IPC07Service, PC07Service>();
            services.AddScoped<IProjectGroupService, ProjectGroupService>();
            services.AddScoped<IProjectTypeService, ProjectTypeService>();
            services.AddScoped<IProjectStatusService, ProjectStatusService>();
            services.AddScoped<IRankService, RankService>();
            services.AddScoped<IReceiveTypeService, ReceiveTypeService>();
            services.AddScoped<IRecordsService, RecordsService>();
            services.AddScoped<IRecordStatusService, RecordStatusService>();
            services.AddScoped<IRecordTypesService, RecordsTypeService>();
            services.AddScoped<IRegencyService, RegencyService>();
            services.AddScoped<IDocumentAnsTypeService, DocumentAnsTypeService>();
            services.AddScoped<IReportService, ReportService>();
            services.AddScoped<IImportService, ImportService>();

            //services.AddScoped<IBaseService<T, Regency, TEntityDto, TListEntityDto, TCreateDto, TUpdateDto, TFilterDto>, RegencyService>();
            services.AddScoped<IClientNoteService, ClientNoteService>();
            services.AddScoped<IClientService, ClientService>();
            services.AddScoped<IDepositHistoryService, DepositHistoryService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IPlanService, PlanService>();
        }
    }
}
