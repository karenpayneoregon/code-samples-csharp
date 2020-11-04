using System.Windows.Forms;

namespace GitHubRepositoryExamples.Classes
{
    /// <summary>
    /// TextBox with no beep when ENTER is pressed as is is limited usage.
    /// </summary>
    public class NoBeepTextBox : TextBox
    {
        public delegate void TriggerDelegate();
        /// <summary>
        /// Subscribe to be notified when ENTER was pressed.
        /// </summary>
        public event TriggerDelegate TriggerEvent;
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == (Keys.Return))
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                TriggerEvent?.Invoke();

                return;
            }

            base.OnKeyDown(e);
        }
    }
}
