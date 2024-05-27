using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Model.IdentityAccess
{
    public class ExternalLoginInfor
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ExternalLoginId { get; set; }
        public string ImageUrl { get; set; }
        public string FullName { get; set; }
        /// <summary>
        /// Google, Facebook or other external login
        /// </summary>
        public string LoginProvider { get; set; }
        public string UrlReturn { get; set; }
    }
}
