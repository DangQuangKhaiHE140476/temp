using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using QLHSC07.ApiGateway.Service.ExternalDto;
using QLHSC07.Authentication.Configuration;
using QLHSC07.CORE;
using QLHSC07.CORE.Extensions;
using QLHSC07.CORE.Helper;
using QLHSC07.CORE.Resource;
using QLHSC07.CORE.Settings;
using QLHSC07.Data.Interfaces;
using QLHSC07.Data.Repository;
using QLHSC07.Entity.IdentityAccess;
using QLHSC07.Entity.IdentityExtentions;
using QLHSC07.Entity.IdentityExtentions.IdentityMapping;
using QLHSC07.Entity.QLHSC07_Entities;
using QLHSC07.Infrastructure.Implements;
using QLHSC07.Infrastructure.Interface;
using QLHSC07.Model.IdentityAccess;
using QLHSC07.Model.User;
using QLHSC07.Model.UserLoginLog;
using QLHSC07.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace QLHSC07.ApiGateway.Service
{
    public class AuthService
    {
        private readonly ILogger<AuthService> _logger;
        private readonly AppSettings _appSettings;
        private readonly UserManager<User> _userManager;
        private readonly AuthenticationSettings _authenticationSettings;
        private readonly IUserService _userService;
        private readonly IUserTokenRepository _userTokenRepository;
        private readonly IAspNetRefreshTokensRepository _refreshTokensRepository;
        private readonly IConfiguration _configuration;
        private readonly IUnitOfWork _unitOfWork;
        private readonly JwtSecurityTokenHandler _jwtSecurityTokenHandler;
        private readonly IDocumentUploadService _documentUploadService;
        private readonly IRepository<UserLoginLog, int> _userLoginLog;
        private readonly IRepository<PC07Local, long> _pc07Repository;

        public AuthService(IUserService userService,
            AppSettings appSettings,
            ILogger<AuthService> logger,
            UserManager<User> userManager,
            AuthenticationSettings authenticationSettings,
            IConfiguration configuration,
            IAspNetRefreshTokensRepository refreshTokensRepository,
            IUnitOfWork unitOfWork,
            IDocumentUploadService documentUploadService,
            IUserTokenRepository userTokenRepository,
            IRepository<UserLoginLog, int> userLoginLog,
            IRepository<PC07Local, long> pc07Repository
            )
        {
            if (_jwtSecurityTokenHandler == null)
            {
                _jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            }
            _unitOfWork = unitOfWork;
            _logger = logger;
            _appSettings = appSettings;
            _userManager = userManager;
            _authenticationSettings = authenticationSettings;
            _userService = userService;
            _configuration = configuration;
            _refreshTokensRepository = refreshTokensRepository;
            _userManager = userManager;
            _documentUploadService = documentUploadService;
            _userLoginLog = userLoginLog;
            _userTokenRepository = userTokenRepository;
            _pc07Repository = pc07Repository;
        }

        public async Task<string> Authenticate(string email, bool isUserToken = false)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
            {
                user = await _userManager.FindByNameAsync(email);
            }
            var userRoles = _userService.GetRoleByUserId(user.Id);



            //var userClaim = _userService.GetUserClaimByUserId(user.Id);

            if (!(await _userManager.IsEmailConfirmedAsync(user)))
                return null;

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes(_authenticationSettings.Secret);
            Microsoft.IdentityModel.Logging.IdentityModelEventSource.ShowPII = true;

            var userClaims = await _userManager.GetClaimsAsync(user);
            var expireTime = DateTime.Now.AddMinutes(_appSettings.AccessTokenExpireTimeSpan);
            var avartarImage = (user.DocumentUploadId == 0 || user.DocumentUploadId == null) ? "" : _documentUploadService.GetById((int)user?.DocumentUploadId)?.Path;
            var jwt = new JwtSecurityToken(
                null,
                null,
                GetTokenClaims(user, userRoles ?? string.Empty, avartarImage, expireTime).Union(userClaims),
                expires: expireTime,
                signingCredentials: new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)//Do your magic here
            );
            var accessToken = tokenHandler.WriteToken(jwt);
            ///insert user token for user
            return accessToken;
        }
        private static IEnumerable<Claim> GetTokenClaims(
            User user,
            string role,
            string avatarUrl,
            DateTime? expireTime)
        {
            return new List<Claim>
            {
                new Claim("userId", user.Id ?? string.Empty),
                new Claim("userName", user.UserName ?? string.Empty),
                new Claim("fullName", user.FullName ?? string.Empty),
                new Claim("email", user.Email?? string.Empty),
                new Claim("userRole", role ?? string.Empty),
                new Claim("avatar", avatarUrl ?? string.Empty),
                new Claim("expireTime", expireTime?.ToString()),
                new Claim("telephoneNumber", user?.PhoneNumber ?? string.Empty),
                new Claim("address", user?.Address ?? string.Empty),
            };
        }

        public string GenerateRefreshToken(int size = 32)
        {
            var randomNumber = new byte[size];
            using (var rng = System.Security.Cryptography.RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomNumber);
                return Convert.ToBase64String(randomNumber);
            }
        }

        public async Task InsertRefreshTokens(string UserName, string refreshToken,
           string RemoteIpAddress)
        {
            try
            {
                var refreshTokenOlds = _refreshTokensRepository.GetAll().Where(c => c.UserName == UserName).ToList();
                if (refreshTokenOlds.Any())
                {
                    _refreshTokensRepository.DeleteMulti(refreshTokenOlds);
                }
                
                var token = new AspNetRefreshTokens
                {
                    UserName = UserName,
                    Token = refreshToken,
                    Expires = DateTime.Now.AddDays(Convert.ToInt32(_configuration["AppSettings:RefreshExpireDay"])),
                    RemoteIpAddress = RemoteIpAddress,
                    CreatedDate = DateTime.Now
                };
                _refreshTokensRepository.Insert(token);
                _unitOfWork.Complete();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Đã có lỗi xảy ra trong quá trình DeleteRefreshTokensByUserName");
            }

        }

        public async Task InsertUserToken(string userId,
            string deviceType,
            string accessToken,
            string userType,
            DateTime expiredTime)
        {
            if (string.IsNullOrEmpty(deviceType))
            {
                deviceType = Constant.DeviceDefault;
            }
            var uuId = Guid.NewGuid().ToString();
            if (userType == Constant.UserType.REGISTERUSER)
            {
                ///insert or update UserToken add accesstoken for user
                var userTokenOld = _userTokenRepository.Find(c => c.UserId == userId && c.Name == deviceType);
                if (userTokenOld != null)
                {
                    userTokenOld.Value = accessToken;
                    userTokenOld.ExpiredTime = expiredTime;
                    //userTokenOld.LoginProvider = uuId;
                    _userTokenRepository.Update(userTokenOld);
                }
                else
                {
                    await _userTokenRepository.InsertAsync(new UserTokens
                    {
                        ExpiredTime = expiredTime,
                        LoginProvider = uuId,
                        Name = deviceType,
                        UserId = userId,
                        Value = accessToken
                    });
                }
            }
            else
            {
                await _userTokenRepository.InsertAsync(new UserTokens
                {
                    ExpiredTime = expiredTime,
                    LoginProvider = uuId,
                    Name = deviceType,
                    UserId = userId,
                    Value = accessToken
                });
            }
            await _unitOfWork.CompleteAsync();
        }

        public async Task<ResponseData> ExchangeRefreshToken(ExchangeRefreshTokenRequest message, string device)
        {
            if (string.IsNullOrEmpty(device))
            {
                return new ResponseData
                {
                    Err = ErrorTypeConstant.DeviceInvalid,
                    Content = StringMessage.ErrorMessages.DeviceInvalid,
                };
            }
            var SigningKey = _authenticationSettings.Secret;
            var cp = GetPrincipalFromToken(message.AccessToken, SigningKey);

            // invalid token/signing key was passed and we can't extract user claims
            if (cp != null)
            {
                var userName = cp.Claims?.SingleOrDefault(x => x.Type == Constant.ActiveAccount.UserName)?.Value;
                var currentUser = await _userManager.Users.SingleOrDefaultAsync(r => r.UserName == userName);


                var tokens = GetRefreshTokens(userName);
                var token = tokens?.FirstOrDefault(x => x.Token == message.RefreshToken);
                if (token != null)
                {
                    var accessToken = await Authenticate(currentUser.UserName);
                    var currentToken = _userTokenRepository.Find(c => c.UserId == currentUser.Id && c.Name == device && c.Value == message.AccessToken);
                    if (currentToken != null)
                    {
                        currentToken.Value = accessToken;
                        _userTokenRepository.Update(currentToken);
                    }
                    // generate refresh token
                    var refreshToken = GenerateRefreshToken();

                    DeleteRefreshTokensFromUser(token);

                    await InsertRefreshTokens(currentUser.UserName, refreshToken, "");
                    //get user detail
                    var result = new ResponseData
                    {
                        Content = new
                        {
                            Token = accessToken,
                            ReturnUrl = message.ReturnUrl,
                            RefreshTokens = refreshToken
                        },

                    };
                    return result;
                }
            }
            return null;
        }

        public ClaimsPrincipal GetPrincipalFromToken(string token, string signingKey)
        {
            return ValidateToken(token, new TokenValidationParameters
            {
                ValidateAudience = false,
                ValidateIssuer = false,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(signingKey)),
                ValidateLifetime = false // we check expired tokens here
            });
        }

        public ClaimsPrincipal ValidateToken(string token, TokenValidationParameters tokenValidationParameters)
        {
            try
            {
                var principal = _jwtSecurityTokenHandler.ValidateToken(token, tokenValidationParameters, out var securityToken);
                if (!(securityToken is JwtSecurityToken jwtSecurityToken) || !jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256Signature, StringComparison.InvariantCultureIgnoreCase))
                    throw new SecurityTokenException("Invalid token");

                return principal;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public IList<AspNetRefreshTokens> GetRefreshTokens(string username)
        {
            return _refreshTokensRepository.GetAll().Where(x => x.UserName == username).ToList();
        }

        public void DeleteRefreshTokensFromUser(AspNetRefreshTokens refreshToken)
        {
            _refreshTokensRepository.Delete(refreshToken);
        }


        public async Task DeleteRefreshTokens(string refreshToken)
        {
            var token = _refreshTokensRepository.GetAll().FirstOrDefault(c => c.Token == refreshToken);
            if (token is null)
            {
                _logger.LogWarning("Token {refreshToken} thì không tồn tại trong database.");
                return;
            }
            _refreshTokensRepository.Delete(token);
            await _unitOfWork.CompleteAsync();
        }

        public async Task DeleteRefreshTokensByUserName(string userName, string device)
        {
            using var trans = _unitOfWork.BeginTransaction();
            try
            {
                var refreshToken = _refreshTokensRepository.GetAll().Where(c => c.UserName == userName).ToList();
                if (refreshToken is null)
                {
                    _logger.LogWarning("Token {refreshToken} thì không tồn tại trong database.");
                    return;
                }
                var accessToken = _userTokenRepository.Find(c => c.UserId == userName && c.Name == device);
                _userTokenRepository.Delete(accessToken);
                _refreshTokensRepository.DeleteMulti(refreshToken);
                await _unitOfWork.CompleteAsync();
                await trans.CommitAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Đã có lỗi xảy ra trong quá trình DeleteRefreshTokensByUserName");
                await trans.RollbackAsync();
            }
            
        }
        
        public async Task LogOut(CurrentUserDto user, string device, string token, string refreshTokenPr)
        {
            using var trans = _unitOfWork.BeginTransaction();
            try
            {
                var refreshToken = _refreshTokensRepository.Find(c => c.UserName == user.UserName && c.Token == refreshTokenPr);
                
                if (refreshToken is null) _logger.LogWarning($"Token {refreshTokenPr} thì không tồn tại trong database.");
                else _refreshTokensRepository.Delete(refreshToken);
                
                var accessToken = _userTokenRepository.Find(c => c.UserId == user.Id && c.Name == device && c.Value == token);
                if (accessToken != null)
                {
                    _userTokenRepository.Delete(accessToken);
                }
                await _unitOfWork.CompleteAsync();
                await trans.CommitAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Đã có lỗi xảy ra trong quá trình DeleteRefreshTokensByUserName");
                await trans.RollbackAsync();
            }
            
        }

        public async Task InsertUserLoginLog(UserApiLogRequest apiLog)
        {
            await _userLoginLog.InsertAsync(new UserLoginLog()
            {
                ApiName = apiLog.ApiName,
                UserId = apiLog.UserId,
                CreatedDate = DateTime.Now,
                IpAddress = apiLog.IpAddress,
                CreatedBy = apiLog.UserName,
                FullName = apiLog.FullName
            });
        }

        public async Task<IPagedList<UserApiLogRequest>> GetLogUserLogin(FilterLoginLog filter, string userId)
        {
            if (filter.PageIndex == 0) filter.PageIndex = Constant.DefaultPageIndex;
            if (filter.PageSize == 0) filter.PageSize = Constant.DefaultPageSize;
            var result = _userLoginLog.GetAll()
                        .Where( c => c.UserId == userId)
                        .Select(c => new UserApiLogRequest()
                        {
                            Id = c.Id,
                            ApiName = c.ApiName,
                            UserId = c.UserId,
                            FullName = c.FullName,
                            IpAddress = c.IpAddress,
                            UserName = c.CreatedBy,
                            CreateDate = c.CreatedDate.ToString()
                        });

            if (!string.IsNullOrEmpty(filter.Sorting))
            {
                result = result.Sort(filter.Sorting);
            }
            else
            {
                result = result.OrderByDescending(x => x.CreateDate);
            }
            return result.ToPagedList(filter.PageIndex, filter.PageSize);
        }

        //public async Task DeleteLogLogin(string userId)
        //{
        //    try
        //    {
        //        var getLogToDelete = _userLoginLog.GetAll()
        //                         .Where(c => c.UserId == userId).ToList()
        //                         .Where(c => DateTime.Now.Subtract(c.CreatedDate).TotalDays >= _appSettings.DateToDeleteLog).ToList();
        //        if (!getLogToDelete.Any()) return;
        //        _userLoginLog.DeleteMulti(getLogToDelete);
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex, "Đã có lỗi xảy ra trong quá trình xóa log và access token");
        //    }
        //}
        
      
    }
}
