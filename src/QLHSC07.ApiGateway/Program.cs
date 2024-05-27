using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Serilog;

namespace QLHSC07.ApiGateway
{
    public class Program
    {

        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseSerilog((hostingContext, loggerConfiguration) =>
                    loggerConfiguration.ReadFrom.Configuration(hostingContext.Configuration)
                        .MinimumLevel.Error()
                        .MinimumLevel.Information()
                        .Enrich.FromLogContext()
                        .WriteTo.Console()
                        .WriteTo.File("Logs\\log-.txt", rollingInterval: RollingInterval.Day)
                )
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseWebRoot("wwwroot");
                    webBuilder
                        .UseStartup<Startup>();
                });
    }
}
