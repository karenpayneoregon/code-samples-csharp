using System;
using System.Collections.Generic;
using NuGetPackageHelpers.Classes.Containers;

namespace NuGetPackageHelpers.Classes
{
    public class PackageResult
    {
        public Version Version { get; set; }
        public List<PackageItem> List { get; set; }
    }
}