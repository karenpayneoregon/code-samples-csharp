using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PersonalData.Classes
{
    public class JsonOperations
    {
        public static UpperLevel Read()
        {
            var fileName = "personal.json";
            if (!File.Exists(fileName)) return null;
            var settings = new JsonSerializerSettings { ContractResolver = new ContractCustomResolver() };
            var json = File.ReadAllText(fileName);
            return JsonConvert.DeserializeObject<UpperLevel>(json, settings);

        }
    }
}
