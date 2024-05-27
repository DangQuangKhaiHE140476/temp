using Microsoft.Extensions.DependencyInjection;
using QLHSC07.Data.Implements;
using QLHSC07.Data.Interfaces;
using QLHSC07.Data.Repository;
using QLHSC07.Services.Implements;
using QLHSC07.Services.Interfaces;

namespace QLHSC07.UnitTest
{
    public class ConfigurationDependency
    {
        public static void Configuration(IServiceCollection services)
        {
            // unitOfWork
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            //email template
            services.AddScoped<IEmailTemplateRepository, EmailTemplateRepository>();

            //email generated
            services.AddScoped<IEmailGenerateRepository, EmailGenerateRepository>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            //role
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IRoleRepository, RoleRepository>();
        }
    }
}
