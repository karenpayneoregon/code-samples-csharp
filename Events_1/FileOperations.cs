using System;
using System.Collections.Generic;
using System.IO;
using ExceptionHandling;

namespace Events_1
{
    class FileOperations
    {
        /// <summary>
        /// Report exception to subscriber
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="lineNumber"></param>
        public delegate void OnError(Exception sender, int lineNumber);
        public static event OnError OnErrorHandler;

        /// <summary>
        /// Report new person added to list to subscriber
        /// </summary>
        /// <param name="sender"></param>
        public delegate void OnAddPerson(Person sender);
        public static event OnAddPerson OnPersonAddedEvent ;

        /// <summary>
        /// Line count in file
        /// </summary>
        public static int LineCount { get; set; }
        /// <summary>
        /// Count of lines not processed/skipped
        /// </summary>
        public static int SkippedLineCount { get; set; }
        /// <summary>
        /// Read csv file
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static List<Person> ReadFile(string fileName)
        {
            var people = new List<Person>();
            var currentLineNumber = 0;

            if (!File.Exists(fileName)) return people;

            var lines = File.ReadAllLines(fileName);

            LineCount = lines.Length;
            
            foreach (var line in lines)
            {
                currentLineNumber += 1;

                try
                {
                    var parts = line.Split(',');

                    /*
                     * The proper way to deal with this is to assert there are two elements,
                     * in this case the developer simply assumed there is a comma.
                     */
                    var person = new Person() { FirstName = parts[0], LastName = parts[1] };
                    
                    people.Add(person);

                    OnPersonAddedEvent?.Invoke(person);
                }
                catch (Exception ex)
                {
                    OnErrorHandler?.Invoke(ex, currentLineNumber);
                    Exceptions.Write(ex);
                    SkippedLineCount += 1;
                }
            }

            return people;
        }
    }
}