using System;
using System.Linq;

namespace CommandLineArguments
{
    /// <summary>
    /// For obtaining command line arguments
    /// </summary>
    /// <remarks>
    /// VB.NET version
    /// https://github.com/karenpayneoregon/visual-basic-getting-started/blob/master/MyApplicationNamespace/ApplicationEvents.vb
    /// </remarks>
    public class ApplicationHelper
    {
        /// <summary>
        /// Property to get command arguments minus argument 0 which is the
        /// path and executable name
        /// </summary>
        /// <returns>Command arguments if present</returns>
        public static string[] CommandLineArguments
        {
            get
            {
                var arguments = Environment.GetCommandLineArgs().
                    ToList().Select((arg) => arg.ToUpper()).
                    ToList();

                arguments.RemoveAt(0);
                return arguments.ToArray();
            }
        }

        public static bool IsAdminMode => HasCommandLineArguments && CommandLineArguments.Contains("-ADMIN");
        public static bool Refresh => HasCommandLineArguments && CommandLineArguments.Contains("-REFRESH");

        /// <summary>
        /// Are there arguments
        /// </summary>
        /// <returns>Count of command arguments sent on startup of application</returns>
        public static bool HasCommandLineArguments => CommandLineArguments.Length > 0;
        /// <summary>
        /// Get command line argument count
        /// </summary>
        public static int ArgumentCount => CommandLineArguments.Length;
    }
}