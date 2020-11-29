using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlHelperLibrary
{
    public class Customer
    {
        public int CustomerIdentifier { get; set; }
        public string CompanyName { get; set; }
        public string ContactTitle { get; set; }
        public string ContactName { get; set; }
        public int ContactTypeIdentifier { get; set; }
        public string ModifiedDate { get; set; }
        public DateTime Modified => Convert.ToDateTime(ModifiedDate);
        public override string ToString() => CompanyName;
    }
}
