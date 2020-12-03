using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamineZipFile.Classes
{
    public class ArchiveOperations
    {
        public delegate void OnException(Exception exception);
        /// <summary>
        /// Callback for subscribers to know about a problem
        /// </summary>
        public static event OnException OnExceptionEvent;

        public static List<ResultContainer> Work(string zipFileName)
        {
            var containers = new List<ResultContainer>();
            var newItem = false;
            
            if (!File.Exists(zipFileName))
            {
                OnExceptionEvent?.Invoke(new FileNotFoundException(zipFileName));
                return null;
            }
            
            Dictionary<string, byte[]> dictionary = new Dictionary<string, byte[]>(); 

            try
            {
                dictionary = ZipHelpers.GetFiles(File.ReadAllBytes(zipFileName));
            }
            catch (Exception e)
            {
                OnExceptionEvent?.Invoke(e);
            }

            var currentContainer = new ResultContainer();

            foreach (var keyValuePair in dictionary)
            {
                var folderName = Path.GetDirectoryName(keyValuePair.Key);

                if (string.IsNullOrWhiteSpace(folderName))
                {
                    folderName = "(root)";
                }

                currentContainer = containers.FirstOrDefault((item) => item.FolderName == folderName);

                if (currentContainer == null)
                {
                    currentContainer = new ResultContainer { FolderName = folderName };
                    newItem = true;
                }
                else
                {
                    newItem = false;
                }


                if (!string.IsNullOrWhiteSpace(Path.GetFileName(keyValuePair.Key)))
                {
                    currentContainer.List.Add(new FileContainer()
                    {
                        Name = Path.GetFileName(keyValuePair.Key),
                        Size = keyValuePair.Value.Length,
                        SizeFormatted = ZipHelpers.SizeSuffix(keyValuePair.Value.Length)
                    });
                }

                if (newItem)
                {
                    containers.Add(currentContainer);
                }
            }

            return containers;
        }
    }
}
