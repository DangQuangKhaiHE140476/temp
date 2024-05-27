using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using QLHSC07.Authentication.Configuration;
using QLHSC07.Data.Interfaces;

namespace QLHSC07.ApiGateway.Attribute
{
    public class QLHSAuthorizeAttribute : TypeFilterAttribute
    {
        public QLHSAuthorizeAttribute() : base(typeof(AuthorizeRequirementFilter))
        {
        }
    }

    public class AuthorizeRequirementFilter : IAuthorizationFilter
    {
        private readonly AuthenticationSettings _authenticationSettings;
        private readonly IUserTokenRepository _userTokenRepository;
        private readonly ILogger<AuthorizeRequirementFilter> _logger;

        public AuthorizeRequirementFilter(IUserTokenRepository userTokenRepository,
            AuthenticationSettings authenticationSettings, ILogger<AuthorizeRequirementFilter> logger)
        {
            _userTokenRepository = userTokenRepository;
            _authenticationSettings = authenticationSettings;
            _logger = logger;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            
        }
    }
}
