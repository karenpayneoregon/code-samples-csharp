using System;

namespace SqlServerInsertNullDate.Entities
{
    public class Employee
    {
        /// <summary>
        /// Primary key
        /// </summary>
        public int Id { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public DateTime? HiredDate { get; set; }
        public override string ToString() => Id.ToString();
    }
}
