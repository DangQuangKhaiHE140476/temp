using Microsoft.AspNetCore.Mvc;
using QLHSC07.ApiGateway.Service.Worker;
using QLHSC07.Model.LogHistory;
using QLHSC07.Model.User;
using QLHSC07.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLHSC07.ApiGateway.Controllers
{
    public class QLHSBaseController : ControllerBase
    {
        private readonly ILogHistoryService _logHistoryService;
        private readonly IWorkerService _workerService;

        public QLHSBaseController(ILogHistoryService logHistoryService, IWorkerService workerService)
        {
            _logHistoryService = logHistoryService;
            _workerService = workerService;
        }

        protected void CreateLogHistory(int action, string description)
        {
            CurrentUserDto currentUserModel = _workerService.GetCurrentUser();
            if (currentUserModel == null) return;
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
