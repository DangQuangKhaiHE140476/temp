using QLHSC07.Entity.IdentityAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QLHSC07.Entity.CRM
{
     public class Order : BaseFullAuditedEntity<long>
    {
        public DateTime StartDate { set; get; }
        public DateTime EndDate { set; get; }
        public long Month { set; get; }
        public int DiscountType { set; get; } = 0; //0 là thường; 1 là phần trăm
        public double Discount { set; get; } = 0; //0 là thường; 1 là phần trăm
        public string Note { set; get; }
        public long PlanId { set; get; }
        [ForeignKey(nameof(PlanId))]
        public virtual Plan Plan { get; set; }
        public long ClientId { get; set; }
        [ForeignKey(nameof(ClientId))]
        public virtual Client Client { get; set; }
        public string UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public virtual User User { get; set; }
    }
}
