using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Model.CRM.DepositHistory
{
    public class FilterDepositHistoryDto : PagedAndSortResultRequestDto
    {
        public string Name { get; set; }
        public long? ClientId { get; set; }
        public string UserId { get; set; }
    }
}
