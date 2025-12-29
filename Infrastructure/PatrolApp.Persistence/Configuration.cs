using Microsoft.Extensions.Configuration;

namespace PatrolApp.Persistence
{
    static class Configuration
    {
        static public string ConnectionString
        {
            get
            {
                ConfigurationManager configurationManager = new();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/PatrolApp.API"));
                configurationManager.AddJsonFile("appsettings.json");
                return configurationManager.GetConnectionString("MSSQL");

            }
        }
    }
}

// ConfigurationManager kullanabilmek icin Microsoft.Extensions.Configuration kutuphanesinin indiilemei gerrekiuor. 
// JSON dosyasinin  okuyabilmek icin ise Microsoft.Extensions.Configuration.Json kutuphanesinin indirilmesi gerekiuor. 