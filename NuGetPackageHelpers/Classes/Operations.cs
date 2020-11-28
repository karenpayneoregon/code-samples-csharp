using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml.XPath;
using NuGetPackageBrowser.Classes.Containers;

namespace NuGetPackageBrowser.Classes
{

    public class Operations 
    {
        public delegate void DisplayInformation(string sender, bool bold);
        public static event DisplayInformation DisplayInformationHandler;
        public static Solution Solution;

        /// <summary>
        /// List of distinct package names in solution
        /// </summary>
        /// <returns></returns>
        public static List<string> DistinctPackageNames()
        {
            var sorted = new SortedSet<string>();

            foreach (var package in Solution.Packages)
            {
                foreach (var packageItem in package.PackageItems)
                {
                    sorted.Add(packageItem.Name);
                }

            }
            
            return sorted.ToList();
        }

        /// <summary>
        /// File name for exporting results to a web page
        /// </summary>
        public static string ExportWebPageFileName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="solutionFolder">Folder to get packages</param>
        /// <param name="projectType">language e.g. C#, VB.NET</param>
        public static void BuilderPackageTable(string solutionFolder, string projectType)
        {
            string[] exclude = {".git",".vs", "packages"};

            string[] solutionName = Directory.GetFiles(solutionFolder, "*.sln");
            Solution = new Solution()
            {
                Folder = solutionFolder,
                SolutionName = solutionName.Length == 1 ? Path.GetFileName(solutionName[0]) : "???"
            };

            var folders = Directory.GetDirectories(solutionFolder).
                Where(path => !exclude.Contains(path.Split('\\').Last()));

            foreach (var folder in folders)
            {
                var fileName = (Path.Combine(folder, "packages.config"));
                var package = new Package(); // {SolutionFolder = solutionFolder };

                if (File.Exists(fileName))
                {
                    
                    var projectFiles = Directory.GetFiles(folder, projectType);

                    if (projectFiles.Length == 0)
                    {
                        continue;
                    }

                    var projectNameWithoutExtension = Path.GetFileNameWithoutExtension(projectFiles[0]);

                    DisplayInformationHandler?.Invoke(projectNameWithoutExtension, true);
                    package.ProjectName = projectNameWithoutExtension;

                    var doc = XDocument.Load(fileName);

                    foreach (var packageNode in doc.XPathSelectElements("/packages/package"))
                    {
                        var packageName = packageNode.Attribute("id").Value;
                        //var version = packageNode.Attribute("version").Value;
                        Version version = new Version(packageNode.Attribute("version").Value);
                        
                        DisplayInformationHandler?.Invoke($"    {packageName}, {version}", false);
                        package.PackageItems.Add(new PackageItem() {Name = packageName, Version = version});

                    }

                    Solution.Packages.Add(package);

                    DisplayInformationHandler?.Invoke("", false);
                }
                else
                {
                    package = new Package(); 
                    var projectFiles = Directory.GetFiles(folder, projectType);
                    if (projectFiles.Length == 0)
                    {
                        continue;
                    }

                    GetCorePackages(projectFiles[0],package);
                }
             
            }
        }
        public static void GetCorePackages(string projectFileName, Package package)
        {
            if (!File.Exists(projectFileName))
            {
                return;
            }

            var doc = XDocument.Load(projectFileName);
            var packageReferences = doc.XPathSelectElements("//PackageReference")
                .Select(pr => new PackageReference
                {
                    Include = pr.Attribute("Include").Value,
                    Version = new Version(pr.Attribute("Version").Value)
                });

            if (!packageReferences.Any())
            {
                return;
            }

            package.ProjectName = Path.GetFileNameWithoutExtension(projectFileName);
            DisplayInformationHandler?.Invoke(Path.GetFileNameWithoutExtension(projectFileName), true);

            foreach (PackageReference packageReference in packageReferences)
            {

                package.PackageItems.Add(new PackageItem()
                {
                    Name = packageReference.Include,
                    Version = packageReference.Version
                });
                
                
                DisplayInformationHandler?.Invoke($"    {packageReference.Include}, {packageReference.Version}", false);

            }

            Solution.Packages.Add(package);

        }
        /// <summary>
        /// Export current solution packages to a HTML page.
        /// Note that the styles can be changed to suit a developer's
        /// personal choices.
        /// </summary>
        public static void ExportAsWebPage()
        {
            var sb = new StringBuilder();

            sb.AppendLine("<!DOCTYPE html>");
            sb.AppendLine("<html>");
            sb.AppendLine("<head>");
            sb.AppendLine("<meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">");
            sb.AppendLine("<style>");
            sb.AppendLine("table {border-collapse: collapse;border-spacing: 0;width: 100%;border: 1px solid #ddd;}");
            sb.AppendLine("table.center {width:400px;margin-left: auto; margin-right: auto;}");
            sb.AppendLine("th, td {text-align: left;padding: 16px;}");
            sb.AppendLine("tr:nth-child(even) {background-color: #f2f2f2;}");
            sb.AppendLine("h1 {text-align: center;color:DodgerBlue;}");
            sb.AppendLine("</style>");
            sb.AppendLine("</head>");
            sb.AppendLine("<body>");


            sb.AppendLine("<h1>Nuget packages</h1>");
            sb.AppendLine("<table  class=\"center\">");
            sb.AppendLine($"<tr><td><strong>Solution folder</strong></td><td>{Solution.Folder}</td></tr>");
            sb.AppendLine($"<tr><td><strong>Solution name</strong></td><td>{Solution.SolutionName}</td></tr>");
            sb.AppendLine("<tr><td style='height: 10px !important;'></td></tr>");


            foreach (var package in Solution.Packages)
            {
                Console.WriteLine(package.ProjectName);
                sb.AppendLine($"<tr><td style='background-color:#FFFF66 !important;'><strong>{package.ProjectName}</strong></td>" + 
                              "<td style='white-space: pre;background-color:#FFFF66 !important;'></td></tr>");

                foreach (var packageItem in package.PackageItems)
                {
                    sb.AppendLine($"<tr><td>{packageItem.Name}</td><td>{packageItem.Version}</td></tr>");
                }

            }

            sb.AppendLine("</table>");

            sb.AppendLine("</body>");
            sb.AppendLine("</html>");
            
            File.WriteAllText(ExportWebPageFileName, sb.ToString());

            if (File.Exists(ExportWebPageFileName))
            {
                Process.Start(ExportWebPageFileName);
            }

        }
        /// <summary>
        /// Provides packages grouped by version
        /// </summary>
        /// <param name="packageName">Package name</param>
        /// <param name="packageItems">List of PackageItem</param>
        /// <returns></returns>
        public static List<PackageResult> VersionGroup(string packageName, List<PackageItem> packageItems)
        {
            return packageItems.GroupBy(packageItem => packageItem.Version)
                .Select(iGroup => new PackageResult { Version = iGroup.Key, List = iGroup.ToList() }).ToList();
        }
        /// <summary>
        /// Create a comma-delimited string
        /// </summary>
        /// <param name="packageName">Name of package</param>
        /// <param name="packageItems"></param>
        /// <returns></returns>
        public static string VersionReport(string packageName,List<PackageItem> packageItems)
        {
            var sb = new StringBuilder();

            sb.AppendLine(packageName).Replace("'","");
            sb.AppendLine(new string('-', 30));

            var results = packageItems.GroupBy(packageItem => packageItem.Version)
                .Select(iGroup => new PackageResult { Version = iGroup.Key, List = iGroup.ToList() }).ToList();

            foreach (var result in results)
            {
                sb.AppendLine(result.Version.ToString());
                foreach (var packageItem in result.List)
                {
                    sb.AppendLine($"{packageItem.Name}");
                }

                sb.AppendLine(new string('-', 30));
            }

            return sb.ToString();
        }



    }
}
