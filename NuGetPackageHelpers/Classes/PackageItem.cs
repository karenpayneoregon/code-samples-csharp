namespace NuGetPackageHelpers.Classes
{
    public class PackageItem
    {
        /// <summary>
        /// NuGet package name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// NuGet package version
        /// </summary>
        public string Version { get; set; }
        public string Delimited => $"{Name},{Version}";
        public override string ToString() => Name;

    }
}