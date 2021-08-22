namespace assignment_4
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public Person()
        {
            // no argument constructor
        }

        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public override string ToString()
        {
            return "Name : " + Name + "\n" +
            "Surname : " + Surname + "\n";
        }
    }
}