using System;
using QLHSC07.Entity.LogHistory;
using QLHSC07.Infrastructure.Interface;
using QLHSC07.Model.LogHistory;
using QLHSC07.Model.User;

namespace QLHSC07.Services.Interfaces
{
    public interface ILogHistoryService
    {
        bool Create(LogHistoryDto logHistoryModel, CurrentUserDto currentUserModel);
        IPagedList<LogHistoryViewDto> GetAllLogHistory(int pageIndex, int pageSize, string sortExpression, int action, string userName, string description, DateTime? createDate);
        bool UpdateLogHistory(LogHistoryDto logHistoryModel, CurrentUserDto currentUserModel);
        bool DeleteLogHistoryById(int idLogHistory);
        LogHistoryEntity GetLogHistoryById(int id);
    }
}
