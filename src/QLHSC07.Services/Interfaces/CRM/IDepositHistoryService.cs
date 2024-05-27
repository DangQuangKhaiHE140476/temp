using QLHSC07.Entity.CRM;
using QLHSC07.Model.CRM.DepositHistory;
using QLHSC07.Services.BaseServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Services.Interfaces.CRM
{
    public interface IDepositHistoryService : IBaseService<long, DepositHistory, DepositHistoryViewDto, DepositHistoryViewDto, CreateDepositHistoryDto, UpdateDepositHistoryDto, FilterDepositHistoryDto>
    {
    }
}
