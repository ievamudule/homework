namespace assignment_4
{
    public class Lawyer : Person
    {
        public int LawyerID { get; set; }
        public int HelpedInCrimesSolving { get; set; }

        public Lawyer()
        {
            // no-args constructor
        }

        public Lawyer(string name, string surname, int lawyerID, int helpedInCrimesSolving) : base(name, surname)
        {
            LawyerID = lawyerID;
            HelpedInCrimesSolving = helpedInCrimesSolving;
        }

        public override string ToString()
        {
            return base.ToString() +
            "Lawyer ID : " + LawyerID + "\n" +
           "Helped In Crimes Solving : " + HelpedInCrimesSolving + "\n";
        }
    }
}