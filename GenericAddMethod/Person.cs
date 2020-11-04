using LanguageExtensionsLibrary;

namespace GenericAddMethod
{
    public class Person : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; } 
        /// <summary>
        /// Display id, first and last name
        /// </summary>
        /// <returns></returns>
        public string OutputName()
        {
            return $"\t{Id} {FirstName} {LastName}";
        }
    }
}