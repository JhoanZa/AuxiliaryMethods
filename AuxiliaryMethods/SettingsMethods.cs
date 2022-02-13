using Microsoft.Extensions.Configuration;
using System.IO;

namespace AuxiliaryMethods
{
    /// <summary>
    ///    this class provides access methods for configuration files
    /// </summary> 
    internal class SettingsMethods
    {
        /// <summary>
        ///     This method return the values content in the file of configuration .Json
        /// </summary>
        /// <param name="section">section name</param>
        /// <param name="setting">setting name</param>
        /// <param name="fileJson">file name .json</param>
        /// <returns>configuration parameter content</returns>
        public static string GetSettingsJson(string section, string setting, string fileJson = "appsettings.json")
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(fileJson, optional: true, reloadOnChange: true);
            IConfiguration configuration = builder.Build();

            return configuration.GetSection(section).GetValue(setting, "0");
        }

    }
}
