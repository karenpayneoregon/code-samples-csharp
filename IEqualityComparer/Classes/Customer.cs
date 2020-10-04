using System;

namespace IEqualityComparerApp.Classes
{
    public class Customer
    {
        public int CustomerIdentifier { get; set; }
        public string CompanyName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public int? CountryIdentfier { get; set; }
        public DateTime Joined { get; set; }
        public override string ToString() => $"{CustomerIdentifier}, {CompanyName}";

    }
}