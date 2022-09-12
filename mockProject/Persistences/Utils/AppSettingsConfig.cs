namespace mockProject.Persistences.Utils
{
    public static class AppSettingsConfig
    {
        private static IConfiguration _configuration { get; set; }
        public static IConfiguration Configuration
        {
            get
            {
                if (_configuration == null)
                {

                    var builder = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.Development.json", optional: true);

                    _configuration = builder.Build();
                }

                return _configuration;
            }
        }
    }
}
