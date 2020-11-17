using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Assembly;

namespace ProjectHelpers
{
    public class References
    {
        /// <summary>
        /// Get project references
        /// </summary>
        /// <returns>List of references for the calling project.</returns>
        public static IEnumerable<string> CurrentAssemblyReferencedAssemblies()
        {
            var referencedAssemblies = new List<string>();

            foreach (AssemblyName assembly in GetEntryAssembly()?.GetReferencedAssemblies())
            {
                referencedAssemblies.Add(assembly.ToString());
            }

            return referencedAssemblies.AsReadOnly().AsEnumerable();

        }
    }
}
