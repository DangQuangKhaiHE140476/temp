using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Entity.CRM
{
    public class Plan : BaseFullAuditedEntity<long>
    {
        public string Name { get; set; }    
        public double Price { get; set; }
        public int PromotionConditions { set; get; }    
        public int Promotion { set; get; }  
        public DateTime EndDate { get; set; }
        public string Info { set; get; }
        public bool IsShow { set; get; }    

    }
}
