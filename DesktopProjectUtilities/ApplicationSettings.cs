using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ExceptionHandling;

namespace DesktopProjectUtilities
{
    /// <summary>
    /// Methods to handle reading application settings rather than using project -> settings
    /// </summary>
    public class ApplicationSettings
    {
        /// <summary>
        /// Set a app setting key value
        /// </summary>
        /// <param name="key">Key in app setting</param>
        /// <param name="value">Value for key</param>
        public static void SetValue(string key, string value)
        {
            try
            {
                var applicationDirectoryName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                // ReSharper disable once AssignNullToNotNullAttribute
                var configFile = Path.Combine(applicationDirectoryName, $"{Assembly.GetExecutingAssembly().GetName().Name}.exe.config");
                var configFileMap = new ExeConfigurationFileMap { ExeConfigFilename = configFile };
                var config = ConfigurationManager.OpenMappedExeConfiguration(configFileMap, ConfigurationUserLevel.None);

                config.AppSettings.Settings[key].Value = value;
                config.Save();

                Reload();

            }
            catch (Exception e)
            {
                Exceptions.Write(e);
            }
        }
        /// <summary>
        /// Must be called whenever values are changed as .NET only reads app settings once per session 
        /// </summary>
        public static void Reload()
        {
            ConfigurationManager.RefreshSection("appSettings");
        }
        /// <summary>
        /// Start fresh reading settings
        /// </summary>
        public static void Fetch()
        {
            Reload();
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }
    }
}
