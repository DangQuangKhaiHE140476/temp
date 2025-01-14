﻿namespace QLHSC07.CORE.Settings
{
    public class AppSettings
    {
        public int AccessTokenExpireTimeSpan { get; set; }
        public int TokenExpirationInMinute { get; set; }
        public int MinimumRequiredLength { get; set; }
        public string BaseUrl { get; set; }
        public int DefaultPageSize { get; set; }
        public string UrlLogin { get; set; }
        public string PgVersion { get; set; }
        public string ResetPasswordUrl { get; set; }
        public string ViewMessageUrl { get; set; }
    }
}
