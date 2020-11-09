using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormControls
{
    public class PasteDetectorTextBox : TextBox
    {
        public delegate void MonitorHandler(string args);
        public event MonitorHandler OnMonitor;
        protected override void WndProc(ref Message m)
        {
            // Trap WM_PASTE:
            if (m.Msg == 0x302 && Clipboard.ContainsText())
            {
                OnMonitor?.Invoke(Clipboard.GetText());
                return;
            }

            base.WndProc(ref m);
        }
    }
}
