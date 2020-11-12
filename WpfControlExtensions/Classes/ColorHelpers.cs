using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using static System.Windows.Media.ColorConverter;

namespace WpfControlExtensions.Classes
{
    public class ColorHelpers
    {

        /// <summary>
        /// Gets the System.Drawing.Color object from hex string.
        /// </summary>
        /// <param name="hexString">The hex string.</param>
        /// <returns></returns>
        public static System.Drawing.Color HexToColor(string hexString) => ColorTranslator.FromHtml(hexString);

        /// <summary>
        /// Convert hex string to a SolidColorBrush
        /// </summary>
        /// <returns></returns>
        public static SolidColorBrush HexColorToSolidColorBrush(string hexString) => 
            (SolidColorBrush)(new BrushConverter().ConvertFrom(hexString.StartsWith("#") ? hexString : $"#{hexString}"));
        /// <summary>
        /// Convert Color to SolidColorBrush
        /// </summary>
        /// <param name="selectColor"><see cref="System.Drawing.Color"/></param>
        /// <returns></returns>
        public static SolidColorBrush ColorToSolidColorBrush(System.Drawing.Color selectColor) => 
            new SolidColorBrush((System.Windows.Media.Color)ConvertFromString(selectColor.Name));
    }
}
