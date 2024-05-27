using QLHSC07.Model.BaseModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QLHSC07.Model.CRM.DepositHistory
{
    public class CreateDepositHistoryDto : BaseCreateDto
    {
        public long ClientId { get; set; }
        public double DepositAmount { get; set; }
        public string UserId { get; set; }
        public string Status { set; get; }
    }
}
