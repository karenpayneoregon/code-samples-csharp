using System;

namespace ExamineZipFile.Classes
{
    public class FileContainer
    {
        /// <summary>
        /// File name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// File size
        /// </summary>
        public Int64 Size { get; set; }
        public string SizeFormatted { get; set; }
        /// <summary>
        /// Used to populate TreeView node with name and file size
        /// </summary>
        public string NodeValue => $"{Name} ({SizeFormatted})";

        public override string ToString()
        {
            return Name;
        }
    }
}