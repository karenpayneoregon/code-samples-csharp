using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace StackOverflow_PressScrollLock
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        static extern void keybd_event(
            byte bVk, 
            byte bScan, 
            uint dwFlags, 
            UIntPtr dwExtraInfo);

        public Form1()
        {
            InitializeComponent();
        }
        private static void PressScrollLock()
        {
            const byte vkScroll = 0x91;
            const byte keyeventfKeyup = 0x2;

            keybd_event(vkScroll, 0x45, 0, (UIntPtr)0);
            keybd_event(vkScroll, 0x45, keyeventfKeyup, (UIntPtr)0);
        }
        /// <summary>
        /// This would go in a Timer.Tick event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            PressScrollLock();
            PressScrollLock();
        }
    }
}
