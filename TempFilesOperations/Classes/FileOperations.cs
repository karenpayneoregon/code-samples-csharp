using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace TempFilesOperations.Classes
{
    public class FileOperations
    {
        public static FileStream _creator1;
        private static string _customerXmlFileName = "Customers.xml";

        public static FileStream InitializeFileStream()
        {

            _creator1 = new FileStream(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"{Guid.NewGuid()}.kp"), FileMode.Create, 
                System.Security.AccessControl.FileSystemRights.Modify, 
                FileShare.None, 8, FileOptions.DeleteOnClose);

            File.SetAttributes(_creator1.Name, File.GetAttributes(_creator1.Name) | 
                                               FileAttributes.Temporary);

            return _creator1;

        }

        public static List<Customer> ReadCustomersFromXml()
        {

            var customers = new List<Customer>();

            if (!File.Exists(_customerXmlFileName))
            {
                return customers;
            }

            var data = File.ReadAllText(_customerXmlFileName);
            var byteArray = Encoding.ASCII.GetBytes(data);
            _creator1.Write(byteArray, 0, byteArray.Length);
            _creator1.Position = 0;

            var reader = new StreamReader(_creator1);
            var deserializer = new XmlSerializer(typeof(List<Customer>),
                new XmlRootAttribute("customer_list"));

            return (List<Customer>)deserializer.Deserialize(reader);
        }
        /// <summary>
        /// Used to write changes back to the original file.
        /// </summary>
        /// <param name="customers"></param>
        public static void WriteXml(List<Customer> customers)
        {
            using (var writer = new FileStream(_customerXmlFileName, FileMode.Create))
            {
                var ser = new XmlSerializer(typeof(List<Customer>), new XmlRootAttribute("customer_list"));
                ser.Serialize(writer, customers);
            }
        }

        /// <summary>
        /// Mockup
        /// </summary>
        public static void WriteXml()
        {
            using (var writer = new FileStream(_customerXmlFileName, FileMode.Create))
            {
                var ser = new XmlSerializer(typeof(List<Customer>), new XmlRootAttribute("customer_list"));

                var list = new List<Customer>
                {
                    new Customer() {Identifier = 1, Name = "Karen Payne"},
                    new Customer() {Identifier = 2, Name = "Mary Jones"},
                    new Customer() {Identifier = 3, Name = "Jim Williams"}
                };

                ser.Serialize(writer, list);
            }
        }
        /// <summary>
        /// Validate we can read the create file above
        /// </summary>
        public static void ReadXml()
        {
            List<Customer> customers;
            using (var reader = new StreamReader(_customerXmlFileName))
            {
                var deserializer = new XmlSerializer(typeof(List<Customer>), new XmlRootAttribute("customer_list"));
                customers = (List<Customer>)deserializer.Deserialize(reader);
            }
        }
    }
}
