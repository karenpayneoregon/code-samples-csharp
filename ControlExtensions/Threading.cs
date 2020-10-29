using System;
using System.ComponentModel;

namespace ControlExtensions
{
    public static class Threading
    {
        /// <summary>
        /// Provides an easy way to deal with cross thread operations
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="control">Control to act on</param>
        /// <param name="action"></param>
        /// <code>
        /// In this example MonitorArgs in a custom class
        /// 
        /// private void FileOperations_OnMonitor(MonitorArgs args)
        /// {
        /// 	listBox1.InvokeIfRequired(lb =>
        /// 	{
        /// 		lb.Items.Add(args.Message);
        /// 		lb.SelectedIndex = lb.Items.Count - 1;
        /// 	});
        /// }
        /// </code>
        public static void InvokeIfRequired<T>(this T control, Action<T> action) where T : ISynchronizeInvoke
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new Action(() => action(control)), null);
            }
            else
            {
                action(control);
            }
        }
    }
}