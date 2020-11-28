using System.Collections.Generic;

namespace NuGetPackageBrowser.Classes.Containers
{
    public class Package
    {
        public string ProjectName { get; set; }
        public List<PackageItem> PackageItems { get; set; }
        public int ItemCount => PackageItems.Count;
        public override string ToString() => ProjectName;

        public Package()
        {
            PackageItems = new List<PackageItem>();
        }
    }
}
