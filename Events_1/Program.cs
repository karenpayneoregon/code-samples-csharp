using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_1
{
    class Program
    {
        private static ConsoleColor _originalForeColor;
        static void Main(string[] args)
        {
            _originalForeColor = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Reading file");
            Console.ForegroundColor = _originalForeColor;
            Console.WriteLine();

            FileOperations.OnErrorHandler += FileOperations_OnErrorHandler;
            FileOperations.OnPersonAddedEvent += FileOperations_OnPersonAddedEvent;

            var people = FileOperations.ReadFile("people.txt");
            if (people.Count == FileOperations.LineCount)
            {
                Console.WriteLine("Got all people");
            }
            else
            {
                Console.WriteLine($"Got {FileOperations.LineCount}, skipped {FileOperations.SkippedLineCount}");
            }

            Console.ReadLine();
        }

        private static void FileOperations_OnPersonAddedEvent(Person sender)
        {
            Console.WriteLine($"Added: {sender}");
        }
        /// <summary>
        /// Display Exception message
        /// </summary>
        /// <param name="sender"></param>
        private static void FileOperations_OnErrorHandler(Exception sender, int lineNumber)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Sadly an exception occurred {sender.Message} on line {lineNumber}");
            Console.ForegroundColor = _originalForeColor;
        }
    }
}
