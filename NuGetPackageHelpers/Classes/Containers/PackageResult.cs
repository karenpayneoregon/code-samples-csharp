using System;
using System.Collections.Generic;

namespace NuGetPackageBrowser.Classes.Containers
{
    public class PackageResult
    {
        public Version Version { get; set; }
        public List<PackageItem> List { get; set; }
    }
}