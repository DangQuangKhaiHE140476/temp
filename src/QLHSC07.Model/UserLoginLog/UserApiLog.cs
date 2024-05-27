using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Model.UserLoginLog
{
    public class UserApiLog
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string ApiName { get; set; }
        public string IpAddress { get; set; }
        public string CreateDate { get; set; }
    }
}
