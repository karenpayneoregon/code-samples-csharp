using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;

namespace WinFormControls
{
    [ToolboxBitmap(typeof(CueTextBox))]
    public class CueTextBox : System.Windows.Forms.TextBox
    {
        private const int EM_SETCUEBANNER = 0x1501;
        private const int EM_GETCUEBANNER = 0x1502;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        private string _cueBannerText = string.Empty;

        /// <summary>
        /// Gets or sets the cue text that is displayed on the TextBox control.
        /// </summary>
        [Description("Text that is displayed as Cue banner."), Category("Appearance"), DefaultValue("")]
        public string CueBannerText
        {
            get => _cueBannerText;
            set
            {
                _cueBannerText = value;
                UpdateControl();
            }
        }

        private bool _showCueFocused = false;

        /// <summary>
        /// Gets or sets whether the Cue text should be displayed even
        /// when the control has keyboard focus.
        /// </summary>
        /// <remarks>
        /// If true, the Cue text will disappear as soon as the user starts typing.
        /// </remarks>
        [Description("If true, the Cue text will be displayed even when the control has keyboard focus."), Category("Appearance"), DefaultValue(false)]
        public bool ShowCueFocused
        {
            get => _showCueFocused;
            set
            {
                _showCueFocused = value;
                UpdateControl();
            }
        }

        private void UpdateControl()
        {
            if (IsHandleCreated)
            {
                SendMessage(Handle, (int)EM_SETCUEBANNER, (_showCueFocused) ? 1 : 0, _cueBannerText);
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);

            UpdateControl();
        }

    }
}
