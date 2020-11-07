using System.Collections.Generic;

namespace NuGetPackageHelpers.Classes
{
    public class Solution
    {
        /// <summary>
        /// Location of solution
        /// </summary>
        public string Folder { get; set; }
        /// <summary>
        /// Visual Studio solution name
        /// </summary>
        public string SolutionName { get; set; }
        /// <summary>
        /// Packages for solution
        /// </summary>
        public List<Package> Packages { get; set; }
        /// <summary>
        /// Package count in Packages
        /// </summary>
        public int Count => Packages.Count;
        public override string ToString() => SolutionName;

        public Solution()
        {
            Packages = new List<Package>();
        }

    }
}