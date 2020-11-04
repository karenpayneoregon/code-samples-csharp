using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiHubLibrary
{
    public class RepositoryProjectItem 
    {
        public string sha { get; set; }
        public string url { get; set; }
        public Tree[] tree { get; set; }
        public bool truncated { get; set; }
    }

    public class Tree
    {
        public string path { get; set; }
        public string mode { get; set; }
        public string type { get; set; }
        public string sha { get; set; }
        public int size { get; set; }
        public string url { get; set; }
    }

}
