﻿using System.Collections.Generic;

namespace NuGetPackageHelpers.Classes
{
    /// <summary>
    /// Supported project types
    /// </summary>
    public class ProjectTypes
    {
        public static List<ProjectType> ProjectTypesList()
        {
            return new List<ProjectType>()
            {
                new ProjectType() {Name = "C#", Extension = "*.csproj"},
                new ProjectType() {Name = "VB.NET", Extension = "*.vbproj"}
            };
        }
    }
}