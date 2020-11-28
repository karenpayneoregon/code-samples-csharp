namespace NuGetPackageHelpers.Classes.Containers
{
    public class ProjectType
    {
        public string Name { get; set; }
        public string Extension { get; set; }
        public override string ToString() => Name;

    }
}
