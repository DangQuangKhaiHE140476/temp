using QLHSC07.CORE.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QLHSC07.Entity.IdentityExtentions
{
    [Table(TableFieldNameHelper.IdentityExtentions.AspNetRefreshTokens, Schema = Constant.Schema.AUTHENTICATION)]
    public class AspNetRefreshTokens : BaseFullAuditedEntity<int>
    {
        public string UserName { get; set; }
        public string Token { get; set; }
        public DateTime Expires { get; set; }
        public string RemoteIpAddress { get; set; }
        public bool Active => DateTime.Now <= Expires;
    }

}
