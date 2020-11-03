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
        /// TODO
        ///   - refactor into for-next using count from Details()
        ///   - placeholder for user name
        ///   - token for page and per page
        /// </summary>
        public static void DownLoad()
        {
            //var request = WebRequest.Create("https://api.github.com/users/karenpayneoregon/repos?page=3&per_page=100; rel=\"last") as HttpWebRequest;
            var request = WebRequest.Create("https://api.github.com/users/karenpayneoregon/repos?per_page=100") as HttpWebRequest;

            if (request != null)
            {
                request.UserAgent = "TestApp";

                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    var reader = new StreamReader(response.GetResponseStream());
                    var json = reader.ReadToEnd();
                    var repositories = JsonConvert.DeserializeObject<List<Repository>>(json);


                    foreach (var repository in repositories)
                    {
                        Console.WriteLine(repository.Name);
                    }

                    Console.WriteLine(repositories.Count);
                }
            }
        }

        public static async  Task<List<Repository>> DownLoadPublicRepositoriesAsync()
        {

            var repoList = new List<Repository>();


            return await Task.Run(async () =>
            {
                var page = 1;

                while (true)
                {

                    var request = WebRequest.Create($"https://api.github.com/users/karenpayneoregon/repos?page={page}&per_page=100; rel=\"next") as HttpWebRequest;

                    request.UserAgent = "TestApp";

                    using (var response = request.GetResponse() as HttpWebResponse)
                    {
                        var reader = new StreamReader(response.GetResponseStream());
                        var json = await reader.ReadToEndAsync();
                        var repositories = JsonConvert.DeserializeObject<List<Repository>>(json);

                        if (repositories.Count != 0)
                        {
                            repoList.AddRange(repositories);
                        }
                        else
                        {
                            break;
                        }

                        page += 1;
                    }

                }

                return repoList;

            });


        }


        private static int PublicRepositoryCount()
        {
            return Details().public_repos;
        }

        /// <summary>
        /// Get repo details, need to better read json
        /// </summary>
        /// <returns></returns>
        public static RepositoryDetails Details()
        {

            var request = WebRequest.Create("https://api.github.com/users/karenpayneoregon") as HttpWebRequest;
            if (request != null)
            {
                request.UserAgent = "TestApp";

                using (var response = request.GetResponse() as HttpWebResponse)
                {
                    if (response != null)
                    {
                        var reader = new StreamReader(response.GetResponseStream());
                        var json = $"[{reader.ReadToEnd()}]";

                        try
                        {
                            var results = JsonConvert.DeserializeObject<RepositoryDetails[]>(json);
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
            else
            {
                return null;
            }
        }
    }


}

