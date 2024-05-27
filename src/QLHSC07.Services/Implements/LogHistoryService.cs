using AutoMapper;
using Microsoft.Extensions.Logging;
using QLHSC07.CORE.Enum;
using QLHSC07.CORE.Extensions;
using QLHSC07.Data.Interfaces;
using QLHSC07.Data.Repository;
using QLHSC07.Entity.LogHistory;
using QLHSC07.Infrastructure.Implements;
using QLHSC07.Infrastructure.Interface;
using QLHSC07.Model.LogHistory;
using QLHSC07.Model.User;
using QLHSC07.Services.Interfaces;
using System;
using System.Linq;

namespace QLHSC07.Services.Implements
{
    public class LogHistoryService : ILogHistoryService
    {
        private readonly ILogHistoryRepository _logHistoryRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<LogHistoryService> _logger;

        public LogHistoryService(ILogHistoryRepository logHistoryRepository, IMapper mapper, IUnitOfWork unitOfWork, ILogger<LogHistoryService> logger)
        {
            _logHistoryRepository = logHistoryRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public bool Create(LogHistoryDto logHistoryModel, CurrentUserDto currentUserModel)
        {
            using var dbTransaction = _unitOfWork.BeginTransaction();
            try
            {
                LogHistoryEntity logHistoryEntity = _mapper.Map<LogHistoryEntity>(logHistoryModel);
                logHistoryEntity.CreatedDate = DateTime.Now;
                logHistoryEntity.ModifiedDate = DateTime.Now;
                logHistoryEntity.CreatedBy = currentUserModel.UserName;
                logHistoryEntity.ModifiedBy = currentUserModel.UserName;
                _logHistoryRepository.Insert(logHistoryEntity);
                _unitOfWork.Complete();
                dbTransaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);
                return false;
            }
        }

        public IPagedList<LogHistoryViewDto> GetAllLogHistory(int pageIndex, int pageSize, string sortExpression, int action,
            string userName, string description, DateTime? createDate)
        {
            try
            {
                var logHistories = _logHistoryRepository.Query(x => x.Id > 0).AsQueryable();
                if (action != 0)
                {
                    logHistories = logHistories.Where(x => x.Action == action);
                }
                if (!string.IsNullOrEmpty(userName))
                {
                    logHistories = logHistories.Where(x => x.UserName.ToLower().Contains(userName.ToLower()));
                }
                if (!string.IsNullOrEmpty(description))
                {
                    logHistories = logHistories.Where(x => x.Description.ToLower().Contains(description.ToLower()));
                }

                if (!createDate.Equals(null))
                {
                    logHistories = logHistories.Where(x => x.CreatedDate >= createDate && x.CreatedDate <= (createDate.Value.AddDays(1).Date));
                }

                return (IPagedList<LogHistoryViewDto>)logHistories.Select(x => new LogHistoryViewDto()
                {
                    Id = x.Id,
                    Action = x.Action,
                    ActionName = GetActionName(x.Action),
                    UserName = x.UserName,
                    Description = x.Description,
                    CreatedBy = x.CreatedBy,
                    CreatedDate = x.CreatedDate,
                    ModifiedBy = x.ModifiedBy,
                    ModifiedDate = x.ModifiedDate
                }).Sort(sortExpression).ToPagedList(pageIndex, pageSize);
            }
            catch (Exception e)
            {
                _logger.LogError($"{e}");
                return null;
            }
        }

        public bool UpdateLogHistory(LogHistoryDto logHistoryModel, CurrentUserDto currentUserModel)
        {
            using var dbTransaction = _unitOfWork.BeginTransaction();
            try
            {
                LogHistoryEntity logHistoryEntity = GetLogHistoryById(logHistoryModel.Id);
                if (logHistoryEntity == null)
                {
                    return false;
                }
                logHistoryEntity.UserName = logHistoryModel.UserName;
                logHistoryEntity.Action = logHistoryModel.Action;
                logHistoryEntity.Description = logHistoryModel.Description;
                logHistoryEntity.ModifiedDate = DateTime.Now;
                logHistoryEntity.ModifiedBy = currentUserModel.UserName;
                _logHistoryRepository.Update(logHistoryEntity);
                _unitOfWork.Complete();
                dbTransaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);
                return false;
            }
        }

        public bool DeleteLogHistoryById(int idLogHistory)
        {
            using var dbTransaction = _unitOfWork.BeginTransaction();
            try
            {
                LogHistoryEntity logHistoryEntity = GetLogHistoryById(idLogHistory);
                if (logHistoryEntity == null)
                {
                    return false;
                }
                bool isDelete = _logHistoryRepository.Delete(logHistoryEntity);
                _unitOfWork.Complete();
                dbTransaction.Commit();
                return isDelete;
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);
                return false;
            }
        }

        public LogHistoryEntity GetLogHistoryById(int id)
        {
            return _logHistoryRepository.Query(x => x.Id == id).FirstOrDefault();
        }

        public static string GetActionName(int id)
        {
            foreach (var value in Enum.GetValues(typeof(ActionEnum)))
            {
                if (value.GetHashCode() == id) return value.ToString();
            }
            return "";
        }
    }
}
