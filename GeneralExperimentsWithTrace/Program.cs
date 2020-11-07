using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Configuration.ConfigurationManager;
using LogLibrary;

namespace GeneralExperimentsWithTrace
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.ApplicationExit += Application_ApplicationExit;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ApplicationTraceListener.Instance.CreateLog(AppSettings["SidesListenerLogName"], AppSettings["SidesListenerName"]);
            ApplicationTraceListener.Instance.WriteToTraceFile = true;
            Application.Run(new Form1());
        }

        private static void Application_ApplicationExit(object sender, EventArgs e)
        {
            ApplicationTraceListener.Instance.Close();
        }
    }
}
