using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GiHubLibrary
{
    public class GitOperations
    {
        /// <summary>
        /// Parse json file, only useful for development, will be deleted later.
        /// </summary>
        /// <param name="fileName"></param>
        public static void Parse(string fileName)
        {
            var json = File.ReadAllText(fileName);
            var repositories = JsonConvert.DeserializeObject<List<Repository>>(json);

            foreach (var repository in repositories)
            {
                Console.WriteLine(repository.Name);
            }

            Console.WriteLine(repositories.Count);

            Console.WriteLine(File.ReadAllLines(fileName).Length);
        }

        /// <summary>
        /// TODO - refactor into for-next using count from Details()
        /// </summary>
        public static void DownLoad()
        {
            HttpWebRequest request = WebRequest.Create("https://api.github.com/users/karenpayneoregon/repos?page=3&per_page=100; rel=\"last") as HttpWebRequest;
            request.UserAgent = "TestApp";
            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                var json = reader.ReadToEnd();
                List<Repository> repositories = JsonConvert.DeserializeObject<List<Repository>>(json);

                Console.WriteLine();
                foreach (var repository in repositories)
                {
                    Console.WriteLine(repository.Name);
                }
                Console.WriteLine(repositories.Count);

            }


        }

        private int PublicRepositoryCount()
        {
            return 0;
        }

        /// <summary>
        /// Get repo details, need to better read json
        /// </summary>
        /// <returns></returns>
        public static RepositoryDetails Details()
        {

            var request = WebRequest.Create("https://api.github.com/users/karenpayneoregon") as HttpWebRequest;
            request.UserAgent = "TestApp";

            using (var response = request.GetResponse() as HttpWebResponse)
            {
                if (response != null)
                {
                    StreamReader reader = new StreamReader(response.GetResponseStream());
                    var json = $"[{reader.ReadToEnd()}]";

                    try
                    {
                        RepositoryDetails[] results = JsonConvert.DeserializeObject<RepositoryDetails[]>(json);
                        return results[0];
                    }
                    catch (Exception)
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
        }
    }
}

