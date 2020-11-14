using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewCombo1.Controls
{
    public class NumericUpDownColumnRight : DataGridViewColumn
    {
        private bool _allowNegative = false;
        [Category("Behavior"), Description("Allow negative values"), DefaultValue(typeof(bool), "False")]
        public bool AllowNegative
        {
            get
            {
                return _allowNegative;
            }
            set
            {
                _allowNegative = value;
            }
        }
        private int _decimalPlaces = 2;
        [Category("Behavior"), Description("Decimal places"), DefaultValue(typeof(bool), "False")]
        public int DecimalPlaces
        {
            set
            {
                _decimalPlaces = value;
            }
            get
            {
                return _decimalPlaces;
            }
        }
        public override object Clone()
        {
            NumericUpDownColumnRight clone = (NumericUpDownColumnRight)base.Clone();

            clone.AllowNegative = this.AllowNegative;
            clone.DecimalPlaces = this.DecimalPlaces;

            return clone;
        }
        public NumericUpDownColumnRight() : base(new NumericUpDownRightCell())
        {
        }
        public override DataGridViewCell CellTemplate
        {
            get => base.CellTemplate;
            set
            {

                // Ensure that the cell used for the template is a NumericUpDownCell.
                if (value != null && !(value.GetType().IsAssignableFrom(typeof(NumericUpDownRightCell))))
                {
                    throw new InvalidCastException("Must be a NumericUpDown");
                }

                base.CellTemplate = value;
            }
        }
    }
    public class NumericUpDownRightCell : DataGridViewTextBoxCell
    {
        public NumericUpDownRightCell()
        {
        }
        public override void InitializeEditingControl(int rowIndex, object initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
        {
            base.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle);

            NumericUpDownRightEditingControl ctl = (NumericUpDownRightEditingControl)DataGridView.EditingControl;
            NumericUpDownColumnRight myOwner = (NumericUpDownColumnRight)OwningColumn;

            decimal currentValue = 0M;

            if (myOwner.AllowNegative)
            {
                ctl.Minimum = -100;
            }
            else
            {
                ctl.Minimum = 1;
            }

            if (!(DBNull.Value.Equals(this.Value)))
            {
                if (Value == null)
                {
                    return;
                }
                if (decimal.TryParse(this.Value.ToString(), out currentValue))
                {
                    ctl.Value = currentValue;
                }
            }
            else
            {
                ctl.Value = 0;
            }
        }
        public override Type EditType => typeof(NumericUpDownRightEditingControl);
        public override Type ValueType => typeof(decimal);
        public override object DefaultNewRowValue => null;
    }
    internal class NumericUpDownRightEditingControl : NumericUpDown, IDataGridViewEditingControl
    {
        private DataGridView dataGridViewControl;
        private bool valueIsChanged = false;
        private int rowIndexNum;

        public NumericUpDownRightEditingControl()
        {
            DecimalPlaces = 0; // default to no decimals
            TextAlign = HorizontalAlignment.Left;
            UpDownAlign = LeftRightAlignment.Right;
            Maximum = 999;
        }
        public object EditingControlFormattedValue
        {
            //Return Me.Value.ToString("#.##")
            get => Value.ToString("#"); // default to no decimals
            set
            {
                if (value is decimal)
                {
                    Value = decimal.Parse(Convert.ToString(value));
                }
            }

        }
        public object GetEditingControlFormattedValue(DataGridViewDataErrorContexts context)
        {
            return this.Value.ToString(CultureInfo.InvariantCulture); // Me.Value.ToString("#.##")
        }
        public void ApplyCellStyleToEditingControl(DataGridViewCellStyle dataGridViewCellStyle)
        {

            Font = dataGridViewCellStyle.Font;
            ForeColor = dataGridViewCellStyle.ForeColor;
            BackColor = dataGridViewCellStyle.BackColor;

        }
        public int EditingControlRowIndex
        {
            get => rowIndexNum;
            set => rowIndexNum = value;
        }
        public bool EditingControlWantsInputKey(Keys key, bool dataGridViewWantsInputKey)
        {
            // Let the NumericUpDown handle the keys listed.
            if (((key & Keys.KeyCode) == Keys.Left) || ((key & Keys.KeyCode) == Keys.Up) || ((key & Keys.KeyCode) == Keys.Down) || ((key & Keys.KeyCode) == Keys.Right) || ((key & Keys.KeyCode) == Keys.Home) || ((key & Keys.KeyCode) == Keys.End) || ((key & Keys.KeyCode) == Keys.PageDown) || ((key & Keys.KeyCode) == Keys.PageUp))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public void PrepareEditingControlForEdit(bool selectAll)
        {
            // No preparation needs to be done.
        }
        public bool RepositionEditingControlOnValueChange => false;

        public DataGridView EditingControlDataGridView
        {
            get => dataGridViewControl;
            set => dataGridViewControl = value;
        }
        public bool EditingControlValueChanged
        {
            get => valueIsChanged;
            set => valueIsChanged = value;
        }
        Cursor IDataGridViewEditingControl.EditingPanelCursor => this.EditingControlCursor;

        public Cursor EditingControlCursor => base.Cursor;

        protected override void OnValueChanged(EventArgs e)
        {
            // Notify the DataGridView that the contents of the cell have changed.
            valueIsChanged = true;
            EditingControlDataGridView.NotifyCurrentCellDirty(true);
            base.OnValueChanged(e);
        }
    }
}
