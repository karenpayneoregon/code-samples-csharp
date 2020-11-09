using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace SerializeXmlWithMultipleLines
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileName = "person.xml";

            var person = new Person() {FirstName = "Karen", Lastname = "Payne", Comments = "Line 1\nline2\nline3"};
            var ws = new XmlWriterSettings {NewLineHandling = NewLineHandling.Entitize};

            var serializer = new XmlSerializer(typeof(Person));
            using (XmlWriter xmlWriter = XmlWriter.Create(fileName, ws))
            {
                serializer.Serialize(xmlWriter, person);
            }

            var person1 = DeserializeXMLFileToObject<Person>(fileName);
            Console.WriteLine(person1.Comments);
            Console.ReadLine();
        }
        public static T DeserializeXMLFileToObject<T>(string xmlFilename)
        {

            T returnObject = default(T);

            if (string.IsNullOrEmpty(xmlFilename)) return default(T);

            try
            {
                var xmlStream = new StreamReader(xmlFilename);
                var serializer = new XmlSerializer(typeof(T));
                returnObject = (T)serializer.Deserialize(xmlStream);
            }
            catch (Exception ex)
            {
                Console.WriteLine();
            }
            return returnObject;
        }
    }
}
