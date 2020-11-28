using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CheckBoxMeddling
{
    public static class GenericExtensions
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
        public static List<CheckBox> DescendantsOfCheckBoxes(this Control sender)
        {
            return sender.Descendants<CheckBox>().ToList();
        }
    }
}