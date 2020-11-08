using System.Drawing;

namespace WinFormsControlsExtensions
{
    public class ImageHelpers
    {
        /// <summary>
        /// Converts a byte array to an image. If contents parameter is null return null
        /// </summary>
        /// <param name="contents">Valid byte array which represents an image usually from a database table</param>
        /// <returns>An Image or null</returns>
        public static Image ByteArrayToImage(byte[] contents)
        {
            if (contents is null)
            {
                return null;
            }
            else
            {
                var converter = new ImageConverter();
                var image = (Image)converter.ConvertFrom(contents);

                return image;
            }
        }


    }
}
