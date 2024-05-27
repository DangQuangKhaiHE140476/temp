namespace QLHSC07.Authentication.Configuration
{
    public class AuthenticationSettings
    {
        public string Secret { get; set; }
        public string[] AllowedAuthOrigins { get; set; }
    }
}
