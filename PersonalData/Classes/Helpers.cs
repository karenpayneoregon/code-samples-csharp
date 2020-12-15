using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PersonalData.Classes
{
    public class Helpers
    {
        /// <summary>
        /// Download profile image
        /// </summary>
        /// <param name="address">URL for profile image</param>
        /// <param name="fileName">File name to save image</param>
        /// <returns></returns>
        public static bool DownLoadProfileImage(string address, string fileName)
        {

            if (string.IsNullOrWhiteSpace(address))
            {
                return false;
            }

            try
            {
                using (var client = new WebClient())
                {
                    client.DownloadFile(new Uri(address), fileName);
                    return File.Exists(fileName);
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
