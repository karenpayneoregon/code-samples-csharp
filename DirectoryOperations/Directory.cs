using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryOperations
{
    public class Directory
    {
        public delegate void OnDelete(string status);
        /// <summary>
        /// Callback for subscribers to see what is being worked on
        /// </summary>
        public static event OnDelete OnDeleteEvent;

        public delegate void OnException(Exception exception);
        /// <summary>
        /// Callback for subscribers to know about a problem
        /// </summary>
        public static event OnException OnExceptionEvent;

        /// <summary>
        /// Recursively remove an entire folder structure and files with events for monitoring and basic
        /// exception handling.
        /// </summary>
        /// <param name="currentDirectoryInfo"></param>
        public static void RecursiveDelete(DirectoryInfo currentDirectoryInfo)
        {
            if (!currentDirectoryInfo.Exists)
            {
                OnDeleteEvent?.Invoke("Nothing to process");
                return;
            }

            OnDeleteEvent?.Invoke(currentDirectoryInfo.Name);

            foreach (var directoryInfo in currentDirectoryInfo.EnumerateDirectories())
            {
                try
                {
                    RecursiveDelete(directoryInfo);
                }
                catch (Exception ex)
                {
                    OnExceptionEvent?.Invoke(ex);
                }
            }

            currentDirectoryInfo.Delete(true);

        }
        /// <summary>
        /// Recursive remove an entire folder structure and files done by novice
        /// coders who don't consider things like permissions on folders or files
        /// that will deny an operation to remove a folder and or file or that
        /// the folder or file is in use currently.
        /// </summary>
        /// <param name="folderName"></param>
        public static void RecursiveDelete(string folderName)
        {
            foreach (var d in (new DirectoryInfo(folderName)).EnumerateDirectories("*.*", SearchOption.AllDirectories))
            {
                if (d.Name.Equals("Demo", StringComparison.CurrentCultureIgnoreCase))
                {
                    d.Delete(recursive: true);
                }
            }
        }
    }
}
