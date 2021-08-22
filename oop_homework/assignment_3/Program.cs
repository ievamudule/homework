using System;
using System.Collections;

namespace assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Officer newOfficer1 = new Officer("Karl", "Smith", 30543, 27);
            Officer newOfficer2 = new Officer("John", "Smith", 30583, 15);
            Officer newOfficer3 = new Officer("Adam", "Smith", 30343, 40);
            Officer newOfficer4 = new Officer("Peter", "Smith", 30546, 210);
            Officer newOfficer5 = new Officer("Max", "Smithy", 30442, 13);
            Officer newOfficer6 = new Officer("Frank", "Smith", 30333, 0);
            Officer newOfficer7 = new Officer("Joe", "Smith", 30581, 64);

            Lawyer newLawyer1 = new Lawyer("Dereck", "Goldstein", 9999, 184);
            Lawyer newLawyer2 = new Lawyer("Paul", "Honeyberg", 6666, 10);
            Lawyer newLawyer3 = new Lawyer("Pete", "Greenfield", 1001, 87);

            District district98 = new District("District 98", "New York", 98);
            District district100 = new District("District 100", "New Jersey", 100);

            district98.addOfficerToDistrict(newOfficer1);
            district98.addOfficerToDistrict(newOfficer2);
            district98.addOfficerToDistrict(newOfficer3);
            district100.addOfficerToDistrict(newOfficer4);
            district100.addOfficerToDistrict(newOfficer5);
            district100.addOfficerToDistrict(newOfficer6);
            district100.addOfficerToDistrict(newOfficer7);

            Console.WriteLine(district98.ToString());
            Console.WriteLine(district100.ToString());

            Console.WriteLine("Lawyers:\n" + newLawyer1.ToString() + "\n" + newLawyer2.ToString() + "\n" + newLawyer3.ToString() + "\n");
            ArrayList lawyers = new ArrayList();
            lawyers.Add(newLawyer1);
            lawyers.Add(newLawyer2);
            lawyers.Add(newLawyer3);

            int numberOfCrimesLawyersHelpedSolving = 0;
            int maxNumberHelped = 0;
            Lawyer biggestHelper = new Lawyer();
            foreach (Lawyer lawyer in lawyers)
            {
                numberOfCrimesLawyersHelpedSolving += lawyer.HelpedInCrimesSolving;
                if (lawyer.HelpedInCrimesSolving > maxNumberHelped)
                {
                    maxNumberHelped = lawyer.HelpedInCrimesSolving;
                    biggestHelper = lawyer;
                }
            }
            
            Console.WriteLine("Lawyers were involved in " + numberOfCrimesLawyersHelpedSolving +
            " crimes solved\n");

            Console.WriteLine("Biggest helper is " + biggestHelper.Name + " " + biggestHelper.Surname +
            " with " + biggestHelper.HelpedInCrimesSolving + " crimes helped solving");
        }
    }
}
