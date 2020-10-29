using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LogLibrary
{
    public sealed class SideTraceListener
    {
        private static readonly Lazy<SideTraceListener> Lazy =
            new Lazy<SideTraceListener>(() =>
                new SideTraceListener());

        public static SideTraceListener Instance => Lazy.Value;
        private static TextWriterTraceListener _textWriterTraceListener;

        public void CreateLog()
        {
            _textWriterTraceListener = new TextWriterTraceListener("applicationLog.txt", "PayneListener");
            Trace.Listeners.Add(_textWriterTraceListener);
        }
        /// <summary>
        /// Create new instance of trace listener
        /// </summary>
        /// <param name="fileName">From startup project app.config file to write too</param>
        /// <param name="listenerName">From startup project app.config unique name of listener</param>
        public void CreateLog(string fileName, string listenerName)
        {
            _textWriterTraceListener = new TextWriterTraceListener(fileName, listenerName);
            Trace.Listeners.Add(_textWriterTraceListener);
        }
        /// <summary>
        /// Get file name and full path to log file
        /// </summary>
        public string ListenerLogFileName()
        {

            if (_textWriterTraceListener == null) return "";

            var writer = (StreamWriter)_textWriterTraceListener.Writer;
            var stream = (FileStream)writer.BaseStream;

            return stream.Name;

        }

        public string ListenerName()
        {
            if (_textWriterTraceListener == null) return "";

            return _textWriterTraceListener.Name;
        }

        public void Flush()
        {
            if (_textWriterTraceListener == null) return;

            _textWriterTraceListener.Flush();

        }

        /// <summary>
        /// Write trace information to disk
        /// </summary>
        public void Close()
        {
            if (_textWriterTraceListener == null) return;

            _textWriterTraceListener.Flush();
            _textWriterTraceListener.Close();

        }
        public  void Exception(string message, [CallerMemberName] string callerName = null) => WriteEntry(message, "error", callerName);
        public  void Exception(Exception ex, [CallerMemberName] string callerName = null) => WriteEntry(ex.Message, "error", callerName);
        public  void Warning(string message, [CallerMemberName] string callerName = null) => WriteEntry(message, "warning", callerName);
        public  void Info(string message, [CallerMemberName] string callerName = null) => WriteEntry(message, "info", callerName);
        public  void EmptyLine() => _textWriterTraceListener.WriteLine("");
        public bool WriteToTraceFile { get; set; }
        private void WriteEntry(string message, string type, string callerName)
        {
            if (_textWriterTraceListener == null) return;
            if (!WriteToTraceFile) return;

            _textWriterTraceListener.Flush();
            _textWriterTraceListener.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss},{type},{callerName},{message}");
        }
    }
}
