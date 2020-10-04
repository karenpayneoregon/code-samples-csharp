namespace IEqualityComparerApp.Classes
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Person(int id, string name, string surname)
        {
            Id = id;
            Name = name;
            Surname = surname;
        }

        public override string ToString() => $"{Id} {Name} {Surname}";

    }
}