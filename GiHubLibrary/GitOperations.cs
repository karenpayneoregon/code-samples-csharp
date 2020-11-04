﻿using System;
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
        /// Fetch repository
        /// </summary>
        /// <param name="domain">valid domain name</param>
        /// <returns></returns>
        public static async  Task<List<Repository>> DownLoadPublicRepositoriesAsync(string domain)
        {

            var repoList = new List<Repository>();

            return await Task.Run(async () =>
            {
                var page = 1;

                while (true)
                {

                    var request = WebRequest.Create($"https://api.github.com/users/{domain}/repos?page={page}&per_page=100; rel=\"next") as HttpWebRequest;

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

        /// <summary>
        /// Count of repositories
        /// </summary>
        /// <returns></returns>
        private static int PublicRepositoryCount()
        {
            return Details("").public_repos;
        }

        /// <summary>
        /// Get repo details, need to better read json
        /// </summary>
        /// <returns></returns>
        public static RepositoryDetails Details(string domain)
        {
            if (WebRequest.Create($"https://api.github.com/users/{domain}") is HttpWebRequest request)
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

