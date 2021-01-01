using System.Configuration;
using System.IO;
using System.Reflection;

namespace SingletonExample1.Classes
{
    public class ApplicationSettings
    {
        public static string GetDatabasePath() => GetSettingAsString("DatabasePath");
        public static void SetDatabasePath(string value) => SetValue("DatabasePath", value);

        public static string GetSettingAsString(string configKey) => ConfigurationManager.AppSettings[configKey];
        public static void SetValue(string key, string value)
        {
            var applicationDirectoryName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var configFile = Path.Combine(
                applicationDirectoryName, $"{Assembly.GetExecutingAssembly().GetName().Name}.exe.config");
            var configFileMap = new ExeConfigurationFileMap { ExeConfigFilename = configFile };
            var config = ConfigurationManager.OpenMappedExeConfiguration(configFileMap, 
                ConfigurationUserLevel.None);

            config.AppSettings.Settings[key].Value = value;
            config.Save();

            Reload();

        }
        public static void Reload()
        {
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
