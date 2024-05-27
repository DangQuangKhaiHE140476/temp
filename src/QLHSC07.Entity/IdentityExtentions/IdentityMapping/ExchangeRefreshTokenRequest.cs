using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Entity.IdentityExtentions.IdentityMapping
{
    public class ExchangeRefreshTokenRequest
    {
        public string ReturnUrl { get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
    }
}
