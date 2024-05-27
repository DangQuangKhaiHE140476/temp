using AutoMapper;
using Google.Authenticator;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using QLHSC07.ApiGateway.Attribute;
using QLHSC07.ApiGateway.Configuration;
using QLHSC07.ApiGateway.Service.Worker;
using QLHSC07.CORE;
using QLHSC07.CORE.Enum;
using QLHSC07.CORE.FileService;
using QLHSC07.CORE.Helper;
using QLHSC07.CORE.Resource;
using QLHSC07.CORE.SendMailService;
using QLHSC07.CORE.Settings;
using QLHSC07.Entity.IdentityAccess;
using QLHSC07.Model.EmailGenerated;
using QLHSC07.Model.IdentityAccess;
using QLHSC07.Model.LogHistory;
using QLHSC07.Model.User;
using QLHSC07.Services.Interfaces;
using System;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace QLHSC07.ApiGateway.Controllers.Admin
{
    [Route("api/admin/[controller]/[action]")]

    public class UserController : ControllerBase
    {
        private long? uploadDefaultId = null;
        private readonly IUserService _userService;
        private readonly IFileService _fileService;
        private readonly IRoleService _roleService;
        private readonly UserManager<User> _userManager;
        private readonly ISendMailService _sendMailService;
        private readonly IEmailTemplateService _emailTemplateService;
        private readonly IEmailGeneratedService _emailGeneratedService;
        private readonly EmailConfiguration _emailConfiguration;
        private readonly IWorkerService _workerService;
        private readonly AppSettings _appSettings;
        private readonly ILogHistoryService _logHistoryService;
        private readonly Mapper _mapper;
        private readonly IDocumentUploadService _documentUploadService;
        private readonly SignInManager<User> _signInManager;


        public UserController(AppSettings appSettings,IEmailTemplateService emailTemplateService, ISendMailService sendMailService,
            IUserService userService, IFileService fileService, UserManager<User> userManager, Mapper mapper,
            IRoleService roleService, IEmailGeneratedService emailGeneratedService, EmailConfiguration emailConfiguration, 
            IWorkerService workerService, ILogHistoryService logHistoryService, IDocumentUploadService documentUploadService, SignInManager<User> signInManager)
        {
            _userService = userService;
            _fileService = fileService;
            _userManager = userManager;
            _roleService = roleService;
            _sendMailService = sendMailService;
            _emailTemplateService = emailTemplateService;
            _emailGeneratedService = emailGeneratedService;
            _emailConfiguration = emailConfiguration;
            _workerService = workerService;
            _appSettings = appSettings;
            _logHistoryService = logHistoryService;
            _workerService = workerService;
            _mapper = mapper;
            _documentUploadService = documentUploadService;
            _signInManager = signInManager;
        }
        [HttpGet]
        [ActionName("GetUserManagement")]
        [RequiresPermission(RoleHelper.Action.View, RoleHelper.Screen.UserManagement)]
        public ActionResult GetUserManagement(FilterUserDto filter)
        {
            if (filter.PageIndex == 0) filter.PageIndex = Constant.DefaultPageIndex;
            if (filter.PageSize == 0) filter.PageSize = Constant.DefaultPageSize;
            var data = _userService.List(filter.PageIndex, filter.PageSize, filter.SortExpression, filter.Email, Constant.UserType.ADMINUSER, filter.FullName, null);
            CreateLogHistory(ActionEnum.VIEW.GetHashCode(), "GetUserManagement");
            return Ok(new ResponseData
            {
                Content = data
            });
        }

        [HttpGet]
        [ActionName("GetUserDetail")]
        public ActionResult GetUserDetail(string id)
        {
            var data = _userService.GetUserDetail(id);
            CreateLogHistory(ActionEnum.VIEW.GetHashCode(), "GetUserDetail");
            return Ok(new ResponseData
            {
                Content = data
            });
        }

        [HttpPost]
        [ActionName("CreateUser")]
        //[RequiresPermission(RoleHelper.Action.Create, RoleHelper.Screen.UserManagement)]
        public async Task<ActionResult> CreateUser([FromForm] CreateUserDto model, IFormFile file)
        {
            if (!ModelState.IsValid && ModelState.Root.GetModelStateForProperty("DateOfBirth").ValidationState != ModelValidationState.Invalid)
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.DataNotValid,
                    ErrorMessage = StringMessage.ErrorMessages.DataNotValid
                });
            }           

            ///to auto generate user base on PC07local
            //var fakePass = "123@123Ab";
            var fakePass = new Password(_userManager).GeneratePassword();

            ///upload and save file
            long? uploadId = uploadDefaultId;
            if (file != null)
            {
                var returnPath = await _fileService.SaveFileAsync(Constant.PathName.UserFolder, file);
                uploadId = await _documentUploadService.UploadAndSave(file, model.Email, returnPath);
            }
            var user = new User
            {
                Id = Guid.NewGuid().ToString(),
                UserName = model.Email,
                Email = model.Email,
                PhoneNumber = model.PhoneNumber,
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                FullName = model.FullName,
                Sex = model.Sex,
                Address = model.Address,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                CreatedBy = "Administrator",
                ModifiedBy = "Administrator",
                DocumentUploadId = uploadId,
                Status = true,
                Description = model.Description,
                DateOfBirth = model.DateOfBirth,
                UserType=Constant.UserType.ADMINUSER,
                IsUse2FA = false,
                SecretKey = ""
            };
            var userExits = await _userManager.FindByEmailAsync(model.Email);

            if (userExits != null)
                return BadRequest(
                    new ResponseErrorData
                    {
                        ErrorType = ErrorTypeConstant.UserAlreadyExits,
                        ErrorMessage = StringMessage.ErrorMessages.UserAlreadyExits
                    });

            var result = await _userManager.CreateAsync(user, fakePass);
            if (!result.Succeeded)
            {                
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.ErrorProcess,
                    ErrorMessage = StringMessage.ErrorMessages.ErrorProcess
                });
            }
            if (string.IsNullOrWhiteSpace(model.RoleId))
                return Ok(new ResponseData
                {
                    Content = new
                    {
                        Status = true
                    }
                });
            var role = _roleService.GetById(model.RoleId).NormalizedName;
            _ = await _userManager.AddToRoleAsync(user, role);

            ///add claim
            _ = await _userManager.AddClaimAsync(user, new Claim(Constant.RecordPermission, Constant.SeeOnlyMineRecord));

            var emailTemplate = _emailTemplateService.GetEmailTemplateByCode(Constant.EmailTemplate.CreateUser);
            var contentMail = emailTemplate.Description.Replace("${EMAIL}", model.Email)
                .Replace("${PASSWORD}", fakePass)
                .Replace("${LOGIN}", _appSettings.UrlLogin);
            var returnMessage = string.Empty;

            var sendMail = _sendMailService.SendToEmail(model.Email, null, "Create User Successfully", contentMail,
                ref returnMessage);
            var dataGenerate = new CreateEmailGeneratedDto
            {
                ErrorMessage = returnMessage,
                CC = emailTemplate.CC,
                Description = contentMail,
                EmailType = emailTemplate.Code,
                ReferenceNumber = 0,
                ReferenceTypeId = ReferenceTypeEnum.CreateUser.GetHashCode(),
                SendTo = model.Email,
                SentDate = DateTime.Now,
                Status = sendMail ? EmailGenerateStatusEnum.Success.GetHashCode() : EmailGenerateStatusEnum.Failure.GetHashCode(),
                Subject = emailTemplate.Title,
                Title = emailTemplate.Title,
                SendFrom = _emailConfiguration.EmailAdmin
            };
            _emailGeneratedService.Create(dataGenerate);
            CreateLogHistory(ActionEnum.CREATE.GetHashCode(), "CreateUser");
            return Ok(new ResponseData
            {
                Content = new
                {
                    Status = true
                }
            });
        }

        [HttpPost]
        [ActionName("UpdateUser")]
        [RequiresPermission(RoleHelper.Action.Update, RoleHelper.Screen.UserManagement)]
        public async Task<ActionResult> UpdateUser([FromForm] UpdateUserDto model, IFormFile file)
        {
            var user = await _userManager.FindByIdAsync(model.Id);
            if (user == null || !ModelState.IsValid && ModelState.Root.GetModelStateForProperty("DateOfBirth").ValidationState != ModelValidationState.Invalid) 
            return BadRequest(new ResponseErrorData
            {
                ErrorType = ErrorTypeConstant.DataNotValid,
                ErrorMessage = StringMessage.ErrorMessages.DataNotValid
            });
            ///upload and save file
            long? uploadId = uploadDefaultId;
            if (file != null)
            {
                var returnPath = await _fileService.SaveFileAsync(Constant.PathName.UserFolder, file);
                uploadId = await _documentUploadService.UploadAndSave(file, model.Email, returnPath);
            }

            var role = _roleService.GetById(model.RoleId).NormalizedName;
            if (!string.IsNullOrWhiteSpace(model.RoleId))
            {
                var userRole = await _userManager.GetRolesAsync(user);
                if (userRole.Any())
                {
                    foreach (var itemR in userRole)
                    {
                        _ = await _userManager.RemoveFromRoleAsync(user, itemR);
                    }
                }

                await _userManager.AddToRoleAsync(user, role);
            }
            user.ModifiedBy = "Administrator";
            user.ModifiedDate = DateTime.Now;
            user.FullName = model.FullName;
            user.Sex = model.Sex;
            user.Address = model.Address;
            user.DocumentUploadId = uploadId;
            user.Description = model.Description;
            user.ModifiedDate = DateTime.Now;
            user.FullName = model.FullName;
            user.DateOfBirth = model.DateOfBirth;
            user.PhoneNumber = model.PhoneNumber;
            var i = await _userManager.UpdateAsync(user);

            ///change recordpermission 
            ///getclaim
            var claimRecordPermission = await _userManager.GetClaimsAsync(user);
            if (claimRecordPermission.Any())
            {
                var recordPermission = claimRecordPermission.FirstOrDefault(c => c.Type == Constant.RecordPermission);
                _ = recordPermission != null ? _userManager.ReplaceClaimAsync(user,
               new Claim(Constant.RecordPermission, recordPermission.Value),
               new Claim(Constant.RecordPermission, model.RecordPermission.ToString())) : null;
            }

            if (!i.Succeeded)
            {

                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.ErrorProcess,
                    ErrorMessage = StringMessage.ErrorMessages.ErrorProcess
                });
            }
            CreateLogHistory(ActionEnum.UPDATE.GetHashCode(), "UpdateUser");
            return Ok(new ResponseData
            {
                Content = new
                {
                    Status = true
                }
            });
        }
        [HttpPost]
        [ActionName("ActiveUser")]
        [RequiresPermission(RoleHelper.Action.Update, RoleHelper.Screen.UserManagement)]
        public async Task<ActionResult> ActiveUser(string id)
        {
            var user = _userService.GetByUserid(id);

            user.Status = true;

            var result = await _userManager.UpdateAsync(user);
            if (!result.Succeeded)
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.ErrorProcess,
                    ErrorMessage = StringMessage.ErrorMessages.ErrorProcess
                });
            }
            var emailTemplate = _emailTemplateService.GetEmailTemplateByCode(Constant.EmailTemplate.ACTIVEUSER);

            var contentMail = emailTemplate.Description
                .Replace("${LOGIN}", _appSettings.UrlLogin);

            var returnMessage = string.Empty;
            var sendMail = _sendMailService.SendToEmail(user.Email, null, "Active User Successfully", contentMail,
                ref returnMessage);
            var dataGenerate = new CreateEmailGeneratedDto
            {
                ErrorMessage = returnMessage,
                CC = emailTemplate.CC,
                Description = contentMail,
                EmailType = emailTemplate.Code,
                ReferenceNumber = 0,
                ReferenceTypeId = ReferenceTypeEnum.ActiveUser.GetHashCode(),
                SendTo = user.Email,
                SentDate = DateTime.Now,
                Status = sendMail ? EmailGenerateStatusEnum.Success.GetHashCode() : EmailGenerateStatusEnum.Failure.GetHashCode(),
                Subject = emailTemplate.Title,
                Title = emailTemplate.Title,
                SendFrom = _emailConfiguration.EmailAdmin
            };
            _emailGeneratedService.Create(dataGenerate);
            CreateLogHistory(ActionEnum.UPDATE.GetHashCode(), "ActiveUser");
            return Ok(new ResponseData
            {
                Content = new
                {
                    Status = true
                }
            });
        }
        [HttpPost]
        [ActionName("DeActiveUser")]
        [RequiresPermission(RoleHelper.Action.Update, RoleHelper.Screen.UserManagement)]
        public async Task<ActionResult> DeActiveUser(string id)
        {
            var user = _userService.GetByUserid(id);

            user.Status = false;

            var result = await _userManager.UpdateAsync(user);
            if (!result.Succeeded)
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.ErrorProcess,
                    ErrorMessage = StringMessage.ErrorMessages.ErrorProcess
                });
            }
            CreateLogHistory(ActionEnum.UPDATE.GetHashCode(), "DeActiveUser");
            return Ok(new ResponseData
            {
                Content = new
                {
                    Status = true
                }
            });
        }
        [HttpPost]
        [ActionName("ResetPassword")]
        [RequiresPermission(RoleHelper.Action.Update, RoleHelper.Screen.UserManagement)]
        public async Task<ActionResult> ResetPassword(ResetPasswordAdminDto model)
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
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.AccountNotValid,
                    ErrorMessage = StringMessage.ErrorMessages.AccountNotValid
                });
            }
            var code = await _userManager.GeneratePasswordResetTokenAsync(user);
            var result = await _userManager.ResetPasswordAsync(user, code, model.Password);
            var emailChangedPassword = _emailTemplateService.GetEmailTemplateByCode(Constant.EmailTemplate.ChangedPassword);  
            var returnMessage = string.Empty;            
            var contentMail = emailChangedPassword.Description            
            .Replace("${EMAIL}", user.Email)
            .Replace("${PASSWORD}", model.Password);
            var sendMail = _sendMailService.SendToEmail(user.Email,null,emailChangedPassword.Title,contentMail,ref returnMessage);
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
            CreateLogHistory(ActionEnum.UPDATE.GetHashCode(), "ResetPassword");
            if (!sendMail)
                return Ok(new ResponseErrorData()
                {
                    ErrorType = ErrorTypeConstant.SendMailError,
                    ErrorMessage = StringMessage.ErrorMessages.SendMailError
                });            
            return Ok(new ResponseData
            {
                Content = new
                {
                    Status = true
                }
            });
        }

        [HttpPost]
        [ActionName("KickOutUser")]
        [RequiresPermission(RoleHelper.Action.Update, RoleHelper.Screen.UserManagement)]
        public async Task<ActionResult> KickOutUser(string userId)
        {
            if (string.IsNullOrEmpty(userId))
            {
                return Ok(false);
            }

            var isSuccedd = await _userService.KickOutUser(userId);
            
            return Ok(new ResponseData
            {
                Content = new
                {
                    Status = isSuccedd
                }
            });
        }
        [HttpDelete]
        [ActionName("DeleteUser")]
        [RequiresPermission(RoleHelper.Action.Delete, RoleHelper.Screen.UserManagement)]
        public async Task<ActionResult> Delete(string userId)
        {
            if (string.IsNullOrEmpty(userId))
            {
                return Ok(false);
            }

            var isSuccedd = await _userService.Delete(userId);

            return Ok(new ResponseData
            {
                Content = new
                {
                    Status = isSuccedd
                }
            });
        }
        
        [HttpPost]
        public async Task<IActionResult> AutoGenerateUser()
        {
            var userName = _userService.GetUserNameToCreate();
            foreach (var item in userName)
            {
                await CreateUser(new CreateUserDto
                {
                    FullName = item.LocalName,
                    DateOfBirth = new DateTime(1999, 10, 10),
                    Address = item.LocalName,
                    //Email = $"{item.LocalNameUnsign}@gmail.com",
                    Email = $"{UtilHelper.ConvertToUnSign(item.LocalName).Replace(" ","")}@gmail.com",
                    RoleId = "9afd2bb2-7501-4375-aac4-e1c918cd8f13",
                }, null);
            }
            return Ok();
        }
        private void CreateLogHistory(int action, string description)
        {
            CurrentUserDto currentUserModel = _workerService.GetCurrentUser();
            LogHistoryDto logHistoryModel = new LogHistoryDto
            {
                Action = action,
                Description = description,
                UserName = currentUserModel?.FullName
            };
            _logHistoryService.Create(logHistoryModel, currentUserModel);
        }

    }
    
}
