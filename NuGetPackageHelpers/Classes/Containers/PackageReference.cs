using System;

namespace NuGetPackageHelpers.Classes.Containers
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
