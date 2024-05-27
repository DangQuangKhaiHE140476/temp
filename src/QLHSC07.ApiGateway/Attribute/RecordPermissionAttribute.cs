using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using QLHSC07.Authentication.Configuration;
using QLHSC07.CORE.Helper;
using QLHSC07.CORE.Settings;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace QLHSC07.ApiGateway.Attribute
{
    public class RecordPermissionAttribute : ActionFilterAttribute
    {
        private readonly ILogger<RecordPermissionAttribute> _logger;
        private readonly AuthenticationSettings _authenticationSettings;

        public RecordPermissionAttribute(ILogger<RecordPermissionAttribute> logger,
            AuthenticationSettings authenticationSettings)
        {
            _logger = logger;
            _authenticationSettings = authenticationSettings;
        }

        public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (!HasAllowAnonymous(context))
            {
                var tokenHeader = context.HttpContext.GetCurrentToken();

                if ( string.IsNullOrEmpty(tokenHeader))
                {
                    context.Result = new UnauthorizedResult();
                }
                else
                {
                    AuthenticationHeaderValue.TryParse(tokenHeader, out var headerValue);
                    var token = headerValue.Parameter;
                    var validationParameters = new TokenValidationParameters()
                    {
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_authenticationSettings.Secret)),
                        ValidateIssuerSigningKey = true,
                        ValidateIssuer = false,
                        ValidateAudience = false,
                    };

                    var tokenHandler = new JwtSecurityTokenHandler();
                    try
                    {
                        tokenHandler.ValidateToken(token, validationParameters, out var securityToken);
                        var jwtSecurityToken = (JwtSecurityToken)securityToken;

                        var permission = jwtSecurityToken.Claims?.SingleOrDefault(x => x.Type == Constant.ActiveAccount.RecordPermission)?.Value;
                        var pc07Id = jwtSecurityToken.Claims?.SingleOrDefault(x => x.Type == Constant.ActiveAccount.Pc07LocalId)?.Value;
                        var isFilter = context.ActionArguments.TryGetValue("filter", out var record);
                        if (isFilter && Constant.SeeOnlyMineRecord.Equals(permission, StringComparison.OrdinalIgnoreCase) && !string.IsNullOrEmpty(pc07Id))
                        {
                            record.SetPropertyValue("PC07ManageId", long.TryParse(pc07Id, out var id) ? id : 0);
                        }
                        else if (Constant.SeeAllRecord.Equals(permission, StringComparison.OrdinalIgnoreCase))
                        {
                            record.SetPropertyValue("PC07ManageId", null);
                        }
                        else
                        {
                            context.Result = new ForbidResult();
                        }
                        await next();
                    }
                    catch (SecurityTokenExpiredException ex)
                    {
                        _logger.LogError(ex, ex.Message);
                        context.Result = new UnauthorizedResult();
                    }
                    catch (SecurityTokenInvalidLifetimeException ex)
                    {
                        _logger.LogError(ex, ex.Message);
                        context.Result = new UnauthorizedResult();
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError(ex, ex.Message);
                        context.Result = new ForbidResult();
                    }
                }
            }
        }

        private static bool HasAllowAnonymous(ActionExecutingContext context)
        {
            return context.ActionDescriptor.EndpointMetadata.OfType<AllowAnonymousAttribute>().Any();
        }
    }
}
