using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WPFControlsExtensions
{
    public static class GenericControlExtensions
    {
        /// <summary>
        /// Get a collection of a specific type of control from a control or form.
        /// </summary>
        /// <typeparam name="T">Type of control</typeparam>
        /// <param name="control">Control to traverse</param>
        /// <returns>IEnumerable of T</returns>
        public static IEnumerable<T> Descendants<T>(this Control control) where T : class
        {
            foreach (Control child in control.Controls)
            {
                T thisControl = child as T;
                if (thisControl != null)
                {
                    yield return (T)thisControl;
                }

                if (child.HasChildren)
                {
                    foreach (T descendant in Descendants<T>(child))
                    {
                        yield return descendant;
                    }
                }
            }

        }
        /// <summary>
        /// Get all TextBoxes in a control
        /// </summary>
        /// <param name="control">Control to iterate</param>
        /// <returns></returns>
        public static List<TextBox> TextBoxList(this Control control) => control.Descendants<TextBox>().ToList();
        /// <summary>
        /// Get all DataGridViews controls in a control
        /// </summary>
        /// <param name="control">Control to iterate</param>
        /// <returns></returns>
        public static List<DataGridView> DataGridViewList(this Control control) => control.Descendants<DataGridView>().ToList();
        /// <summary>
        /// Get all ListViews in a control
        /// </summary>
        /// <param name="control">Control to iterate</param>
        /// <returns></returns>
        public static List<ListView> ListViewViewList(this Control control) => control.Descendants<ListView>().ToList();
        /// <summary>
        /// Get all CheckBoxes in a control
        /// </summary>
        /// <param name="control">Control to iterate</param>
        /// <returns></returns>
        public static List<CheckBox> CheckBoxList(this Control control) => control.Descendants<CheckBox>().ToList();
        /// <summary>
        /// Get all ComboBoxes in a control
        /// </summary>
        /// <param name="control">Control to iterate</param>
        /// <returns></returns>
        public static List<ComboBox> ComboBoxList(this Control control) => control.Descendants<ComboBox>().ToList();
        /// <summary>
        /// Get all ListBoxes in a control
        /// </summary>
        /// <param name="control">Control to iterate</param>
        /// <returns></returns>
        public static List<ListBox> ListBoxList(this Control control) => control.Descendants<ListBox>().ToList();
        /// <summary>
        /// Get all DateTimePickers in a control
        /// </summary>
        /// <param name="control">Control to iterate</param>
        /// <returns></returns>
        public static List<DateTimePicker> DateTimePickerList(this Control control) => control.Descendants<DateTimePicker>().ToList();
        /// <summary>
        /// Get all PictureBoxes in a control
        /// </summary>
        /// <param name="control">Control to iterate</param>
        /// <returns></returns>
        public static List<PictureBox> PictureBoxList(this Control control) => control.Descendants<PictureBox>().ToList();
        /// <summary>
        /// Get all Panels in a control
        /// </summary>
        /// <param name="control">Control to iterate</param>
        /// <returns></returns>
        public static List<Panel> PanelList(this Control control) => control.Descendants<Panel>().ToList();
        /// <summary>
        /// Get all GroupBoxes in a control
        /// </summary>
        /// <param name="control">Control to iterate</param>
        /// <returns></returns>
        public static List<GroupBox> GroupBoxList(this Control control) => control.Descendants<GroupBox>().ToList();
        /// <summary>
        /// Get all Buttons in a control
        /// </summary>
        /// <param name="control">Control to iterate</param>
        /// <returns></returns>
        public static List<Button> ButtonList(this Control control) => control.Descendants<Button>().ToList();
        /// <summary>
        /// Get all NumericUpDown controls in a control
        /// </summary>
        /// <param name="control">Control to iterate</param>
        /// <returns></returns>
        public static List<NumericUpDown> NumericUpDownList(this Control control) => control.Descendants<NumericUpDown>().ToList();
        /// <summary>
        /// Get checked CheckBox if any from a control/container
        /// </summary>
        /// <param name="control">Control to iterate</param>
        /// <param name="pChecked">true or false</param>
        /// <returns></returns>
        public static RadioButton RadioButtonChecked(this Control control, bool pChecked = true) =>
            control.Descendants<RadioButton>().ToList()
                .FirstOrDefault((radioButton) => radioButton.Checked == pChecked);
        
        /// <summary>
        /// Get a list of RadioButtons 
        /// </summary>
        /// <param name="control">Control to iterate for RadioButtons</param>
        /// <returns></returns>
        public static List<RadioButton> RadioButtonList(this Control control) => control.Descendants<RadioButton>().ToList();
        /// <summary>
        /// Get control names for container e.g. a form, a GroupBox etc.
        /// </summary>
        /// <param name="controls">Control to iterate</param>
        /// <returns></returns>
        public static string[] ControlNames(this IEnumerable<Control> controls) => controls.Select((control) => control.Name).ToArray();
    }

}
