using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GitHubRepositoryExamples.LanguageExtensions;

namespace GitHubRepositoryExamples.Classes
{
    public class ControlHelpers
    {
        /// <summary>
        /// Clear all control data bindings on control
        /// </summary>
        /// <param name="sender">control to work on</param>
        public static void ClearTextBoxBindings(Control sender)
        {
            var textBoxes = sender.Controls.OfType<TextBox>().ToList();
            foreach (var textBox in textBoxes)
            {
                if (textBox.DataBindings.Count > 0)
                {
                    textBox.DataBindings.Clear();
                }
            }
        }
        /// <summary>
        /// Set water mark on all TextBox controls
        /// </summary>
        /// <param name="sender">control to work on</param>
        public static void SetWaterMarkers(Control sender)
        {
            var textBoxes = sender.Controls.OfType<TextBox>().ToList();
            foreach (var textBox in textBoxes)
            {
                textBox.SetWatermark(textBox.Name == "SearchTextBox" ? "incremental search" : "unknown");
            }
        }
    }
}
