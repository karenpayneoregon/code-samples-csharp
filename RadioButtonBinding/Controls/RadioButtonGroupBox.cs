using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButtonBinding
{
    [DefaultBindingProperty("Selected")]
    public class RadioGroupBox : GroupBox
    {
        [Description("Occurs when the selected value changes.")]
        public event SelectedChangedEventHandler SelectedChanged;

        public class SelectedChangedEventArgs : EventArgs
        {
            public int Selected { get; private set; }

            internal SelectedChangedEventArgs(int selected)
            {
                Selected = selected;
            }
        }

        public delegate void SelectedChangedEventHandler(object sender, SelectedChangedEventArgs e);


        private int _selected;

        [Browsable(false)]
        [Bindable(BindableSupport.Yes, BindingDirection.TwoWay)]
        [Description("The selected value associated with this control."), Category("Data")]
        public int Selected
        {
            get => _selected;
            set
            {
                int val = 0;
                var radioButton = this.Controls.OfType<RadioButton>()
                    .FirstOrDefault(radio => radio.Tag != null && int.TryParse(radio.Tag.ToString(), out val) && val == value);

                if (radioButton != null)
                {
                    radioButton.Checked = true;
                    _selected = val;
                }
            }
        }

        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);

            if (e.Control is RadioButton radioButton)
            {
                radioButton.CheckedChanged += radioButton_CheckedChanged;
            }
        }

        protected void OnSelectedChanged(SelectedChangedEventArgs e)
        {
            if (SelectedChanged != null)
            {
                SelectedChanged(this, e);
            }
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            var radio = (RadioButton)sender;

            if (radio.Checked && radio.Tag != null && int.TryParse(radio.Tag.ToString(), out var val))
            {
                _selected = val;
                OnSelectedChanged(new SelectedChangedEventArgs(_selected));
            }
        }
    }
}
