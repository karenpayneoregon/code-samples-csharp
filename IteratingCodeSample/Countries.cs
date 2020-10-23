using System;

namespace IteratingCodeSample
{
    public class Countries
    {
        public int CountryIdentifier { get; set; }
        public string Name { get; set; }
        public string[] ItemArray => new[]
        {
            Name,
            Convert.ToString(CountryIdentifier)
        };

        public override string ToString() => Name;

    }

}
