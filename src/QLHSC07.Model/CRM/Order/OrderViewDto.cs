using QLHSC07.Model.BaseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Model.CRM.Order
{
    public class OrderViewDto : FullAuditedEntityDto<long>
    {
        public DateTime StartDate { set; get; }
        public DateTime EndDate { set; get; }
        public long Month { set; get; }
        public int DiscountType { set; get; } = 0; //0 là thường; 1 là phần trăm
        public double Discount { set; get; } = 0; //0 là thường; 1 là phần trăm
        public string Note { set; get; }
        public long PlanId { set; get; } 
        public string PlanName { set; get; }
        public long ClientId { get; set; }
        public string ClientName { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
    }
}
