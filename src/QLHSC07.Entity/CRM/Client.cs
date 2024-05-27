using QLHSC07.Entity.IdentityAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QLHSC07.Entity.CRM
{
    public class Client : BaseFullAuditedEntity<long>
    {
        public string Name { set; get; }
        public string Email { set; get; }
        public string PhoneNumber { set; get; }
        public double TotalMoney { set; get; }
        public string UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public virtual User User { get; set; }

        public int[] ProvinceIds { set; get; } //list province Id
        public string Description { set; get; }
        public bool IsActive { set; get; }
        public bool IsConfirm { set; get; }
        public int[] ClientType { set; get;}
        public string UserName { set; get; }
        public string Password { set; get; }

    }
}
