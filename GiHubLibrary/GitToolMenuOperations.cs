using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GiHubLibrary
{
    public class GitToolMenuOperations
    {
        /// <summary>
        /// File containing menu items
        /// </summary>
        private static readonly string _fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "MenuItems.json");
        /// <summary>
        /// Seed initial data
        /// </summary>
        /// <returns></returns>
        private static List<GitToolMenuItem> CreateList()
        {
            return new List<GitToolMenuItem>
            {
                new GitToolMenuItem() {Id = 1, Text = "dotnet"},
                new GitToolMenuItem() {Id = 2, Text = "ErikEJ"},
                new GitToolMenuItem() {Id = 3, Text = "KamiKillertO"},
                new GitToolMenuItem() {Id = 4, Text = "GoogleCloudPlatform"},
                new GitToolMenuItem() {Id = 5, Text = "regaw-leinad"},
                new GitToolMenuItem() {Id = 6, Text = "karenpayneoregon"},
                new GitToolMenuItem() {Id = 7, Text = "sindresorhus"},
                new GitToolMenuItem() {Id = 8, Text = "machinelearning-samples"},
                new GitToolMenuItem() {Id = 9, Text = "julielerman"},
                new GitToolMenuItem() {Id = 10, Text = "pituach"}
            };
        }

        /// <summary>
        /// Create initial json file with above menu items
        /// </summary>
        /// <returns></returns>
        public static string Json() => JsonConvertEx.SerializeObject(CreateList());
        /// <summary>
        /// 
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public static List<GitToolMenuItem> ListDeserialized(string json)
        {
            return JsonConvert.DeserializeObject<List<GitToolMenuItem>>(json).ToList();
        }
        /// <summary>
        /// Initialize menu items to file
        /// </summary>
        public static void WriteToFile()
        {
            var json = Json();
            File.WriteAllText(_fileName, json);
        }
        /// <summary>
        /// Write data from configuration form to json file
        /// </summary>
        /// <param name="list"></param>
        public static void WriteToFile(List<GitToolMenuItem> list)
        {
            var json = JsonConvertEx.SerializeObject(list);
            File.WriteAllText(_fileName, json);
        }
        /// <summary>
        /// Read menu items from file
        /// </summary>
        /// <returns></returns>
        public static List<GitToolMenuItem> ReadFromFile()
        {
            var json = File.ReadAllText(_fileName);
            return JsonConvert.DeserializeObject<List<GitToolMenuItem>>(json).ToList();
        }
    }
}
