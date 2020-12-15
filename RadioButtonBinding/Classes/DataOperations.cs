using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioButtonBinding.Classes
{
    public class DataOperations
    {
        /// <summary>
        /// Read mocked data, for a real app the code would
        /// read from a database table into a list
        /// </summary>
        /// <returns></returns>
        public static List<Person> ReadPeople()
        {
            return Mocked.PeopleList;
        }

        /// <summary>
        /// Do nothing, for a real app, update the person in a
        /// database table
        /// </summary>
        /// <param name="person"></param>
        public static void UpdatePerson(Person person)
        {
            Console.WriteLine();
        }
    }
}
