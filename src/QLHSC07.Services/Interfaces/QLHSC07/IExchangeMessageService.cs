using Microsoft.AspNetCore.Http;
using QLHSC07.CORE;
using QLHSC07.Entity.QLHSC07_MSG_Entities;
using QLHSC07.Infrastructure.Interface;
using QLHSC07.Model.QLHSC07_Dtos.MsgExchange;
using QLHSC07.Model.QLHSC07_Dtos.MsgExchangeService;
using QLHSC07.Model.User;
using QLHSC07.Services.BaseServices;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace QLHSC07.Services.Interfaces.QLHSC07
{
    public interface IMsgExchangeService : IBaseService<string, MsgSession, MsgSessionDto, MsgSessionDto, CreateMsgExchange, UpdateMsgExchangeDto, FilterMsgExchangeDto>
    {
        Task<MsgSessionDictDto> GetDetailDocumentSent(FilterDetailMsgSessionDto filter);
        Task<MsgSessionDictDto> GetDetailDocumentReceive(FilterDetailMsgSessionDto filter);
        Task<IPagedList<MsgSessionDictDto>> GetListDocumentReceives(long? localId, FilterMsgExchangeDto filter);
        Task<IPagedList<MsgSessionDictDto>> GetListDocumentSent(long? localId, FilterMsgExchangeDto filter);
        Task<ResponseItem<bool>> ReplyDocument(string sessionId, string message, long? localId, string userName, List<IFormFile> files);
        Task<ResponseItem<bool>> SendDocuments(CreateMsgExchange messages, CurrentUserDto user, List<IFormFile> files);
        Task<ResponseItem<bool>> Delete(FilterDetailMsgSessionDto filter, string userName);
        Task<ResponseItem<bool>> DeletePermanent(FilterDetailMsgSessionDto filter);
        Task<ResponseItem<bool>> TakeBackMessageReply(long? id, string userName);
        Task<ResponseItem<List<MessageDto>>> GetListReply(string session);
        Task<ResponseItem<bool>> TakeBackMessageSent(string session, string userName);
    }
}
