using System.Windows.Forms;

namespace ValidateLogin.Classes
{
    public static class CommonDialogs
    {
        public static bool Question(string text) => 
            (MessageBox.Show(text, "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes);
        public static bool Question(string text, string title) => 
            (MessageBox.Show(text, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes);
    }
}