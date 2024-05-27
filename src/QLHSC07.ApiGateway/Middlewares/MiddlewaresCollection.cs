using Hangfire;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using QLHSC07.ApiGateway.Middlewares;
using System;

namespace DATVANG.ApiGateway.Middlewares
{
    public static class MiddlewaresCollection
    {
        public static IApplicationBuilder AddMiddlewares(this IApplicationBuilder app, IConfiguration configuration)
        {
            app.UseAuthentication();
            app.UseAuthorization();
            // ===== Use ErrorHandling ======
            app.UseMiddleware(typeof(ErrorHandling));
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            // use token parse middleware
            return app;
        }
    }
}
