namespace assignment_3
{

    public class Officer : Person
    {
        public int OfficerID { get; set; }
        public int CrimesSolved { get; set; }

        public Officer()
        {
            // no argument constructor
        }

        public Officer(string name, string surname, int officerID, int crimesSolved) : base(name, surname)
        {
            CrimesSolved = crimesSolved;
            OfficerID = officerID;
        }

        public override string ToString()
        {
            return base.ToString() +
            "Officer ID : " + OfficerID + "\n" +
            "Crimes Solved : " + CrimesSolved + "\n" +
            "Level : " + this.calculatedLevel();
        }


        public int calculatedLevel()
        {
            if (CrimesSolved < 20)
                return 1;
            if (CrimesSolved < 40)
                return 2;
            else
                return 3;
        }
    }
}
