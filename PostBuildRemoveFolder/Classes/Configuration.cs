using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PostBuildRemoveFolder.Classes
{
    public class Configuration : BaseExceptionsHandler
    {
        /// <summary>
        /// Configuration file which resides in the executable folder.
        /// </summary>
        public string FileName => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, 
            "Configuration", 
            "applications.json");

        /// <summary>
        /// Read application settings from configuration file above.
        /// </summary>
        public ApplicationSettings Settings { get; set; }

        public Configuration()
        {
            try
            {
                using (var sr = new StreamReader(FileName))
                {
                    var json = sr.ReadToEnd();
                    Settings = JsonConvert
                        .DeserializeObject<List<ApplicationSettings>>(json)
                        .ToList()
                        .FirstOrDefault();
                }
            }
            catch (Exception e)
            {
                mHasException = true;
                mLastException = e;
            }
        }
        public void Update(ApplicationSettings pApplicationSettings)
        {
            File.WriteAllText(FileName, $"[{JsonConvert.SerializeObject(pApplicationSettings)}]");
        }
    }
}
