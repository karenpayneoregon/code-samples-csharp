using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SqlServerInsertNullDateFrontEnd.Helpers
{
    internal static class ConsoleHelpers
    {
        /// <summary>
        /// Provides an enhanced Console.ReadLine with a time out.
        /// </summary>
        /// <param name="timeout">Timeout</param>
        /// <returns>Input from a Task or if no input an empty string</returns>
        /// <remarks>
        /// Example, wait for two seconds
        /// ConsoleReadLineWithTimeout(TimeSpan.FromSeconds(2.5))
        /// 
        /// For more on working with TimeSpan
        /// https://docs.microsoft.com/en-us/dotnet/api/system.timespan?view=netframework-4.8
        /// 
        /// </remarks>
        public static void ConsoleReadLineWithTimeout(TimeSpan? timeout = null)
        {

            TimeSpan timeSpan = timeout ?? TimeSpan.FromSeconds(1);
            Task task = Task.Factory.StartNew(ReadLine);
            Task.WaitAny(new Task[] {task}, timeSpan);
        }
    }

}
