using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace LogLibrary
{
    public static class Logger
    {
        private static TextWriterTraceListener _textWriterTraceListener;

        /// <summary>
        /// Initialize trace for logging.
        /// </summary>
        public static void CreateLog()
        {
            _textWriterTraceListener = new TextWriterTraceListener("applicationLog.txt", "PayneListener");
            Trace.Listeners.Add(_textWriterTraceListener);
        }
        /// <summary>
        /// Write trace information to disk
        /// </summary>
        public static void Close()
        {
            _textWriterTraceListener.Flush();
        }
        public static void Exception(string message, [CallerMemberName] string callerName = null) => WriteEntry(message, "error", callerName);
        public static void Exception(Exception ex, [CallerMemberName] string callerName = null) => WriteEntry(ex.Message, "error", callerName);
        public static void Warning(string message, [CallerMemberName] string callerName = null) => WriteEntry(message, "warning", callerName);
        public static void Info(string message, [CallerMemberName] string callerName = null) => WriteEntry(message, "info", callerName);
        public static void EmptyLine() => _textWriterTraceListener.WriteLine("");

        private static void WriteEntry(string message, string type, string callerName)
        {
            _textWriterTraceListener.WriteLine($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")},{type},{callerName},{message}");

        }
    }
}
