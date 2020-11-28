using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public enum ExceptionLogType
    {
        /// <summary>
        /// Common exceptions
        /// </summary>
        General,
        /// <summary>
        /// Import process exceptions
        /// </summary>
        Import,
        /// <summary>
        /// Post process exceptions
        /// </summary>
        Post
    }
}
