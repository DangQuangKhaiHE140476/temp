using AutoMapper;
using DATVANG.ApiGateway.Middlewares;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Npgsql.EntityFrameworkCore.PostgreSQL.Infrastructure;
using QLHSC07.ApiGateway.Attribute;
using QLHSC07.ApiGateway.Configuration;
using QLHSC07.ApiGateway.Service;
using QLHSC07.ApiGateway.Service.Worker;
using QLHSC07.Authentication.Configuration;
using QLHSC07.CORE.FileService;
using QLHSC07.CORE.SendMailService;
using QLHSC07.CORE.Settings;
using QLHSC07.Data.Repository;
using QLHSC07.Entity.IdentityAccess;
using QLHSC07.Services.Models;
using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace QLHSC07.ApiGateway
{
    public class Startup
    {
        private const string PPREFIX_URL = "qlhs";
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(option =>
            {
                var builder = new NpgsqlDbContextOptionsBuilder(option);
                builder.SetPostgresVersion(9, 6);
                option.UseNpgsql(Configuration.GetConnectionString("MyWebApiConection"),
                    o => o.UseNetTopologySuite());
            });
            services.AddControllers();

            // dependency
            ConfigurationDependency.Configuration(services);
            var authenticationSections = Configuration.GetSection("AuthenticationSettings");
            services.Configure<AuthenticationSettings>(authenticationSections);
            var authenticationSettings = authenticationSections.Get<AuthenticationSettings>();

            // app settings
            var appConfig = Configuration
                .GetSection("AppSettings")
                .Get<AppSettings>();

            //Client Settings
            var clientConfig = Configuration
                .GetSection("ClientSettings")
                .Get<ClientSettings>();

            // RootFile
            var rootFile = Configuration
                .GetSection("RootFile")
                .Get<RootFile>();

            services.AddSingleton(appConfig);
            services.AddSingleton(authenticationSettings);
            services.AddSingleton(clientConfig);
            services.AddSingleton(rootFile);
            //mail
            var emailConfig = Configuration
                .GetSection("EmailConfiguration")
                .Get<EmailConfiguration>();
            services.AddSingleton(emailConfig);
            services.AddScoped<ISendMailService, SendMailService>();
            services.AddScoped<IFileService, FileService>();
            services.AddScoped<IWorkerService, WorkerService>();
            services.AddAutoMapper(typeof(AutoMapperProfile));
            services.AddScoped<Mapper>();
            services.AddHttpContextAccessor();

            var key = Encoding.ASCII.GetBytes(authenticationSettings.Secret);
            services.AddCors(opt => opt.AddPolicy("CorsPolicy",
                builder =>
                {
                    builder
                         .AllowAnyHeader()
                         .AllowAnyMethod()
                         .AllowCredentials()
                         .WithOrigins(authenticationSettings.AllowedAuthOrigins);
                }));

            services.AddIdentity<User, Role>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequiredLength = appConfig.MinimumRequiredLength;
                options.SignIn.RequireConfirmedEmail = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredUniqueChars = 1;
                options.Password.RequireNonAlphanumeric = false;

            }).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(x =>
                {
                    x.RequireHttpsMetadata = false;
                    x.SaveToken = true;
                    x.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(key),
                        ValidateIssuer = false,
                        ValidateAudience = false,
                        ValidateLifetime = true,
                        RequireExpirationTime = false,
                        ClockSkew = TimeSpan.FromMinutes(appConfig.AccessTokenExpireTimeSpan),
                    };
                });
            services.Configure<PasswordHasherOptions>(options =>
                options.CompatibilityMode = PasswordHasherCompatibilityMode.IdentityV2
            );
            services.Configure<IISServerOptions>(options =>
            {
                options.MaxRequestBodySize = 1073741824; 
            });
            //test
            services.Configure<KestrelServerOptions>(options =>
            {
                options.Limits.MaxRequestBodySize = 1073741824;
            });
            services.Configure<FormOptions>(x =>
            {
                x.ValueLengthLimit = 1073741824;
                x.MultipartBodyLengthLimit = 1073741824;
                x.MultipartHeadersLengthLimit = 104857600;
            });
            //end test
            //services.Configure<FormOptions>(opt =>
            //{
            //    opt.MultipartBodyLengthLimit = YOUR_MAX_TOTAL_UPLOAD_SIZE;
            //});
            services.AddScoped<AuthService>();
            // Register the Swagger generator, defining 1 or more Swagger documents

            string v = string.IsNullOrEmpty(ThisAssembly.Git.Tag)
                    ? Configuration.GetValue("ApiVersion", "")
                    : ThisAssembly.Git.Tag;
            if (Configuration.GetValue("Swagger:Enabled", false))
            {
                services.AddSwaggerGen(c =>
                {
                    c.SwaggerDoc("v1", new OpenApiInfo
                    {
                        Title = "QLHSC07",
                        Version = v + " - " + ThisAssembly.Git.Commit
                    });
                    // Swagger 2.+ support
                    var security = new Dictionary<string, IEnumerable<string>> {
                        { "Bearer", new string[0] },
                    };

                    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                    {
                        Description = "JWT Authorization header using the Bearer scheme. Example: \"Authorization: Bearer {token}\"",
                        Name = "Authorization",
                        In = ParameterLocation.Header,
                        Type = SecuritySchemeType.ApiKey
                    });
                    c.AddSecurityRequirement(new OpenApiSecurityRequirement {
                        {
                            new OpenApiSecurityScheme {
                                Reference = new OpenApiReference {
                                    Id = "Bearer", // The name of the previously defined security scheme.
                                    Type = ReferenceType.SecurityScheme
                                },
                            },
                            new string[0]
                        }
                    });
                    // Set the comments path for the Swagger JSON and UI.
                });
            }

            services.AddLogging((builder) =>
            {
                builder.AddSerilog(dispose: true);
            });
            services.AddScoped<RecordPermissionAttribute>();

            services
                .AddControllers()
                .AddJsonOptions(options =>
                {
                    //options.JsonSerializerOptions.IgnoreNullValues = true;
                })
                .AddNewtonsoftJson(options =>
                {
                    //options.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
                });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, AppDbContext appDbContext, IServiceProvider serviceProvider)
        {
            // migrate any database changes on startup (includes initial db creation)
            appDbContext.Database.Migrate();

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseCors("CorsPolicy");
            // Enable middleware to serve generated Swagger as a JSON endpoint.
            if (Configuration.GetValue("Swagger:Enabled", false))
            {
                app.UseSwagger(o =>
                {
                    o.RouteTemplate = PPREFIX_URL + "/swagger/{documentName}/swagger.json";
                }).UseSwaggerUI(c =>
                {
                    c.RoutePrefix = PPREFIX_URL + "/swagger/" + Configuration.GetValue("ApiVersion", "");
                    c.SwaggerEndpoint($"/{PPREFIX_URL}/swagger/v1/swagger.json", "QLHS Authentication");
                });
            }

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            if (!Directory.Exists(Directory.GetCurrentDirectory() + "/Uploads"))
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "/Uploads");
            }
            app.UseStaticFiles(new StaticFileOptions()
            {

                FileProvider = new PhysicalFileProvider(
                    Path.Combine(Directory.GetCurrentDirectory(), @"Uploads")),
                RequestPath = new PathString("/Uploads")
            });

            //Add middlewares
            app.AddMiddlewares(Configuration);
        }
    }
}
