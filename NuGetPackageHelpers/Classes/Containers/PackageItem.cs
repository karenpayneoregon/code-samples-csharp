using System;

namespace NuGetPackageBrowser.Classes.Containers
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
        public Version Version { get; set; }
        public string Delimited => $"{Name},{Version}";
        public string[] ItemArray => new[]
        {
            Name, Version.ToString()
        };
        public override string ToString() => Name;

    }
}