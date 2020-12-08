using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace CopyFileWhenDone.Classes
{
    public static class FileHelper
    {
        const int ErrorSharingViolation = 32;
        const int ErrorLockViolation = 33;

        private static bool IsFileLocked(Exception exception)
        {
            var errorCode = Marshal.GetHRForException(exception) & ((1 << 16) - 1);
            return errorCode == ErrorSharingViolation || errorCode == ErrorLockViolation;
        }
        /// <summary>
        /// Determine if file can be read
        /// </summary>
        /// <param name="fileName">File name to check</param>
        /// <returns>true ready else false not ready to use</returns>
        public static async Task<bool> CanReadFile(string fileName)
        {

            try
            {
                using (var fileStream = File.Open(fileName, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
                {
                    if (fileStream != null)
                    {
                        fileStream.Close();
                    }
                }
            }
            catch (IOException ex)
            {
                if (IsFileLocked(ex))
                {
                    return false;
                }
            }

            await Task.Delay(50);

            return true;

        }
    }
}
