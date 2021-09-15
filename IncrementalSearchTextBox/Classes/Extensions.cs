using System.Globalization;

namespace IncrementalSearchTextBox.Classes
{
    public static class Extensions
    {
        public static string ToTitleCase(this string sender) 
            => string.IsNullOrWhiteSpace(sender) ? 
                sender : 
                CultureInfo.InvariantCulture.TextInfo.ToTitleCase(sender.ToLower());
    }
}