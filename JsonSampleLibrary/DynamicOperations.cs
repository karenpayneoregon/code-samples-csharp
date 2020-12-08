using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JsonSampleLibrary.Classes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JsonSampleLibrary
{
    public class DynamicOperations
    {
        public static void ReadOrders1(string fileName)
        {
            var jsonString = File.ReadAllText(fileName);
            var objects = JsonConvert.DeserializeObject<dynamic>(jsonString);
            foreach (var o in objects)
            {
                JValue id = o.id;
                Console.WriteLine($"{id.Type}");
            }
        }
        public static void ReadOrders1A(string fileName)
        {
            var jsonString = File.ReadAllText(fileName);
            var objects = JsonConvert.DeserializeObject<dynamic>(jsonString);
            List<int> identifiers = new List<int>();
            foreach (var o in objects)
            {
                identifiers.Add(Convert.ToInt32(o.id));
            }
        }

        public static List<Order> ReadOrdersStrongTyped(string fileName)
        {
            return JsonConvert.DeserializeObject<List<Order>>(File.ReadAllText(fileName));
        }
    }
}
