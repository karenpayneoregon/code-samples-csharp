using System;
using System.Collections.Generic;
using NuGetPackageBrowser.Classes.Containers;

namespace NuGetPackageBrowser.Classes
{
    public class PackageResult
    {
        public Version Version { get; set; }
        public List<PackageItem> List { get; set; }
    }
}