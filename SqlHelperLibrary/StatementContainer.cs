using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlHelperLibrary
{
    public class StatementContainer
    {
        /// <summary>
        /// Method name which invoke the SQL creation
        /// </summary>
        public string MethodName { get; set; }
        /// <summary>
        /// Single line SQL generated
        /// </summary>
        public string Text { get; set; }
        public string Data => $"{MethodName}\n{Text}";
    }
}
