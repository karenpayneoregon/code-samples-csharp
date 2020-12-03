using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;

namespace ExamineZipFile.Classes
{
    /// <summary>
    /// Methods to read .zip contents and format file sizes.
    /// </summary>
    public class ZipHelpers
    {
        /// <summary>
        /// Get all file names and contents
        /// </summary>
        /// <param name="zippedFile">Valid zip file</param>
        /// <returns></returns>
        public static Dictionary<string, byte[]> GetFiles(byte[] zippedFile)
        {
            using (var ms = new MemoryStream(zippedFile))
            {
                using (var archive = new ZipArchive(ms, ZipArchiveMode.Read))
                {
                    return archive.Entries.ToDictionary((zae) =>
                        zae.FullName, (x) => ReadStream(x.Open()));
                }
            }
        }
        /// <summary>
        /// Used to read .zip file
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        private static byte[] ReadStream(Stream stream)
        {
            using (var ms = new MemoryStream())
            {
                stream.CopyTo(ms);
                return ms.ToArray();
            }
        }

        private static readonly string[] SizeSuffixes =
        {
            "bytes",
            "KB",
            "MB",
            "GB",
            "TB",
            "PB",
            "EB",
            "ZB",
            "YB"
        };

        /// <summary>
        /// Format int as readable file size
        /// </summary>
        /// <param name="value">value to format</param>
        /// <param name="decimalPlaces">decimal places, default is 1</param>
        /// <returns></returns>
        public static string SizeSuffix(Int64 value, int decimalPlaces = 1)
        {

            if (value < 0)
            {
                return "-" + SizeSuffix(-value);
            }

            int size = 0;
            var dValue = (decimal)value;

            while (Math.Round(dValue, decimalPlaces) >= 1000)
            {
                dValue /= 1024M;
                size += 1;
            }

            return string.Format("{0:n" + decimalPlaces + "} {1}", dValue, SizeSuffixes[size]);

        }
    }

}