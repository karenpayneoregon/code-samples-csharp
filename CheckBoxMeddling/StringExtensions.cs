using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CheckBoxMeddling
{
    public static class StringExtensions
    {
        public static int ToInt(this string sender) => Convert.ToInt32(Regex.Replace(sender, "[^0-9 _]", ""));
    }
}
