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
