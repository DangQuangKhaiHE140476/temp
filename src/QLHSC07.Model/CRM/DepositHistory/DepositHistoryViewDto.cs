using QLHSC07.Model.BaseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Model.CRM.DepositHistory
{
    public class DepositHistoryViewDto : FullAuditedEntityDto<long>
    {
        public long ClientId { get; set; }
        public string ClientName { get; set; }
        public double DepositAmount { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Status { set; get; }
    }
}
