using Google.Authenticator;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using QLHSC07.ApiGateway.Attribute;
using QLHSC07.ApiGateway.Service;
using QLHSC07.ApiGateway.Service.ExternalDto;
using QLHSC07.ApiGateway.Service.Worker;
using QLHSC07.CORE;
using QLHSC07.CORE.Enum;
using QLHSC07.CORE.FileService;
using QLHSC07.CORE.Helper;
using QLHSC07.CORE.Resource;
using QLHSC07.CORE.SendMailService;
using QLHSC07.CORE.Settings;
using QLHSC07.Data.Repository;
using QLHSC07.Entity.IdentityAccess;
using QLHSC07.Entity.IdentityExtentions.IdentityMapping;
using QLHSC07.Entity.QLHSC07_Entities;
using QLHSC07.Model.DocumentUpload;
using QLHSC07.Model.EmailGenerated;
using QLHSC07.Model.IdentityAccess;
using QLHSC07.Model.LogHistory;
using QLHSC07.Model.User;
using QLHSC07.Model.UserLoginLog;
using QLHSC07.Services.Helper;
using QLHSC07.Services.Interfaces;
using QLHSC07.Services.Models;
using System;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace QLHSC07.ApiGateway.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly ILogger<AccountController> _logger;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly AppSettings _appSettings;
        private readonly AuthService _authService;
        private readonly EmailConfiguration _emailConfiguration;
        private readonly IWorkerService _workerService;
        private readonly IUserService _userService;
        private readonly IEmailTemplateService _emailTemplateService;
        private readonly IEmailGeneratedService _emailGeneratedService;
        private readonly ISendMailService _sendMailService;
        private readonly IRoleService _roleService;
        private readonly IFileService _fileService;
        private readonly IDocumentUploadService _documentUploadService;
        private readonly IHostEnvironment _env;
        private readonly IWebHelper _webHelper;
        private readonly ILogHistoryService _logHistoryService;

        public AccountController(IUserService userService, IEmailGeneratedService emailGeneratedService, ISendMailService sendMailService, UserManager<User> userManager,
            SignInManager<User> signInManager, IWorkerService workerService, IFileService fileService, IDocumentUploadService documentUploadService,
            AppSettings appSettings, AuthService authService, IEmailTemplateService emailTemplateService, IRoleService roleService, IHostEnvironment env,
            IWebHelper webHelper, ILogger<AccountController> logger, ILogHistoryService logHistoryService, EmailConfiguration emailConfiguration)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _authService = authService;
            _emailConfiguration = emailConfiguration;
            _workerService = workerService;
            _userService = userService;
            _emailTemplateService = emailTemplateService;
            _emailGeneratedService = emailGeneratedService;
            _sendMailService = sendMailService;
            _fileService = fileService;
            _documentUploadService = documentUploadService;
            _env = env;
            _webHelper = webHelper;
            _roleService = roleService;
            _logHistoryService = logHistoryService;
            _appSettings = appSettings;
        }

        [HttpPost]
        public async Task<ActionResult> Login(LoginDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.DataNotValid,
                    ErrorMessage = StringMessage.ErrorMessages.DataNotValid,
                });
            }
            var user = await _userManager.FindByEmailAsync(model.Email);

            if (user == null)
            {
                user = await _userManager.FindByNameAsync(model.Email);
                if (user == null)
                {
                    return BadRequest(new ResponseErrorData
                    {
                        ErrorType = ErrorTypeConstant.EmailNotRegister,
                        ErrorMessage = string.Format(StringMessage.ErrorMessages.EmailNotRegister, model.Email),
                    });
                }
            }


            var result = await _signInManager.PasswordSignInAsync(user.UserName, model.Password, model.RememberMe, false);

            if (!result.Succeeded)
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorMessage = StringMessage.ErrorMessages.PasswordNotValid,
                    ErrorType = ErrorTypeConstant.PasswordNotValid,
                });
            }

            if (!user.Status)
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.AccountNotActive,
                    ErrorMessage = StringMessage.ErrorMessages.AccountNotActive,
                });
            }
            if (user.IsUse2FA == true)
            {
                return Ok(new ResponseData
                {
                    Content = new
                    {
                        isUse2Fa = true
                    },
                });
            }
            ///get token to login
            var token = await _authService.Authenticate(user.Email, true);
            ///save to log table
            await _authService.InsertUserLoginLog(new UserApiLogRequest
            {
                UserId = user.Id,
                UserName = user.UserName,
                ApiName = Constant.APIName.Login,
                FullName = user.FullName,
                IpAddress = _webHelper.GetCurrentIpAddress()
            });

            ///create refreshtoken
            var refreshToken = _authService.GenerateRefreshToken();

            await _authService.InsertRefreshTokens(user.UserName, refreshToken, _webHelper.GetCurrentIpAddress());

            if (string.IsNullOrWhiteSpace(token))
                return BadRequest(
                    new ResponseErrorData()
                    {
                        ErrorType = ErrorTypeConstant.AccountNotValid,
                        ErrorMessage = StringMessage.ErrorMessages.AccountNotValid
                    });

            return Ok(new ResponseData
            {
                Content = new
                {
                    isUse2Fa = false,
                    Token = token,
                    ReturnUrl = model.ReturnUrl,
                    RefreshToken = refreshToken
                },
            });
        }
        [HttpPost]
        public async Task<ActionResult> CheckValidUser(LoginDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.DataNotValid,
                    ErrorMessage = StringMessage.ErrorMessages.DataNotValid,
                });
            }
            var user = await _userManager.FindByEmailAsync(model.Email);

            if (user == null)
            {
                user = await _userManager.FindByNameAsync(model.Email);
                if (user == null)
                {
                    return BadRequest(new ResponseErrorData
                    {
                        ErrorType = ErrorTypeConstant.EmailNotRegister,
                        ErrorMessage = string.Format(StringMessage.ErrorMessages.EmailNotRegister, model.Email),
                    });
                }
            }

            var result = await _signInManager.PasswordSignInAsync(user.UserName, model.Password, model.RememberMe, false);

            if (!result.Succeeded)
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorMessage = StringMessage.ErrorMessages.PasswordNotValid,
                    ErrorType = ErrorTypeConstant.PasswordNotValid,
                });
            }

            return Ok(new ResponseData
            {
                Content = new
                {
                    isSuccess = true
                },
            });
        }
        [HttpPost]
        public async Task<ActionResult> Login2FA(Verify2FADto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.DataNotValid,
                    ErrorMessage = StringMessage.ErrorMessages.DataNotValid,
                });
            }
            var user = await _userManager.FindByEmailAsync(model.Email);
            var checkValid = await _signInManager.PasswordSignInAsync(user.UserName, model.Password, false, false);

            if (!checkValid.Succeeded)
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorMessage = StringMessage.ErrorMessages.PasswordNotValid,
                    ErrorType = ErrorTypeConstant.PasswordNotValid,
                });
            }

            TwoFactorAuthenticator tfA = new TwoFactorAuthenticator(HashType.SHA256);
            var result = tfA.ValidateTwoFactorPIN(user.SecretKey, model.VerifyCode, 1);
            if (result)
            {
                ///get token to login
                var token = await _authService.Authenticate(user.Email, true);
                ///save to log table
                await _authService.InsertUserLoginLog(new UserApiLogRequest
                {
                    UserId = user.Id,
                    UserName = user.UserName,
                    ApiName = Constant.APIName.Login,
                    FullName = user.FullName,
                    IpAddress = _webHelper.GetCurrentIpAddress()
                });

                ///create refreshtoken
                var refreshToken = _authService.GenerateRefreshToken();

                await _authService.InsertRefreshTokens(user.UserName, refreshToken, _webHelper.GetCurrentIpAddress());

                if (string.IsNullOrWhiteSpace(token))
                    return BadRequest(
                        new ResponseErrorData()
                        {
                            ErrorType = ErrorTypeConstant.AccountNotValid,
                            ErrorMessage = StringMessage.ErrorMessages.AccountNotValid
                        });

                return Ok(new ResponseData
                {
                    Content = new
                    {
                        Token = token,
                        ReturnUrl = model.ReturnUrl,
                        RefreshToken = refreshToken
                    },
                });
            }
            else
            {
                return BadRequest(
                       new ResponseErrorData()
                       {
                           ErrorType = ErrorTypeConstant.VerifyCodeNotValid,
                           ErrorMessage = StringMessage.ErrorMessages.VerifyCodeNotValid
                       });
            }

        }
        [HttpGet]
        [ActionName("GetUserAccountDetail")]
        [Authorize]
        public async Task<ActionResult> GetUserAccountDetail()
        {
            var userId = _workerService.GetCurrentUser()?.Id;
            if (userId == null)
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorMessage = ErrorTypeConstant.AccessDenied,
                    ErrorType = StringMessage.ErrorMessages.EmailNotRegister
                });
            }
            ///check membership neu het han se downgrade thanh free
            var user = _userService.GetByUserid(userId);

            var data = new DetailUserCmsModel
            {
                UserName = user.UserName,
                Id = user.Id,
                FullName = user.FullName,
                Email = user.Email,
                RoleName = _roleService.GetRoleNameById(user.UserRoles.Select(x => x.RoleId).FirstOrDefault()),
                DateOfBirth = user.DateOfBirth,
                Sex = user.Sex,
                Address = user.Address,
                Avatar = _documentUploadService.GetFilePathById(user.DocumentUploadId),
                PhoneNumber = user.PhoneNumber,
                IsUse2FA = user.IsUse2FA

            };
            return Ok(new ResponseData
            {
                Content = data
            });
        }

        /// <summary>
        /// API refreshtoken
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult> RefreshToken([FromBody] ExchangeRefreshTokenRequest request)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }

            ///Get device manage
            ///just using GetCurrentDevice when use QLHSAuthorize
            var deviceType = HttpContext.GetCurrentDevice();
            if (string.IsNullOrEmpty(deviceType))
                deviceType = Constant.DeviceDefault;
            var refreshToken = await _authService.ExchangeRefreshToken(
                new ExchangeRefreshTokenRequest() { AccessToken = request.AccessToken, RefreshToken = request.RefreshToken },
                deviceType
                );

            return StatusCode(StatusCodes.Status200OK, refreshToken);
        }

        /// <summary>
        /// API refreshtoken
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult> RemoveRefreshToken(string request)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            try
            {
                await _authService.DeleteRefreshTokens(request);
                return StatusCode(StatusCodes.Status200OK, StringMessage.SuccessMessage.DeleteRefreshToken);
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = $"{ErrorTypeConstant.DataNotValid} {ex}",
                    ErrorMessage = StringMessage.ErrorMessages.ErrorProcess,
                });
            }

        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult> ForgotPassword(ForgotPasswordDto model)
        {
            if (!ModelState.IsValid)
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.DataNotValid,
                    ErrorMessage = StringMessage.ErrorMessages.DataNotValid,
                });
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                // Don't reveal that the user does not exist or is not confirmed
                return BadRequest(
                    new ResponseErrorData
                    {
                        ErrorType = ErrorTypeConstant.EmailNotRegister,
                        ErrorMessage = string.Format(StringMessage.ErrorMessages.EmailNotRegister, model.Email),
                    });
            }
            var code = await _userManager.GeneratePasswordResetTokenAsync(user);
            var emailForgot = _emailTemplateService.GetEmailTemplateByCode(Constant.EmailTemplate.ForgotPassword);

            if (emailForgot == null)
            {
                return BadRequest(new ResponseErrorData()
                {
                    ErrorType = ErrorTypeConstant.EmailTemplateNotFound,
                    ErrorMessage = StringMessage.ErrorMessages.EmailTemplateNotFound
                });
            }
            var callbackUrl = $"{model.ReturnUrl}/{user.Id}?token={code}";
            var contentMail = emailForgot.Description
                .Replace("${USER}", user.FullName ?? user.Email)
                .Replace("${CALLBACK_LINK}", callbackUrl);

            var returnMessage = string.Empty;
            var sendMail = _sendMailService.SendToEmail(model.Email, null, "Forgot Password", contentMail,
                ref returnMessage);
            var dataGenerate = new CreateEmailGeneratedDto
            {
                ErrorMessage = returnMessage,
                CC = emailForgot.CC,
                Description = contentMail,
                EmailType = emailForgot.Code,
                ReferenceNumber = 0,
                ReferenceTypeId = ReferenceTypeEnum.ForgotPassword.GetHashCode(),
                SendTo = model.Email,
                SentDate = DateTime.Now,
                Status = sendMail ? EmailGenerateStatusEnum.Success.GetHashCode() : EmailGenerateStatusEnum.Failure.GetHashCode(),
                Subject = "Forgot Password",
                Title = emailForgot.Title,
                SendFrom = _emailConfiguration.EmailAdmin
            };
            _emailGeneratedService.Create(dataGenerate);
            if (!sendMail)
                return BadRequest(new ResponseErrorData()
                {
                    ErrorType = ErrorTypeConstant.SendMailError,
                    ErrorMessage = StringMessage.ErrorMessages.SendMailError
                });

            return Ok(
                new ResponseData
                {
                    Content = new
                    {
                        Status = true
                    }
                });
        }
        
        [HttpPost]
        [QLHSAuthorize]
        public async Task<ActionResult> ResetPassword(ResetPasswordDto model)
        {
            if (!ModelState.IsValid)
            {
                return Ok(model);
            }

            var query = _userService.GetByUserid(model.UserId);
            var user = await _userManager.FindByEmailAsync(query.Email);
            if (user == null)
            {
                // Don't reveal that the user does not exist
                ModelState.AddModelError("", @"Email không tồn tại");
                return Ok(model);
            }
            var result = await _userManager.ResetPasswordAsync(user, model.Code.Replace(" ", "+"), model.Password);
            var emailChangedPassword = _emailTemplateService.GetEmailTemplateByCode(Constant.EmailTemplate.ChangedPassword);
            var returnMessage = string.Empty;
            var contentMail = emailChangedPassword.Description
            .Replace("${EMAIL}", user.Email)
            .Replace("${PASSWORD}", model.Password);
            var sendMail = _sendMailService.SendToEmail(user.Email, null, emailChangedPassword.Title, contentMail, ref returnMessage);
            var dataGenerate = new CreateEmailGeneratedDto
            {
                ErrorMessage = returnMessage,
                CC = emailChangedPassword.CC,
                Description = contentMail,
                EmailType = emailChangedPassword.Code,
                ReferenceNumber = 0,
                ReferenceTypeId = ReferenceTypeEnum.ChangedPassword.GetHashCode(),
                SendTo = user.Email,
                SentDate = DateTime.Now,
                Status = sendMail ? EmailGenerateStatusEnum.Success.GetHashCode() : EmailGenerateStatusEnum.Failure.GetHashCode(),
                Subject = "Forgot Password",
                Title = emailChangedPassword.Title,
                SendFrom = _emailConfiguration.EmailAdmin
            };
            _emailGeneratedService.Create(dataGenerate);
            if (result.Succeeded)
            {
                return Ok(new ResponseData
                {
                    Content = new
                    {
                        Status = true
                    }
                });
            }

            var error = result.Errors.ToArray()[0].Description;
            return BadRequest(new ResponseErrorData
            {
                ErrorMessage = error,
                ErrorType = ErrorTypeConstant.UnableHandleException
            });
        }

        [HttpPost]
        [ActionName("UpdateUserAccount")]
        [QLHSAuthorize]
        public async Task<ActionResult> UpdateUserAccount([FromForm] UpdateUserAccountDto model, IFormFile File)
        {
            var userId = _workerService.GetCurrentUser()?.Id;
            var user = _userService.GetByUserid(userId);
            //var uploadFolderPath = Path.Combine("Uploads", "Ảnh người dùng");
            var uploadFolderPath = Constant.PathName.UserFolder;
            long? avatarId = null;
            if (File != null)
            {
                if (File.Length > 2048000) //2Mb
                {
                    return BadRequest(new ResponseErrorData
                    {
                        ErrorMessage = StringMessage.ErrorMessages.FileTooLarge,
                        ErrorType = ErrorTypeConstant.FileTooLarge
                    });
                }

                if (File.FileName.Length > 70)
                {
                    return BadRequest(new ResponseErrorData
                    {
                        ErrorMessage = StringMessage.ErrorMessages.FileNameTooLong,
                        ErrorType = ErrorTypeConstant.FileNameTooLong
                    });
                }
                var returnPath = await _fileService.SaveFileAsync(uploadFolderPath, File);
                var fullPath = Path.Combine(_env.ContentRootPath, returnPath);
                var data = new DocumentUploadDto
                {
                    Name = File.FileName,
                    ParentId = 1,
                    Path = returnPath,
                    Type = 1,
                    //Title = File.FileName,
                    FileExtensionId = _documentUploadService.GetFileExtIdByPath(fullPath)
                };
                avatarId = _documentUploadService.SaveFile(data, user.Email);
            }

            user.DocumentUploadId = avatarId ?? user.DocumentUploadId;
            user.ModifiedBy = user.FullName;
            user.ModifiedDate = DateTime.Now;
            user.FullName = model.FullName;
            if (model.DateOfBirth.HasValue)
                user.DateOfBirth = model.DateOfBirth;

            if (model.Sex.HasValue)
                user.Sex = model.Sex;
            user.Address = model.Address;
            user.PhoneNumber = model.PhoneNumber;

            var isUpdated = await _userManager.UpdateAsync(user);
            if (!isUpdated.Succeeded)
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorMessage = StringMessage.ErrorMessages.ErrorProcess,
                    ErrorType = ErrorTypeConstant.ErrorProcess
                });
            }
            return Ok(new ResponseData
            {
                Content = new
                {
                    Status = true
                }
            });
        }

        [HttpPost]
        [ActionName("ChangePassword")]
        [QLHSAuthorize]
        public async Task<ActionResult> ChangePassword([FromBody] ChangePasswordDto model)
        {
            var userId = _workerService.GetCurrentUser()?.Id;
            if (userId == null) return BadRequest(new ResponseErrorData
            {
                ErrorMessage = StringMessage.ErrorMessages.AccessDenied,
                ErrorType = ErrorTypeConstant.AccessDenied
            });

            var user = _userService.GetByUserid(userId);
            IdentityResult identity = null;
            if (!string.IsNullOrEmpty(model.NewPassword) && !string.IsNullOrEmpty(model.CurrentPassword))
            {
                //var checkPassword = new Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[@$!%*?&])[A-Za-z0-9@$!%*?&]{8,}$");
                //if (!checkPassword.IsMatch(model.NewPassword))
                //{
                //    return BadRequest(new ResponseErrorData
                //    {
                //        ErrorMessage = StringMessage.ErrorMessages.NewPasswordNotValid,
                //        ErrorType = ErrorTypeConstant.NewPasswordNotValid
                //    });
                //}

                identity = await _userManager.ChangePasswordAsync(user, model.CurrentPassword, model.NewPassword);
            }

            if (identity == null || !identity.Succeeded)
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorMessage = identity.Errors.Select(x => x.Description).FirstOrDefault(),
                    ErrorType = ErrorTypeConstant.ErrorProcess
                });
            }

            return Ok(new ResponseData
            {
                Content = new
                {
                    Status = true
                }
            });
        }

        // <summary>
        /// API refreshtoken
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult> RemoveRefreshTokenByUserName(string userName)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            try
            {
                ///Get device manage
                ///just using GetCurrentDevice when use QLHSAuthorize
                var deviceType = HttpContext.GetCurrentDevice();
                if (string.IsNullOrEmpty(deviceType))
                    deviceType = Constant.DeviceDefault;
                await _authService.DeleteRefreshTokensByUserName(userName, deviceType);
                return StatusCode(StatusCodes.Status200OK, StringMessage.SuccessMessage.DeleteRefreshToken);
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = $"{ErrorTypeConstant.DataNotValid} {ex}",
                    ErrorMessage = StringMessage.ErrorMessages.ErrorProcess,
                });
            }

        }

        [HttpDelete]
        public async Task<IActionResult> Logout(string refreshToken)
        {
            var user = _workerService.GetCurrentUser();
            if (user == null)
            {
                return Unauthorized();
            }
            ///Get device manage
            ///just using GetCurrentDevice when enable QLHSAuthorize
            var deviceType = HttpContext.GetCurrentDevice();
            if (string.IsNullOrEmpty(deviceType))
                deviceType = Constant.DeviceDefault;
            var accessToken = HttpContext.GetCurrentToken();
            if (string.IsNullOrEmpty(accessToken) || string.IsNullOrEmpty(refreshToken)) return Unauthorized();

            ///get token
            AuthenticationHeaderValue.TryParse(accessToken, out var headerValue);
            var token = headerValue.Parameter;

            if (string.IsNullOrEmpty(deviceType))
                deviceType = Constant.DeviceDefault;
            await _authService.LogOut(user, deviceType, token, refreshToken);
            return Ok();
        }
        [HttpPost]
        [ActionName("Enable2FA")]
        public async Task<ActionResult> Enable2FA(Enable2FADto dto)
        {

            var currentUser = _workerService.GetCurrentUser();
            var user = _userService.GetByUserid(currentUser.Id);

            TwoFactorAuthenticator tfA = new TwoFactorAuthenticator(HashType.SHA256);
            var isCorrect = tfA.ValidateTwoFactorPIN(user.SecretKey, dto.VerifyCode, 0);
            if (isCorrect)
            {
                user.IsUse2FA = true;
                user.SecretKey = dto.SecretKey;
                string fileName = "QR_" + user.Id;
                _fileService.RemoveFile(Path.Combine(Constant.PathName.UserFolder, fileName));
                var result = await _userManager.UpdateAsync(user);
                if (!result.Succeeded)
                {
                    return BadRequest(new ResponseErrorData
                    {
                        ErrorType = ErrorTypeConstant.ErrorProcess,
                        ErrorMessage = StringMessage.ErrorMessages.ErrorProcess
                    });
                }
                CreateLogHistory(ActionEnum.UPDATE.GetHashCode(), "Enable2FA");
                return Ok(new ResponseData
                {
                    Content = new
                    {
                        Status = true
                    }
                });
            }
            else
            {
                return Ok(new ResponseData
                {
                    Content = new
                    {
                        Status = false,
                        Error = StringMessage.ErrorMessages.VerifyCodeNotValid
                    },
                    Err = "true"
                });
            }
        }

        
        [HttpPost]
        [ActionName("Disable2FA")]
        public async Task<ActionResult> Disable2FA(Disable2FaDto dto)
        {
            var currentUser = _workerService.GetCurrentUser();
            var checkPassword = await _signInManager.PasswordSignInAsync(currentUser.UserName, dto.password, false, false);
            if (!checkPassword.Succeeded)
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorMessage = StringMessage.ErrorMessages.PasswordNotValid,
                    ErrorType = ErrorTypeConstant.PasswordNotValid,
                });
            }
            var user = _userService.GetByUserid(currentUser.Id);
            user.IsUse2FA = false;
            user.SecretKey = "";
            var result = await _userManager.UpdateAsync(user);
            if (!result.Succeeded)
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.ErrorProcess,
                    ErrorMessage = StringMessage.ErrorMessages.ErrorProcess
                });
            }
            CreateLogHistory(ActionEnum.UPDATE.GetHashCode(), "Enable2FA");
            return Ok(new ResponseData
            {
                Content = new
                {
                    Status = true
                }
            });
        }
        [HttpPost]
        [ActionName("GetQR2FA")]
        public async Task<ActionResult> GetQR2FA()
        {
            try
            {


                var currentUser = _workerService.GetCurrentUser();
                var user = _userService.GetByUserid(currentUser.Id);
                var secretKey = Guid.NewGuid().ToString();
                user.SecretKey = secretKey;
                //await _userManager.UpdateAsync(user);

                TwoFactorAuthenticator tfA = new TwoFactorAuthenticator(HashType.SHA256);
                var setupCode = tfA.GenerateSetupCode(_appSettings.BaseUrl, user.UserName, secretKey, false, 3);
                string fileName = "QR_" + user.Id + ".png";
                var filePath = await _fileService.SaveFileAsync(Constant.PathName.UserFolder, Convert.FromBase64String(setupCode.QrCodeSetupImageUrl.Replace("data:image/png;base64,", "")), fileName);
                CreateLogHistory(ActionEnum.UPDATE.GetHashCode(), "GetQR2FA");
                return Ok(new ResponseData
                {
                    Content = new
                    {
                        Status = true,
                        filePath = filePath,
                        secretKey = secretKey,
                    }
                });
            }
            catch (Exception ex)
            {
                CreateLogHistory(ActionEnum.UPDATE.GetHashCode(), "GetQR2FA");

                return Ok(new ResponseData
                {
                    Content = new
                    {
                        Status = false,
                        error = ex.ToString(),

                    }
                });
            }

        }

        [HttpPost]
        [ActionName("ChangeSecretKey")]
        public async Task<ActionResult> ChangeSecretKey(ChangeSecretKeyDto dto)
        {
            try
            {
                var currentUser = _workerService.GetCurrentUser();
                var checkPassword = await _signInManager.PasswordSignInAsync(currentUser.UserName, dto.password, false, false);
                if (!checkPassword.Succeeded)
                {
                    return BadRequest(new ResponseErrorData
                    {
                        ErrorMessage = StringMessage.ErrorMessages.PasswordNotValid,
                        ErrorType = ErrorTypeConstant.PasswordNotValid,
                    });
                }
                var user = _userService.GetByUserid(currentUser.Id);
                var secretKey = Guid.NewGuid().ToString();
                user.SecretKey = secretKey;
                user.IsUse2FA = false;
                await _userManager.UpdateAsync(user);

                TwoFactorAuthenticator tfA = new TwoFactorAuthenticator(HashType.SHA256);
                var setupCode = tfA.GenerateSetupCode(_appSettings.BaseUrl, user.UserName, secretKey, false, 3);
                string fileName = "QR_" + user.Id;
                var filePath = await _fileService.SaveFileAsync(Constant.PathName.UserFolder, Convert.FromBase64String(setupCode.QrCodeSetupImageUrl.Replace("data:image/png;base64,", "")), fileName);
                CreateLogHistory(ActionEnum.UPDATE.GetHashCode(), "GetQR2FA");
                return Ok(new ResponseData
                {
                    Content = new
                    {
                        Status = true,
                        filePath = filePath,
                        secretKey = secretKey,
                    }
                });
            }
            catch (Exception ex)
            {
                CreateLogHistory(ActionEnum.UPDATE.GetHashCode(), "GetQR2FA");

                return Ok(new ResponseData
                {
                    Content = new
                    {
                        Status = false,
                        error = ex.ToString(),

                    }
                });
            }

        }

        [HttpPost]
        [QLHSAuthorize]
        public async Task<ActionResult> CheckPassword(CheckPasswordDto model)
        {
            if (!ModelState.IsValid)
            {
                return Ok(model);
            }
            var currentUser = _workerService.GetCurrentUser();
            var user = _userService.GetByUserid(currentUser.Id);
            var result = await _signInManager.PasswordSignInAsync(user.UserName, model.Password, false, false);
            if (result.Succeeded)
            {
                return Ok(new ResponseData
                {
                    Content = new
                    {
                        Status = true
                    }
                });
            }
            else
            {
                return Ok(new ResponseData
                {
                    Content = new
                    {
                        Status = false
                    }
                });
            }
        }
        private void CreateLogHistory(int action, string description)
        {
            CurrentUserDto currentUserModel = _workerService.GetCurrentUser();
            if (currentUserModel == null)
                return;
            LogHistoryDto logHistoryModel = new LogHistoryDto
            {
                Action = action,
                Description = description,
                UserName = currentUserModel.FullName
            };
            _logHistoryService.Create(logHistoryModel, currentUserModel);
        }
    }
}
