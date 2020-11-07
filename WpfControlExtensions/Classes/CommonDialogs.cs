using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.MessageBox;

namespace WpfControlExtensions.Classes
{
    public static class CommonDialogs
    {
        public static bool Question(string text) =>
            (MessageBox.Show(text, "Question", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No) ==
             MessageBoxResult.Yes);
        public static bool Question(string text, string title) =>
            (MessageBox.Show(text, title, MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No) == MessageBoxResult.Yes);

    }
}
