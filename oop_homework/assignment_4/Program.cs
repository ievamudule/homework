using System;
using System.Collections;

namespace assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Officer newOfficer1 = new Officer("Karl", "Smith", 30543, 17);
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

            district98.addPersonToDistrict(newOfficer1);
            district98.addPersonToDistrict(newLawyer1);
            district98.addPersonToDistrict(newOfficer2);
            district98.addPersonToDistrict(newLawyer2);
            district98.addPersonToDistrict(newOfficer3);

            district100.addPersonToDistrict(newOfficer4);
            district100.addPersonToDistrict(newOfficer5);
            district100.addPersonToDistrict(newLawyer3);
            district100.addPersonToDistrict(newOfficer6);
            district100.addPersonToDistrict(newOfficer7);


            Console.WriteLine(district98.ToString());
            Console.WriteLine(district100.ToString());

            ArrayList districts = new ArrayList();
            districts.Add(district98);
            districts.Add(district100);
            Console.WriteLine((district98.getNumberOfPeopleInDistrict() > district100.getNumberOfPeopleInDistrict() ? district98.Title : district100.Title)
            + " has more people\n");
        }
    }
}
