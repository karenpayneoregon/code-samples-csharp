using System.IO;

namespace PostBuildRemoveFolder.Classes
{
    /// <summary>
    /// Used to read json in the application folder in
    /// ApplicationSettings.json.
    /// </summary>
    public class ApplicationSettings
    {
        /// <summary>
        /// PDF documents location
        /// </summary>
        public string PdfFileLocationPath { get; set; }
        /// <summary>
        /// Location of Excel file to run process against
        /// </summary>
        public string ExcelFileLocationPath { get; set; }
        /// <summary>
        /// Excel file name to read from
        /// </summary>
        public string ExcelFileName { get; set; }
        /// <summary>
        /// Path to Excel file
        /// </summary>
        public string ExcelPathName => Path.Combine(ExcelFileLocationPath, ExcelFileName);

        /// <summary>
        /// Worksheet name to get guid names
        /// </summary>
        public string WorkSheetName { get; set; }
        /// <summary>
        /// Location to move PDF documents too.
        /// </summary>
        public string DestinationPath { get; set; }
        /// <summary>
        /// Indicator to open Excel file and traverse PDF folder at program startup.
        /// </summary>
        public bool LoadOnStartUp { get; set; }
    }
}