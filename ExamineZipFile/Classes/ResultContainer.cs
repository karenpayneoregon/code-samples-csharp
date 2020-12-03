using System.Collections.Generic;

namespace ExamineZipFile.Classes
{
    /// <summary>
    /// Container for folder name and files in folder
    /// </summary>
    public class ResultContainer
    {
        /// <summary>
        /// Folder name for files
        /// </summary>
        public string FolderName { get; set; }
        /// <summary>
        /// List of files and sizes
        /// </summary>
        public List<FileContainer> List { get; set; } = new List<FileContainer>();
        public override string ToString()
        {
            return FolderName;
        }
    }
}