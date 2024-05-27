using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using QLHSC07.CORE;
using QLHSC07.CORE.Extensions;
using QLHSC07.CORE.FileService;
using QLHSC07.CORE.Helper;
using QLHSC07.CORE.Resource;
using QLHSC07.CORE.SendMailService;
using QLHSC07.CORE.Settings;
using QLHSC07.Data.Repository;
using QLHSC07.Entity;
using QLHSC07.Entity.IdentityAccess;
using QLHSC07.Entity.QLHSC07_Entities;
using QLHSC07.Entity.QLHSC07_MSG_Entities;
using QLHSC07.Infrastructure.Implements;
using QLHSC07.Infrastructure.Interface;
using QLHSC07.Model.DocumentUpload;
using QLHSC07.Model.QLHSC07_Dtos.MsgExchange;
using QLHSC07.Model.QLHSC07_Dtos.MsgExchangeService;
using QLHSC07.Model.User;
using QLHSC07.Services.BaseServices;
using QLHSC07.Services.Interfaces;
using QLHSC07.Services.Interfaces.QLHSC07;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHSC07.Services.Implements.QLHSC07
{
    public class MsgExchangeService : BaseService<string, MsgSession, MsgSessionDto, MsgSessionDto, CreateMsgExchange, UpdateMsgExchangeDto, FilterMsgExchangeDto>, IMsgExchangeService
    {
        /// <summary>
        /// to get id for receive user
        /// </summary>
        private readonly IRepository<PC07Local, long> _pc07LocalRepo;
        private readonly IRepository<Message, long> _messageRepo;
        private readonly IRepository<HasMsgSession, long> _hasMsgSessionRepo;
        private readonly IRepository<MsgReceive, long> _msgReceiveRepo;
        private readonly IRepository<MessageHasFile, long> _messageHasFileRepo;
        private readonly IRepository<DocumentUpload, long> _documentUploadRepo;
        private readonly IDocumentUploadService _documentUploadService;
        private readonly IFileService _fileService;
        private readonly ISendMailService _sendMailService;
        private readonly AppSettings _appSettings;
        private readonly IEmailTemplateService _emailTemplateService;

        public MsgExchangeService(IRepository<MsgSession, string> repository, IMapper mapper, ILogger<MsgExchangeService> logger, IUnitOfWork unitOfWork,
            IHttpContextAccessor httpContextAccessor, UserManager<User> userManager,
            IRepository<PC07Local, long> pc07LocalRepo,
            IRepository<Message, long> messageRepo,
            IRepository<MsgReceive, long> msgReceiveRepo,
            IRepository<HasMsgSession, long> hasMsgSessionRepo,
            IRepository<MessageHasFile, long> messageHasFileRepo,
            IRepository<DocumentUpload, long> documentUploadRepo,
            IDocumentUploadService documentUploadService,
            IFileService fileService, ISendMailService sendMailService,
            AppSettings appSettings, IEmailTemplateService emailTemplateService)
            : base(repository, mapper, logger, unitOfWork, httpContextAccessor, userManager)
        {
            _documentUploadService = documentUploadService;
            _messageHasFileRepo = messageHasFileRepo;
            _fileService = fileService;
            _pc07LocalRepo = pc07LocalRepo;
            _messageRepo = messageRepo;
            _msgReceiveRepo = msgReceiveRepo;
            _documentUploadRepo = documentUploadRepo;
            _hasMsgSessionRepo = hasMsgSessionRepo;
            _sendMailService = sendMailService;
            _appSettings = appSettings;
            _emailTemplateService = emailTemplateService;
        }

        public async Task<ResponseItem<bool>> SendDocuments(CreateMsgExchange messages,
            CurrentUserDto user,
            List<IFormFile> files)
        {
            ///open transaction
            using var trans = _unitOfWork.BeginTransaction();
            try
            {
                if (!messages.ReceiveUnitId.Any())
                {
                    return new ResponseItem<bool>
                    {
                        Err = 1,
                        ResponseError = new ResponseErrorData
                        {
                            ErrorMessage = StringMessage.ErrorMessages.ReceiveInvalid,
                            ErrorType = ErrorTypeConstant.ErrorProcess
                        },
                        Result = false
                    };
                }
                var entityModel = (await BuildEntities(messages, user, files));
                var msg=await _repository.InsertAsync(entityModel);
                await _unitOfWork.CompleteAsync();
                await trans.CommitAsync();
                return new ResponseItem<bool>
                {
                    Result = true
                };
            }
            catch (Exception ex)
            {
                _logger.LogWarning("Đã xảy ra lỗi trong quá trình xử lý", ex);
                await trans.RollbackAsync();
                return new ResponseItem<bool>
                {
                    Err = 1,
                    ResponseError = new ResponseErrorData
                    {
                        ErrorMessage = StringMessage.ErrorMessages.ProcessError,
                        ErrorType = ErrorTypeConstant.ErrorProcess
                    },
                    Result = false
                };
            }
        }


        public async Task<MsgSessionDictDto> GetDetailDocumentSent(FilterDetailMsgSessionDto filter)
        {
            var result = (await GetListDocumentSent(filter.LocalId,
                new FilterMsgExchangeDto())).Items.FirstOrDefault(c => c.Key == filter.SessionId);
            return result;

        }

        public async Task<MsgSessionDictDto> GetDetailDocumentReceive(FilterDetailMsgSessionDto filter)
        {
            var result = (await GetListDocumentReceives(filter.LocalId, 
                new FilterMsgExchangeDto())).Items.FirstOrDefault(c => c.Key == filter.SessionId);
            return result;
        }

        public async Task<IPagedList<MsgSessionDictDto>> GetListDocumentReceives(long? localId, FilterMsgExchangeDto filter)
        {
            var result = (await BuildSessionReceiveQuery(localId, filter).ToListAsync())
                        .GroupBy(c => c.MsgSession.Id)
                        .Select(c => new MsgSessionDictDto
                        {
                            Key = c.Key,
                            MsgSession = c.Select(c => new MsgSessionDto
                            {
                                MessageId = c.Message.Id,
                                MsgSessionId = c.MsgSession.Id,
                                Content = c.Message.Content,
                                CreatedBy = c.MsgSession.CreatedBy,
                                CreatedDate = c.MsgSession.CreatedDate,
                                IsDelete = c.MsgSession.IsDelete,
                                IsImportant = c.Message.IsImportant,
                                IsReply = c.Message.IsReply,
                                MessageById = c.Message.MessageById,
                                MessageDate = c.Message.CreatedDate,
                                ModifiedDate = c.MsgSession.ModifiedDate,
                                ModifiedBy = c.MsgSession.ModifiedBy,
                                Title = c.MsgSession.Title,
                                MsgReceivesPC07Name = c.MsgReceivesPC07Name,
                                LocalSendPlace = new SenderReceivePersonDto
                                {
                                    Id = c.MsgSenderPC07Id,
                                    Name = c.MsgSenderPC07Name,
                                    Session = c.MsgSession.Id
                                }
                            }).FirstOrDefault(),
                            ReplyNumber = c.Where(c => c.Message.IsReply).Select( c => c.Message.Id).Distinct().Count()
                        }).AsQueryable().ToPagedList(filter.PageIndex, filter.PageSize);
            return result;
        }
        public async Task<IPagedList<MsgSessionDictDto>> GetListDocumentSent(long? localId, FilterMsgExchangeDto filter)
        {
            var result = (await BuildSessionSenderQuery(localId, filter).ToListAsync())
                        .GroupBy(c => c.MsgSession.Id)
                        .Select(c => new MsgSessionDictDto
                        {
                            Key = c.Key,
                            MsgSession = c.Select(c => new MsgSessionDto
                            {
                                MessageId = c.Message.Id,
                                Content = c.Message.Content,
                                CreatedBy = c.MsgSession.CreatedBy,
                                CreatedDate = c.MsgSession.CreatedDate,
                                IsDelete = c.MsgSession.IsDelete,
                                IsImportant = c.Message.IsImportant,
                                IsReply = c.Message.IsReply,
                                MessageById = c.Message.Id,
                                MessageDate = c.Message.CreatedDate,
                                ModifiedDate = c.MsgSession.ModifiedDate,
                                LocalSendPlace = new SenderReceivePersonDto
                                {
                                    Id = c.MsgSenderPC07Id,
                                    Name = c.MsgSenderPC07Name,
                                    Session = c.MsgSession.Id
                                },
                                ModifiedBy = c.MsgSession.ModifiedBy,
                                Title = c.MsgSession.Title,
                                MsgReceivesPC07Name = c.MsgReceivesPC07Name,
                                MsgReceivesPC07Id = c.MsgReceivesPC07Id,
                            }).FirstOrDefault(),
                            ReceiveUserDetail = c.Select(c => new SenderReceivePersonDto
                            {
                                Id = c.MsgReceivesPC07Id,
                                Name = c.MsgReceivesPC07Name,
                                Session = c.MsgSession.Id
                            }).DistinctBy(x => x.Id).ToList(),
                            ReceiveUsers = string.Join(", ",c.Select(c => c.MsgReceivesPC07Name).Distinct()),
                            FilesAttachs = c.Select(c => new FileDetailDto
                            {
                                Id = c.DocumentUpload?.Id,
                                Path = c.DocumentUpload?.Path,
                                Session = c.MsgSession.Id,
                                Extenstion = c.DocumentUpload != null ? Path.GetExtension(c.DocumentUpload.FileName) : "",
                                FileName = c.DocumentUpload != null ? Path.GetFileName(c.DocumentUpload.FileName) : "",
                            }).DistinctBy(x => x.Id).ToList(),
                            ReplyNumber = c.Where(c => c.Message.IsReply).Select(c => c.Message.Id).Distinct().Count(),
                        }).AsQueryable().ToPagedList(filter.PageIndex, filter.PageSize);
            return result;
        }

        private IQueryable<ExchangeMsgDto> BuildSessionSenderQuery(long? localId, FilterMsgExchangeDto filter)
        {
            if (filter.PageIndex == 0) filter.PageIndex = Constant.DefaultPageIndex;
            if (filter.PageSize == 0) filter.PageSize = Constant.DefaultPageSize;
            var sessions = base._repository.GetAll().Where(c => c.SendPC07Id == localId);
            var query = from si in sessions.Include(c => c.SendPC07Local)
                        join me in _messageRepo.GetAll()
                           on si.Id equals me.MsgSessionId
                        join mgr in _msgReceiveRepo.GetAll()
                           on si.Id equals mgr.MsgSessionId
                        join mgh in _hasMsgSessionRepo.GetAll()
                           on si.Id equals mgh.MsgSessionId
                        join lo in _pc07LocalRepo.GetAll()
                           on mgr.ReceivePC07Id equals lo.Id
                        join fi in _messageHasFileRepo.GetAll()
                           on me.Id equals fi.MessageId into msdefault
                        from msfiles in msdefault.DefaultIfEmpty()
                        join doc in _documentUploadRepo.GetAll()
                           on msfiles.AttachmentId equals doc.Id into files
                        from file in files.DefaultIfEmpty()
                        where !si.IsDelete
                           && !me.IsDelete
                           && !mgh.IsDelete
                           && (string.IsNullOrEmpty(filter.Content) || me.Content == filter.Content)
                           && (string.IsNullOrEmpty(filter.Session) || me.MsgSessionId == filter.Session)
                           && (string.IsNullOrEmpty(filter.Title) || si.Title == filter.Title)
                           && (filter.ReceiveUnitId == null || !filter.ReceiveUnitId.Any() || filter.ReceiveUnitId.Contains(lo.Id))
                        orderby si.ModifiedDate descending
                        select new ExchangeMsgDto
                        {
                            MsgSession = si,
                            Message = me,
                            MsgReceives = mgr,
                            HasMsgSession = mgh,
                            MsgReceivesPC07Name = lo.Name,
                            MsgReceivesPC07Id = lo.Id,
                            MessageHasFile = msfiles,
                            MsgSenderPC07Name = si.SendPC07Local.Name,
                            MsgSenderPC07Id = si.SendPC07Local.Id,
                            DocumentUpload = new FileDetailDto
                            {
                                Id = file.Id,
                                Path = file.Path,
                                FileName = file.Name 
                            }
                        };
            return SortingForMsgExchange(filter, query);
        }

        private IQueryable<ExchangeMsgDto> BuildSessionReceiveQuery(long? localId, FilterMsgExchangeDto filter)
        {
            if (filter.PageIndex == 0) filter.PageIndex = Constant.DefaultPageIndex;
            if (filter.PageSize == 0) filter.PageSize = Constant.DefaultPageSize;
            var localPerson = _pc07LocalRepo.GetAll().Where(c => c.Id == localId);
            var query = from loc in localPerson
                        join mgr in _msgReceiveRepo.GetAll()
                           on loc.Id equals mgr.ReceivePC07Id
                        join ses in _repository.GetAll()
                           on mgr.MsgSessionId equals ses.Id
                        join mgh in _hasMsgSessionRepo.GetAll()
                           on ses.Id equals mgh.MsgSessionId
                        join me in _messageRepo.GetAll()
                           on ses.Id equals me.MsgSessionId
                        join lo in _pc07LocalRepo.GetAll()
                           on ses.SendPC07Id equals lo.Id
                        join fi in _messageHasFileRepo.GetAll()
                           on me.Id equals fi.MessageId into msdefault
                        from msfiles in msdefault.DefaultIfEmpty()
                        join doc in _documentUploadRepo.GetAll()
                           on msfiles.AttachmentId equals doc.Id into files
                        from file in files.DefaultIfEmpty()
                        where !ses.IsDelete
                           && !mgh.IsDelete
                           && !me.IsDelete
                           && (string.IsNullOrEmpty(filter.Content) || me.Content == filter.Content)
                           && (string.IsNullOrEmpty(filter.Session) || me.MsgSessionId == filter.Session)
                           && (string.IsNullOrEmpty(filter.Title) || ses.Title == filter.Title)
                           && (filter.ReceiveUnitId == null || !filter.ReceiveUnitId.Any() || filter.ReceiveUnitId.Contains(lo.Id))
                        orderby ses.ModifiedDate descending
                        select new ExchangeMsgDto
                        {
                            MsgSession = ses,
                            Message = me,
                            MsgReceives = mgr,
                            HasMsgSession = mgh,
                            MsgSenderPC07Id = lo.Id,
                            MsgSenderPC07Name = lo.Name,
                            MessageHasFile = msfiles,
                            DocumentUpload = new FileDetailDto
                            {
                                Id = file.Id,
                                Path = file.Path,
                                FileName = file.Name
                            },
                        };
            
            return SortingForMsgExchange(filter, query);
        }

        private IQueryable<ExchangeMsgDto> SortingForMsgExchange(FilterMsgExchangeDto filter, IQueryable<ExchangeMsgDto> query)
        {
            ///sorting
            var SortBy = filter.Sorting;
            if (!string.IsNullOrEmpty(SortBy))
            {
                var SortOrder = SortBy.Substring(SortBy.IndexOf(" "));
                SortBy = SortBy.Substring(0, SortBy.IndexOf(" ")).Trim();
                switch (SortBy)
                {
                    case "MsgSessionId":
                        SortBy = "MsgSession.Id " + SortOrder;
                        break;
                    case "MessageId":
                        SortBy = "Message.Id " + SortOrder;
                        break;
                    case "MessageById":
                        SortBy = "Message.MessageById " + SortOrder;
                        break;
                    default:
                        SortBy = filter.Sorting;
                        break;
                }
            }

            if (!string.IsNullOrEmpty(SortBy))
            {
                return query.Sort(SortBy);
            }
            return query;
        }

        private async Task<MsgSession> BuildEntities(CreateMsgExchange message,
            CurrentUserDto user,
            List<IFormFile> files)
        {
            var uploadFolderPath = Constant.PathName.MsgExchangeFolder;
            ///get has msg session
            var msgHasSessions = message.ReceiveUnitId.Select(
                c => new HasMsgSession()
                {
                    CreatedBy = user.Email,
                    CreatedDate = DateTime.Now,
                    PC07LocalId = c,
                    ModifiedDate = DateTime.Now
                }).ToList();

            ///get list receive person
            var receivePersons = message.ReceiveUnitId.Select(
                c => new MsgReceive()
                {
                    CreatedBy = user.Email,
                    CreatedDate = DateTime.Now,
                    ReceivePC07Id = c,
                    ModifiedDate = DateTime.Now
                }).ToList();

            var fileAttachments = await CreateMessageHasFile(files, uploadFolderPath, user.Email);

            return new MsgSession()
            {
                Id = Guid.NewGuid().ToString(),
                ModifiedDate = DateTime.Now,
                Title = message.Title,
                HasMsgSessions = msgHasSessions,
                CreatedBy = user.Email,
                CreatedDate = DateTime.Now,
                Messages = new List<Message> {
                        new Message()
                        {
                            Content = message.Content,
                            MessageDate = DateTime.Now,
                            MessageHasFile = fileAttachments,
                            ModifiedDate = DateTime.Now,
                            CreatedBy = user.Email,
                            CreatedDate = DateTime.Now
                        }
                    },
                MsgReceives = receivePersons,
            };
        }

        private async Task<List<MessageHasFile>> CreateMessageHasFile(List<IFormFile> files, string uploadFolderPath, string userName)
        {
            var fileAttachments = new List<MessageHasFile>();
            if (files.Any())
            {
                ///upload and save to database
                foreach (var file in files)
                {
                    var returnPath = await _fileService.SaveFileAsync(uploadFolderPath, file);
                    var uploadId = await _documentUploadService.UploadAndSave(file, userName, returnPath);
                    fileAttachments.Add(new MessageHasFile()
                    {
                        AttachmentId = uploadId ?? 0,
                        CreatedBy = userName,
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now
                    });
                }
            }
            return fileAttachments;
        }

        public async Task<ResponseItem<bool>> ReplyDocument(string sessionId, string message, long? localId, string userName, List<IFormFile> files)
        {
            try
            {
                ///save and upload files
                var fileAttachments = await CreateMessageHasFile(files, Constant.PathName.MsgExchangeFolder, userName);
                await _messageRepo.InsertAsync(new Message()
                {
                    MsgSessionId = sessionId,
                    Content = message,
                    MessageById = localId,
                    IsReply = true,
                    MessageDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    CreatedBy = userName,
                    MessageHasFile = fileAttachments
                });
                await _unitOfWork.CompleteAsync();
                await ReplyMail(message, sessionId, localId.Value);
                return new ResponseItem<bool>
                {
                    Result = true
                };
            }
            catch (Exception ex)
            {
                _logger.LogWarning("Đã xảy ra lỗi trong quá trình xử lý", ex);
                return new ResponseItem<bool>
                {
                    Err = 1,
                    ResponseError = new ResponseErrorData
                    {
                        ErrorMessage = StringMessage.ErrorMessages.ProcessError,
                        ErrorType = ErrorTypeConstant.ErrorProcess
                    },
                    Result = false
                };
            }

        }

        public async Task<ResponseItem<bool>> DeletePermanent(FilterDetailMsgSessionDto filter)
        {
            try
            {
                var hasSession = _hasMsgSessionRepo.GetAll().FirstOrDefault(c => c.MsgSessionId == filter.SessionId && c.PC07LocalId == filter.LocalId);
                if (hasSession == null)
                {
                    return new ResponseItem<bool>
                    {
                        Err = 1,
                        ResponseError = new ResponseErrorData
                        {
                            ErrorMessage = StringMessage.ErrorMessages.HasSessionInvalid,
                            ErrorType = ErrorTypeConstant.ErrorProcess
                        },
                        Result = false
                    };
                }
                _hasMsgSessionRepo.Delete(hasSession);
                await _unitOfWork.CompleteAsync();
                _logger.LogInformation($"Xóa thành công MsgSessionId = {filter.SessionId}, PC07LocalId = {filter.LocalId}");
                return new ResponseItem<bool>
                {
                    Result = true
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(StringMessage.ErrorMessages.ProcessError, ex);
                return new ResponseItem<bool>
                {
                    Result = false,
                    Err = 1,
                    ResponseError = new ResponseErrorData
                    {
                        ErrorMessage = StringMessage.ErrorMessages.ProcessError,
                        ErrorType = ErrorTypeConstant.InvalidRequest
                    },
                };
            }

        }

        public async Task<ResponseItem<bool>> Delete(FilterDetailMsgSessionDto filter, string userName)
        {
            try
            {
                var hasSession = _hasMsgSessionRepo.GetAll().FirstOrDefault(c => c.MsgSessionId == filter.SessionId && c.PC07LocalId == filter.LocalId);
                if (hasSession == null)
                {
                    return new ResponseItem<bool>
                    {
                        Err = 1,
                        ResponseError = new ResponseErrorData
                        {
                            ErrorMessage = StringMessage.ErrorMessages.HasSessionInvalid,
                            ErrorType = ErrorTypeConstant.ErrorProcess
                        },
                        Result = false
                    };
                }
                hasSession.IsDelete = true;
                hasSession.ModifiedBy = string.IsNullOrEmpty(userName) ? "Administator" : userName;
                hasSession.ModifiedDate = DateTime.Now;
                _hasMsgSessionRepo.Update(hasSession);
                await _unitOfWork.CompleteAsync();
                _logger.LogInformation($"Xóa thành công MsgSessionId = {filter.SessionId}, PC07LocalId = {filter.LocalId}");
                return new ResponseItem<bool>
                {
                    Result = true
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(StringMessage.ErrorMessages.ProcessError, ex);
                return new ResponseItem<bool>
                {
                    Result = false,
                    Err = 1,
                    ResponseError = new ResponseErrorData
                    {
                        ErrorMessage = StringMessage.ErrorMessages.ProcessError,
                        ErrorType = ErrorTypeConstant.InvalidRequest
                    },
                };
            }
        }

        public async Task<ResponseItem<bool>> TakeBackMessageReply(long? id, string userName)
        {
            try
            {
                if (!id.HasValue)
                {
                    return new ResponseItem<bool>
                    {
                        Err = 1,
                        ResponseError = new ResponseErrorData
                        {
                            ErrorMessage = StringMessage.ErrorMessages.MessageInvalid,
                            ErrorType = ErrorTypeConstant.ErrorProcess
                        },
                        Result = false
                    };
                }

                var message = _messageRepo.GetAll().FirstOrDefault(c => c.Id == id);
                if (message == null)
                {
                    return new ResponseItem<bool>
                    {
                        Err = 1,
                        ResponseError = new ResponseErrorData
                        {
                            ErrorMessage = StringMessage.ErrorMessages.MessageInvalid,
                            ErrorType = ErrorTypeConstant.ErrorProcess
                        },
                        Result = false
                    };
                }
                message.IsDelete = true;
                message.ModifiedBy = string.IsNullOrEmpty(userName) ? "Administator" : userName;
                message.ModifiedDate = DateTime.Now;
                _messageRepo.Update(message);
                await _unitOfWork.CompleteAsync();
                _logger.LogInformation($"Xóa thành công MsgSessionId = {message.MsgSessionId}, MessageById = {message.MessageById}");
                return new ResponseItem<bool>
                {
                    Result = true
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(StringMessage.ErrorMessages.ProcessError, ex);
                return new ResponseItem<bool>
                {
                    Result = false,
                    Err = 1,
                    ResponseError = new ResponseErrorData
                    {
                        ErrorMessage = StringMessage.ErrorMessages.ProcessError,
                        ErrorType = ErrorTypeConstant.InvalidRequest
                    },
                };
            }
        }

        public async Task<ResponseItem<bool>> TakeBackMessageSent(string session, string userName)
        {
            try
            {
                if (string.IsNullOrEmpty(session))
                {
                    return new ResponseItem<bool>
                    {
                        Err = 1,
                        ResponseError = new ResponseErrorData
                        {
                            ErrorMessage = StringMessage.ErrorMessages.MessageInvalid,
                            ErrorType = ErrorTypeConstant.ErrorProcess
                        },
                        Result = false
                    };
                }

                var message = _repository.GetAll().FirstOrDefault(c => c.Id == session);
                if (message == null)
                {
                    return new ResponseItem<bool>
                    {
                        Err = 1,
                        ResponseError = new ResponseErrorData
                        {
                            ErrorMessage = StringMessage.ErrorMessages.MessageInvalid,
                            ErrorType = ErrorTypeConstant.ErrorProcess
                        },
                        Result = false
                    };
                }
                message.IsDelete = true;
                message.ModifiedBy = string.IsNullOrEmpty(userName) ? "Administator" : userName;
                message.ModifiedDate = DateTime.Now;
                _repository.Update(message);
                await _unitOfWork.CompleteAsync();
                return new ResponseItem<bool>
                {
                    Result = true
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(StringMessage.ErrorMessages.ProcessError, ex);
                return new ResponseItem<bool>
                {
                    Result = false,
                    Err = 1,
                    ResponseError = new ResponseErrorData
                    {
                        ErrorMessage = StringMessage.ErrorMessages.ProcessError,
                        ErrorType = ErrorTypeConstant.InvalidRequest
                    },
                };
            }
        }

        public async Task<ResponseItem<List<MessageDto>>> GetListReply(string session)
        {
            if (session == null)
            {
                return new ResponseItem<List<MessageDto>>
                {
                    Err = 1,
                    ResponseError = new ResponseErrorData
                    {
                        ErrorMessage = StringMessage.ErrorMessages.HasSessionInvalid,
                        ErrorType = ErrorTypeConstant.ErrorProcess
                    },
                    Result = null
                };
            }
            ///get list message reply
            var messages = await (from mes in _messageRepo.GetAll().Where(c => !c.IsDelete && c.MsgSessionId == session && c.IsReply)
                                  join mha in _messageHasFileRepo.GetAll()
                                       on mes.Id equals mha.MessageId into lfmsg
                                       from msg in lfmsg.DefaultIfEmpty()
                                  join fi in _documentUploadRepo.GetAll()
                                       on msg.AttachmentId equals fi.Id into lffile
                                       from file in lffile.DefaultIfEmpty()
                                  join loc in _pc07LocalRepo.GetAll()
                                       on mes.MessageById equals loc.Id into lfmes
                                       from lfme in lfmes.DefaultIfEmpty()
                                  select new
                                  {
                                      Message = mes,
                                      MessageHasFile = msg,
                                      Files = file,
                                      PClocal = lfme
                                  }).ToListAsync();
            if (messages == null)
            {
                return new ResponseItem<List<MessageDto>>
                {
                    Err = 1,
                    ResponseError = new ResponseErrorData
                    {
                        ErrorMessage = StringMessage.ErrorMessages.HasSessionInvalid,
                        ErrorType = ErrorTypeConstant.ErrorProcess
                    },
                    Result = null
                };
            }
            var result = messages.GroupBy(c => c.Message.Id)
                .Select(c => new MessageDto
                {
                    MessageId = c.Key,
                    MessageDetail = c.Select(c => new MessageDetailDto
                    {
                        Content = c.Message.Content,
                        MessageById = c.Message.MessageById,
                        MsgSessionId = c.Message.MsgSessionId,
                        IsImportant = c.Message.IsImportant,
                        IsReply = c.Message.IsReply,
                        MessageDate = c.Message.MessageDate,
                        PcLocalReply = new SenderReceivePersonDto
                        {
                            Id = c.PClocal.Id,
                            Name = c.PClocal.Name,
                            Session = c.Message.MsgSessionId
                        }
                    }).FirstOrDefault(),
                    FilesAttachs = c.Select(c => new FileDetailDto
                    {
                        Id = c.Files?.Id,
                        Path = c.Files?.Path,
                        FileName = c.Files?.Name != null ? Path.GetFileName(c.Files?.Name) : "",
                        Extenstion = c.Files?.Name != null ? Path.GetExtension(c.Files?.Name) : "",
                        Session = c.Message.MsgSessionId
                    })?.DistinctBy(c => c.Id)?.ToList()
                }).ToList();

            return new ResponseItem<List<MessageDto>>
            {
                Result = result
            };
        }

        private async Task SendMail(string title, string content,string msgSessionId, long pc07SendId, ICollection<long> pc07ReceiveIds)
        {
            var listPc07 = _pc07LocalRepo.GetAll().Where(x => pc07ReceiveIds.Contains(x.Id) || x.Id==pc07SendId).ToList();
            var returnMessage = string.Empty;
            var sendFromPc07 = listPc07.FirstOrDefault(x => x.Id == pc07SendId);
            if (sendFromPc07 == null) return;
            var viewMessageUrl = string.Format( _appSettings.ViewMessageUrl, msgSessionId);

            var emailTemplate = _emailTemplateService.GetEmailTemplateByCode(Constant.EmailTemplate.SendMessage);
            var contentMail = emailTemplate.Description.Replace("${SendFrom}", sendFromPc07.Name)
                .Replace("${Content}", content)
                .Replace("${Title}", title)
                .Replace("${MessageLink}", viewMessageUrl);

            foreach (var item in listPc07.Where(x=>x.Id!=pc07SendId))
            {
                if (string.IsNullOrEmpty(item.Email)) continue;
                foreach (var emailTo in item.Email.Split(";"))
                {
                    if (string.IsNullOrEmpty(emailTo)) continue;
                    await _sendMailService.SendToEmailAsync(emailTo, null, title, contentMail, ref returnMessage);
                }
            }
        }

        private async Task ReplyMail(string content, string msgSessionId, long pc07ReplyId)
        {
            var msgSession = _repository.GetById(msgSessionId);
            if (msgSession == null) return;
            var title = msgSession.Title;

            var listPc07 = _pc07LocalRepo.GetAll().Where(x => x.Id==pc07ReplyId || x.Id == msgSession.SendPC07Id).ToList();
            //if (listPc07.Count != 2) return;

            var returnMessage = string.Empty;
            var replyFromPc07 = listPc07.FirstOrDefault(x => x.Id == pc07ReplyId);
            if (replyFromPc07 == null) return;

            var receivePc07 = listPc07.FirstOrDefault(x => x.Id == msgSession.SendPC07Id);
            if (receivePc07 == null) return;

            var viewMessageUrl = string.Format(_appSettings.ViewMessageUrl, msgSessionId).Replace("is_receive", "is_sent=true");
            var emailTemplate = _emailTemplateService.GetEmailTemplateByCode(Constant.EmailTemplate.SendMessage);
            var contentMail = emailTemplate.Description.Replace("${SendFrom}", replyFromPc07.Name)
                .Replace("${Content}", content)
                .Replace("${Title}", title)
                .Replace("${MessageLink}", viewMessageUrl);

            if (string.IsNullOrEmpty(receivePc07.Email)) return;
            var listEmail = receivePc07.Email.Split(";");
            foreach (var item in listEmail)
            {
                if (string.IsNullOrEmpty(item)) continue;
                await _sendMailService.SendToEmailAsync(item, null, title, contentMail, ref returnMessage);
            }
        }
    }
}
