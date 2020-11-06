using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiHubLibrary
{
    public class RepositoryCommitItem
    {
        public string sha { get; set; }
        public string node_id { get; set; }
        public Commit commit { get; set; }
        public string url { get; set; }
        public string html_url { get; set; }
        public string comments_url { get; set; }
        public object author { get; set; }
        public object committer { get; set; }
        public Parent[] parents { get; set; }
        public string[] ItemArray => new[]
        {
            commit.author.date.ToString("MM/dd/yyyy hh:mm tt"),
            commit.message
        };
    }

    public class Commit
    {
        public Author author { get; set; }
        public Committer committer { get; set; }
        public string message { get; set; }
        public Tree tree { get; set; }
        public string url { get; set; }
        public int comment_count { get; set; }
        public Verification verification { get; set; }
    }

    public class Author
    {
        public string name { get; set; }
        public string email { get; set; }
        public DateTime date { get; set; }
    }

    public class Committer
    {
        public string name { get; set; }
        public string email { get; set; }
        public DateTime date { get; set; }
    }


    public class Verification
    {
        public bool verified { get; set; }
        public string reason { get; set; }
        public object signature { get; set; }
        public object payload { get; set; }
    }

    public class Parent
    {
        public string sha { get; set; }
        public string url { get; set; }
        public string html_url { get; set; }
    }

}
