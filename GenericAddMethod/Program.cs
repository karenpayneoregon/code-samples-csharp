using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LanguageExtensionsLibrary;
using static GenericAddMethod.MockedData;

namespace GenericAddMethod
{
    /// <summary>
    /// Using a language extension method which must implement an Interface
    /// There are two methods for creating a list of person, first is clinical meaning
    /// not real world while the second is more realistic and most likely done in a loop or for statement
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Distinct by first and last name where class must implement an Interface");
            Console.WriteLine();

            /*
             * Get distinct demo items by first and last name
             */
            var distinctPeople = GetPeople2().DistinctBy(person => new
            {
                person.FirstName, person.LastName
            });

            /*
             * Display results
             */
            foreach (var person in distinctPeople)
            {
                Console.WriteLine(person.OutputName());
            }


            Console.ReadLine();

        }


    }
}
