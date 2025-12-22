using Microsoft.Extensions.Configuration;

namespace CloudSuiteToETSTransfer
{
    public static class AppSettingsUtil
    {
        public static string GetConnectionString(string key)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();
            //return config[key];
           return config.GetConnectionString(key);
        }
        public static string? GetKey(string section, string key)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();
            //return config[key];
            return config.GetSection(section)[key];
        }
    }
}
