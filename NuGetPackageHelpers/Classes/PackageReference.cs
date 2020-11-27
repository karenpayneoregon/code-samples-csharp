using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuGetPackageHelpers.Classes
{
    public class PackageReference
    {
        /// <summary>
        /// nuget reference name
        /// </summary>
        public string Include { get; set; }
        /// <summary>
        /// package version
        /// </summary>
        public Version Version { get; set; }
    }

}
