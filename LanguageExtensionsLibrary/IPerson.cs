using System.Collections.Generic;

namespace LanguageExtensionsLibrary
{
    public interface IPerson
    {
        /// <summary>
        /// Primary key
        /// </summary>
        int Id { get; set; }
        /// <summary>
        /// First name
        /// </summary>
        string FirstName { get; set; }
        /// <summary>
        /// Last name
        /// </summary>
        string LastName { get; set; }
        string OutputName();

    }
}