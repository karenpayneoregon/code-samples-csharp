using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfControlExtensions.Classes
{
    public static class WindowHelpers
    {

        /// <summary>
        /// Clear TextBox controls in a container
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="control"></param>
        public static void ClearTextBoxes<T>(this DependencyObject control)
        {
            foreach (var textBox in Descendants<TextBox>(control))
            {
                textBox.Text = "";
            }
        }
        public static void ClearLabels<T>(this DependencyObject control)
        {
            foreach (var textBox in Descendants<Label>(control))
            {
                textBox.Content = "";
            }
        }
        public static void ClearLabels<T>(this DependencyObject control, string defaultValue)
        {
            foreach (var textBox in Descendants<Label>(control))
            {
                textBox.Content = defaultValue;
            }
        }
        /// <summary>
        /// For demonstration 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="control"></param>
        public static void ResetLabels<T>(this DependencyObject control)
        {
            int index = 1;

            foreach (var label in Descendants<Label>(control))
            {
                label.Content = index;

                label.Foreground = ColorHelpers.ColorToSolidColorBrush(System.Drawing.Color.Yellow); 
                label.Background = ColorHelpers.ColorToSolidColorBrush(System.Drawing.Color.Brown); 
                label.FontWeight = FontWeights.Bold;

                index += 1;
            }

        }
        /// <summary>
        /// Enable or disable all check boxes in a container
        /// </summary>
        /// <param name="control"></param>
        /// <param name="enable"></param>
        public static void EnableCheckBoxes(this DependencyObject control, bool enable = false)
        {
            foreach (var checkBox in Descendants<CheckBox>(control))
            {
                checkBox.IsEnabled = enable;
            }
        }
        /// <summary>
        /// Enable or disable all CheckBox controls excluding one
        /// specified in excludeName parameter.
        /// </summary>
        /// <param name="control">Parent control</param>
        /// <param name="enable">true, false</param>
        /// <param name="excludeName">Exclude this control</param>
        /// <remarks>
        /// An adaptation could be having the last parameter an
        /// array of CheckBox names.
        /// </remarks>
        public static void EnableCheckBoxesSpecial(this DependencyObject control, bool enable, string excludeName)
        {
            foreach (var checkBox in Descendants<CheckBox>(control))
            {
                if (checkBox.Name != excludeName)
                {
                    checkBox.IsEnabled = enable;
                }
            }
        }

        /// <summary>
        /// Enable or disable a TextBox in a container 
        /// 
        /// If Tag = R (need a better indicator) this TextBox  IsReadOnly is excluded as it's
        /// a read only TextBox always per business rules.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="control"></param>
        /// <param name="enable"></param>
        public static void EnableTextBoxes<T>(this DependencyObject control, bool enable = false)
        {
            foreach (var textBox in Descendants<TextBox>(control))
            {
                if (textBox.Tag?.ToString() == "R")
                {
                    continue;
                }

                textBox.IsReadOnly = enable;

                textBox.Background = textBox.IsReadOnly ?
                    new SolidColorBrush(Color.FromArgb(255, 240, 240, 240)) :
                    Brushes.White;
            }
        }
        /// <summary>
        /// Obtain the first enabled of T.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="control"></param>
        /// <returns></returns>
        public static TextBox EnableFirst<T>(this DependencyObject control)
        {
            return Descendants<TextBox>(control).FirstOrDefault(item => item.IsEnabled == true);
        }

        /// <summary>
        /// By setting Width this prevents horizontal resizing
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="control"></param>
        /// <param name="width"></param>
        /// <remarks>
        /// Tag = A where A means nothing, need to have a better indicator
        /// </remarks>
        public static void SetTextBoxUniversalWidth<T>(this DependencyObject control, int width = 32)
        {
            foreach (var textBox in Descendants<TextBox>(control))
            {
                if (textBox.Tag?.ToString() == "A")
                {
                    textBox.Width = width;
                }
            }
        }
        /// <summary>
        /// Get all controls in a container
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        public static List<Control> AllControls(this DependencyObject control) =>
            Descendants<Control>(control).ToList();

        /// <summary>
        /// Get all TextBox controls in a container
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        public static List<TextBox> TextBoxList(this DependencyObject control) =>
            Descendants<TextBox>(control).ToList();

        /// <summary>
        /// Get all TextBoxBlock controls in a container
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        public static List<TextBlock> TextBoxBlockList(this DependencyObject control) =>
            Descendants<TextBlock>(control).ToList();

        /// <summary>
        /// Get all CheckBox controls in a container
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        public static List<CheckBox> CheckBoxList(this DependencyObject control) => Descendants<CheckBox>(control).ToList();
        public static List<Label> LabelList(this DependencyObject control) => Descendants<Label>(control).ToList();

        /// <summary>
        /// Get all checked CheckBox controls in a container
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        public static List<CheckBox> CheckBoxListChecked(this DependencyObject control) =>
            control.CheckBoxList().Where(checkBox => checkBox.IsChecked == true).ToList();

        /// <summary>
        /// Determine if any CheckBoxes are checked in container
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        public static bool CheckListAnyChecked(this DependencyObject control) =>
            control.CheckBoxListChecked().Any();

        /// <summary>
        /// Get all ComboBox controls in a container
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        public static List<ComboBox> ComboBoxList(this DependencyObject control) =>
            Descendants<ComboBox>(control).ToList();

        /// <summary>
        /// Get all RadioButton controls in container
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        public static List<RadioButton> RadioList(this DependencyObject control) =>
            Descendants<RadioButton>(control).ToList();

        /// <summary>
        /// Get all checked RadioButton controls that are checked
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        public static List<RadioButton> RadioListAreChecked(this DependencyObject control) =>
            Descendants<RadioButton>(control)
                .Where(radioButton => radioButton.IsChecked == true).ToList();

        /// <summary>
        /// Get selected RadioButton in a specific group
        /// </summary>
        /// <param name="control"></param>
        /// <param name="groupName">Group name</param>
        /// <returns></returns>
        public static RadioButton SelectedRadioButtonInGroup(this DependencyObject control, string groupName) =>
            Descendants<RadioButton>(control)
                .FirstOrDefault(radioButton =>
                    radioButton.IsChecked == true && radioButton.GroupName == groupName);

        public static IEnumerable<T> Descendants<T>(DependencyObject dependencyItem) where T : DependencyObject
        {
            if (dependencyItem != null)
            {
                for (var index = 0; index < VisualTreeHelper.GetChildrenCount(dependencyItem); index++)
                {
                    var child = VisualTreeHelper.GetChild(dependencyItem, index);
                    if (child is T dependencyObject)
                    {
                        yield return dependencyObject;
                    }

                    foreach (var childOfChild in Descendants<T>(child))
                    {
                        yield return childOfChild;
                    }
                }
            }
        }
    }
}