using System;

namespace IteratingCodeSample.Classes
{
    public class Countries
    {
        public int CountryIdentifier { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// Provides easy way to add a country to a ListView
        /// </summary>
        public string[] ItemArray => new[]
        {
            Name,
            Convert.ToString(CountryIdentifier)
        };

        public override string ToString() => Name;

    }

}
