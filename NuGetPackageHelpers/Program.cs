using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExceptionHandling;
using NuGetPackageHelpers.Forms;

namespace NuGetPackageHelpers
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.ThreadException += Application_ThreadException;
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

            Application.Run(new MainForm());
        }

        #region unhandled exceptions code

        private static string _fileName = "UnhandledException.txt";
        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            try
            {
                File.WriteAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _fileName), e.Exception.ToLogString(Environment.StackTrace));
            }
            catch (Exception)
            {
                // ignored
            }

            var f = new AppErrorForm();
            f.ShowDialog();

            Application.Exit();
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {

            try
            {
                File.WriteAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _fileName), (e.ExceptionObject as Exception).ToLogString(Environment.StackTrace));
            }
            catch (Exception)
            {
                // ignored
            }

            var errorForm = new AppErrorForm();
            errorForm.ShowDialog();

            Application.Exit();
        }

        #endregion
    }
}

