using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using QLHSC07.CORE.Enum;
using QLHSC07.CORE.Extensions;
using QLHSC07.CORE.Helper;
using QLHSC07.CORE.Resource;
using QLHSC07.CORE.SendMailService;
using QLHSC07.CORE.Settings;
using QLHSC07.Data.Interfaces;
using QLHSC07.Data.Repository;
using QLHSC07.Dto.BaseEntity;
using QLHSC07.Entity.IdentityAccess;
using QLHSC07.Entity.IdentityExtentions.IdentityMapping;
using QLHSC07.Entity.QLHSC07_Entities;
using QLHSC07.Infrastructure.Implements;
using QLHSC07.Infrastructure.Interface;
using QLHSC07.Model;
using QLHSC07.Model.EmailGenerated;
using QLHSC07.Model.IdentityAccess;
using QLHSC07.Model.User;
using QLHSC07.Services.Interfaces;
using QLHSC07.Services.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Security.Claims;
using System.Threading.Tasks;

namespace QLHSC07.Services.Implements
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IDocumentUploadService _documentUploadService;
        private readonly IHostingEnvironment _env;
        private readonly ILogger<UserService> _logger;
        private readonly ISendMailService _sendMailService;
        private readonly IEmailTemplateService _emailTemplateService;
        private readonly IEmailGeneratedService _emailGeneratedService;
        private readonly EmailConfiguration _emailConfiguration;
        private readonly AppSettings _appSettings;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<User> _userManager;
        private readonly IRepository<UserLoginLog, int> _userLoginLog;
        private readonly IRepository<PC07Local, long> _pcLocal07Repo;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserTokenRepository _userTokenRepository;
        private readonly IAspNetRefreshTokensRepository _refreshTokensRepository;
        private readonly SignInManager<User> _signInManager;

        public UserService(IUserRepository userRepository, IDocumentUploadService documentUploadService,
            IHostingEnvironment env, ILogger<UserService> logger, ISendMailService sendMailService,
            IEmailTemplateService emailTemplateService, IEmailGeneratedService emailGeneratedService,
            IOptions<EmailConfiguration> emailConfiguration, AppSettings appSettings, IRepository<PC07Local, long> pcLocal07Repo,
            IRepository<UserLoginLog, int> userLoginLog, IUnitOfWork unitOfWork, IUserTokenRepository userTokenRepository,
            IHttpContextAccessor httpContextAccessor, UserManager<User> userManager, SignInManager<User> signInManager,
            IAspNetRefreshTokensRepository refreshTokensRepository)
        {
            _appSettings = appSettings;
            _userRepository = userRepository;
            _documentUploadService = documentUploadService;
            _env = env;
            _logger = logger;
            _sendMailService = sendMailService;
            _emailConfiguration = emailConfiguration.Value;
            _emailTemplateService = emailTemplateService;
            _emailGeneratedService = emailGeneratedService;
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
            _userLoginLog = userLoginLog;
            _unitOfWork = unitOfWork;
            _userTokenRepository = userTokenRepository;
            _refreshTokensRepository = refreshTokensRepository;
            _pcLocal07Repo = pcLocal07Repo;
            _signInManager = signInManager;
        }

        public User GetByUserid(string id)
        {
            return _userRepository
                .Query(x => x.Id == id).Include(x => x.UserRoles)
                .FirstOrDefault();
        }

        public string GetRoleByUserId(string id)
        {
            return _userRepository
                .Query(x => x.Id == id)
                .Include(x => x.UserRoles)
                .ThenInclude(e => e.Role).Select(x => x.UserRoles.Select(e => e.Role.Code).FirstOrDefault())
                .FirstOrDefault();
        }
        
        public string GetUserClaimByUserId(string id)
        {
            var userClaim = _userRepository
                .Query(x => x.Id == id)
                .Include(x => x.UserClaims)
                .Select(x => x.UserClaims.FirstOrDefault( c => c.ClaimType == Constant.RecordPermission))
                .FirstOrDefault();
            if (userClaim == null)
            {
                return string.Empty;
            }
            return userClaim.ClaimValue;
        }

        public IPagedList<UserListViewDto> List(int pageIndex, int pageSize, string sortExpression, string email, string userType, string fullName, long? pc07LocalId)
        {
            if (pageIndex == 0) pageIndex = Constant.DefaultPageIndex;
            if (pageSize == 0) pageSize = Constant.DefaultPageSize;
            try
            {
                var filterParams = BuildParams(email);
                var data = _userRepository.GetAll()
                    .WhereIf(!string.IsNullOrEmpty(email), x => x.Email.Equals(email))
                    .WhereIf(!string.IsNullOrEmpty(fullName), x=>x.FullName.ToLower().Contains(fullName.ToLower()))
                    .Include(x => x.DocumentUpload)
                    .Include(x => x.UserRoles).ThenInclude(e => e.Role)
                    .WhereIf(!string.IsNullOrEmpty(userType), x => x.UserType == userType);

                ///get list userId to join
                var getUserIds = data.Select(c => c.Id).ToList();
                ///get the last time user login in system
                var loginLatest = _userLoginLog.GetAll().Where(c => getUserIds.Contains(c.UserId))
                                                        .Select(c => new { c.UserId, c.CreatedDate }).ToList()
                                                        .GroupBy(c => c.UserId)
                                                        .Select(g => g.OrderByDescending(l => l.CreatedDate).First())
                                                        .ToDictionary(c => c.UserId, c => c.CreatedDate);

                ///get list online, offline for user
                var userStatus = _userTokenRepository.GetAll().Where(c => getUserIds.Contains(c.UserId) && c.ExpiredTime.HasValue)
                                                     .Select(c => new { c.UserId, c.Name, c.ExpiredTime }).ToList()
                                                     .GroupBy(c => c.UserId)
                                                     .Select(g => new { g.Key, Status = string.Join(", ", g.Select(i => $"{i.Name}: {i.ExpiredTime.Value.Subtract(DateTime.Now).TotalSeconds > 0}")) })
                                                     .ToDictionary(c => c.Key, c => c.Status);


                var results = data.Select(e => new UserListViewDto
                {
                    Id = e.Id,
                    Email = e.Email,
                    CreatedDate = e.CreatedDate,
                    Description = e.Description,
                    CreatedBy = e.CreatedBy,
                    ModifiedBy = e.ModifiedBy,
                    Status = e.Status,
                    Address = e.Address,
                    Avatar = e.DocumentUpload != null ? e.DocumentUpload.Path : "",
                    DateOfBirth = e.DateOfBirth,
                    FullName = e.FullName,
                    ModifiedDate = e.ModifiedDate,
                    Sex = e.Sex,
                    RoleName = e.UserRoles.Select(r => r.Role.Name).FirstOrDefault(),
                    PhoneNumber = e.PhoneNumber,
                    UserType = e.UserType,
                    IsUse2FA = e.IsUse2FA,
                })
                   .Sort(sortExpression ?? "CreatedDate desc")
                   .ToPagedList(pageIndex, pageSize);

                if (loginLatest.Any() && userStatus.Any())
                {
                    foreach (var result in results.Items)
                    {
                        //result.DeviceStatus = userStatus.TryGetValue(result.Id, out var deviceStatus) ? deviceStatus.ToString() : "";
                        result.LastDateLogin = loginLatest.TryGetValue(result.Id, out var lastDateLogin) ? lastDateLogin.ToString() : "";
                    }
                }
                return results;
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);
                return null;
            }
        }

        public DetailUserDto GetUserDetail(string id)
        {
            var data = _userRepository
                .Query(x => x.Id == id)
                .Include(x => x.UserRoles).ThenInclude(e => e.Role);
            var docId = data.FirstOrDefault()?.DocumentUploadId;

            ///get the last time user login in system
            var loginLatest = _userLoginLog.GetAll().Where(c => c.UserId == id)
                                                    .OrderByDescending(c => c.CreatedDate)
                                                    .FirstOrDefault()?.CreatedDate;
            ///get list online, offline for user
            var deviceStatus = _userTokenRepository.GetAll().Where(c => c.UserId == id && c.ExpiredTime.HasValue)
                                                 .Select(c => new { c.UserId, c.Name, c.ExpiredTime }).ToList()
                                                 .GroupBy(c => c.UserId)
                                                 .Select(g => new { Status = string.Join(", ", g.Select(i => $"{i.Name}: {i.ExpiredTime.Value.Subtract(DateTime.Now).TotalSeconds > 0}")) }).FirstOrDefault();

            var result = data.ToList().Select(x =>
                    new DetailUserDto
                    {
                        Id = x.Id,
                        RoleId = x.UserRoles.Select(e => e.Role.Id).FirstOrDefault(),
                        Email = x.Email,
                        ModifiedBy = x.ModifiedBy,
                        Description = x.Description,
                        CreatedDate = x.CreatedDate,
                        CreatedBy = x.CreatedBy,
                        Avatar = _documentUploadService.GetFilePathById(x.DocumentUploadId),
                        FullName = x.FullName,
                        Status = x.Status,
                        DateOfBirth = x.DateOfBirth,
                        Sex = x.Sex,
                        Address = x.Address,
                        ModifiedDate = x.ModifiedDate,
                        PhoneNumber = x.PhoneNumber,
                        UserType = x.UserType,
                    }).FirstOrDefault();
            if (loginLatest.HasValue)
            {
                result.LastDateLogin = loginLatest.Value.ToString();
            }
            if (deviceStatus != null)
            {
                result.DeviceStatus = deviceStatus.Status;
            }
            if (string.IsNullOrEmpty(result?.Avatar)) return result;
            var path = Path.Combine(_env.ContentRootPath, result.Avatar);
            if (!File.Exists(path)) return result;
            result.Files = new Files
            {
                fileId = docId,
                fileName = Path.GetFileName(path),
                fileType = Path.GetExtension(path),
                filePreview = result.Avatar,
                fileSize = new FileInfo(path).Length
            };
            return result;
        }

        public string GetCurrentUserId()
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirst(claim => claim.Type.Equals("userId"))?.Value;
            return userId;
        }

        public string GetCurrentUserName()
        {
            var userId = GetCurrentUserId();
            if (userId == null)
            {
                return null;
            }
            else
            {
                var user = _userManager.FindByIdAsync(userId).GetAwaiter().GetResult();
                return user?.UserName;
            }
        }

        //public async Task<bool> SendMailToActive(ActivationAccountRequest activationAccountRequest)
        //{
        //    try
        //    {
        //        var emailTemplate = _emailTemplateService.GetEmailTemplateByCode(Constant.EmailTemplate.ConfirmAccount);
        //        if (emailTemplate == null)
        //        {
        //            return false;
        //        }
        //        var returnMessage = string.Empty;
        //        var activeAccountUrl = $"{_appSettings.ActiveAccountUrl}{activationAccountRequest.Token}";
        //        _logger.LogInformation("Begin sending mail about activation account");
        //        var body = emailTemplate.Description.Replace(Constant.FullName, activationAccountRequest.FullName)
        //                                            .Replace(Constant.ActiveUrl, activeAccountUrl);
        //        var sendMail = await _sendMailService.SendToEmailAsync(activationAccountRequest.Email, null, "Create User Successfully", body, ref returnMessage);
        //        var dataGenerate = new CreateEmailGeneratedDto
        //        {
        //            ErrorMessage = returnMessage,
        //            CC = emailTemplate.CC,
        //            Description = body,
        //            EmailType = emailTemplate.Code,
        //            ReferenceNumber = 0,
        //            ReferenceTypeId = ReferenceTypeEnum.CreateUser.GetHashCode(),
        //            SendTo = activationAccountRequest.Email,
        //            SentDate = DateTime.Now,
        //            Status = sendMail ? EmailGenerateStatusEnum.Success.GetHashCode() : EmailGenerateStatusEnum.Failure.GetHashCode(),
        //            Subject = emailTemplate.Title,
        //            Title = emailTemplate.Title,
        //            SendFrom = _emailConfiguration.EmailAdmin
        //        };
        //        await _emailGeneratedService.CreateAsync(dataGenerate);
        //        _logger.LogInformation("End sending mail about activation account");
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex?.Message);
        //        return false;
        //    }
        //}
        #region private

        public async Task<bool> KickOutUser(string userId)
        {
            using var trans = _unitOfWork.BeginTransaction();
            try
            {
                var user = await _userManager.FindByIdAsync(userId);
                if (user == null)
                {
                    _logger.LogWarning("Không tìm thấy user này trong system", userId);
                    return false;
                }
                var userRefreshToken = _refreshTokensRepository.FindAll(c => c.UserName == user.UserName);
                var userAccessToken = _userTokenRepository.FindAll(c => c.UserId == userId);
                if (userRefreshToken.Any())
                {
                    _refreshTokensRepository.DeleteMulti(userRefreshToken);
                }
                if (userAccessToken.Any())
                {
                    _userTokenRepository.DeleteMulti(userAccessToken);
                }
                await _unitOfWork.CompleteAsync();
                await trans.CommitAsync();
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError("Đã có lỗi xảy ra trong quá trình xóa refresh và access token", ex);
                await trans.RollbackAsync();
                return false;
            }
        }

        public async Task<bool> Delete(string userId)
        {
            try
            {
                var user = await _userManager.FindByIdAsync(userId);
                if (user == null)
                {
                    _logger.LogError("UserId này không tồn tại", userId);
                    return false;
                }
                // remove role of user
                await _userManager.SetLockoutEnabledAsync(user, true);
                await _userManager.SetLockoutEndDateAsync(user, DateTime.Now.AddYears(99));
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError("Đã có lỗi xảy ra trong quá trình xóa user ra khỏi hệ thống", ex);
                return false;
            }
        }

        public async Task<bool> UserLogin(User user, ExternalLoginInfor externalLoginInfor, UserLoginInfo userInfo)
        {
            var avartarId = await _documentUploadService.DownloadImageByUrl(externalLoginInfor);
            user.DocumentUploadId = avartarId;

            var newUser = await _userManager.CreateAsync(user);
            if (!newUser.Succeeded)
            {
                ///throw login exception
                _logger.LogInformation($"{StringMessage.ErrorMessages.CannotCreateAccount}: {externalLoginInfor.ExternalLoginId}");
                return false;
            }
            _ = await _userManager.AddToRoleAsync(user, RoleHelper.RegisterUser);

            ///innit userid to authenication membership
            await _userManager.AddLoginAsync(user, userInfo);

            ///add claim
            var claims = new List<Claim>();
            claims.Add(new Claim(Constant.ExternalLogin.NameIdentifier, externalLoginInfor.ExternalLoginId));
            claims.Add(new Claim(Constant.ExternalLogin.FirstName, externalLoginInfor.FirstName));
            claims.Add(new Claim(Constant.ExternalLogin.LastName, externalLoginInfor.LastName));

            await _userManager.AddClaimsAsync(user, claims);
            return true;
        }


        private static List<FilterExtensions.FilterParams> BuildParams(string email)
        {
            var filterParams = new List<FilterExtensions.FilterParams>();
            if (!string.IsNullOrEmpty(email))
                filterParams.Add(new FilterExtensions.FilterParams
                {
                    ColumnName = "Email",
                    FilterValue = email,
                    FilterOption = FilterExtensions.FilterOptions.Contains
                });
            return filterParams;
        }

        public List<UserAutoGenDto> GetUserNameToCreate()
        {
            var locals = _pcLocal07Repo.GetAll().Where(c => c.Id != 1).Select(c => new UserAutoGenDto { 
                LocalId = c.Id,
                LocalName = c.Name,
                LocalNameUnsign = c.UnSignName
            });
            return locals.ToList();
        }

        #endregion
    }
}

