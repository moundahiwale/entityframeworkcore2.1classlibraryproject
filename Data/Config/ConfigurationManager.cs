using System.IO;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;

namespace Data.Config
{
    public class ConfigurationManager
    {
        public static IConfiguration Configuration { get; }
        static ConfigurationManager()
        {
            var launchSettings = JObject.Parse(File.ReadAllText(
                Path.Combine(Path.GetDirectoryName(Directory.GetCurrentDirectory()), "API", "Properties", "launchSettings.json")));
            var environment = launchSettings["profiles"]["API"]["environmentVariables"]["ASPNETCORE_ENVIRONMENT"];
            Configuration = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Path.GetDirectoryName(Directory.GetCurrentDirectory()), "API"))
            .AddJsonFile("appsettings.json")
            .AddJsonFile($"appsettings.{environment}.json", optional: true)
            .Build();
        }
    }
}