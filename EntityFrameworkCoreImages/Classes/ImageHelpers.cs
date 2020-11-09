using System;
using System.Drawing;
using System.IO;

namespace EntityFrameworkCoreImages.Classes
{
    public class ImageHelpers
    {
        /// <summary>
        /// For image column type
        /// </summary>
        /// <param name="contents"></param>
        /// <returns>A Image</returns>
        public static Image ByteArrayToImage(byte[] contents)
        {
            if (contents is null)
            {
                return InvalidImage(); // or return null
            }
            else
            {
                var converter = new ImageConverter();
                var image = (Image)converter.ConvertFrom(contents);

                return image;
            }
        }
        /// <summary>
        /// For varbinary (MAX) column type
        /// </summary>
        /// <param name="contents"></param>
        /// <returns>A Image</returns>
        public static Image ByteArrayToImage1(byte[] contents)
        {
            using (var ms = new MemoryStream(contents))
            {
                return Image.FromStream(ms);
            }
        }

        public static Image InvalidImage()
        {
            return ConvertTextToImage(Environment.NewLine + " Error", "Arial", 20, Color.Red, Color.White, 300, 100);
        }
        private static Bitmap ConvertTextToImage(string pMessageText, string pFontName, int pFontSize, Color pBackColor, Color pForeColor, int pWidth, int pHeight)
        {

            var bitmap = new Bitmap(pWidth, pHeight);

            using (var graphics = Graphics.FromImage(bitmap))
            {
                var font = new Font(pFontName, pFontSize);
                graphics.FillRectangle(new SolidBrush(pBackColor), 0, 0, bitmap.Width, bitmap.Height);
                graphics.DrawString(pMessageText, font, new SolidBrush(pForeColor), 0, 0);
                graphics.Flush();
                font.Dispose();
                graphics.Dispose();
            }

            return bitmap;

        }

    }
}
