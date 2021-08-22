using System.Collections.Generic;
namespace assignment_4
{
    class District
    {
        private LinkedList<Person> peopleInDistrict = new LinkedList<Person>();

        public string Title { get; set; }
        public string City { get; set; }
        public int DistrictID { get; set; }

        public District()
        {
            // no argument constructor
        }

        public District(string title, string city, int districtID)
        {
            Title = title;
            City = city;
            DistrictID = districtID;
        }

        public void addPersonToDistrict(Person person)
        {
            this.peopleInDistrict.AddLast(person);
        }

        public void removePersonFromDistrict(Person person)
        {
            this.peopleInDistrict.Remove(person);
        }

        public int getNumberOfPeopleInDistrict()
        {
            return this.peopleInDistrict.Count;
        }

        public int getNumberOfOfficersInDistrict()
        {
            int countOfOfficers = 0;
            foreach (Person person in peopleInDistrict)
            {
                if (person == null)
                {
                    return 0;
                }
                if (person is Officer)
                {
                    countOfOfficers++;
                }
            }
            return countOfOfficers;
        }

        public int getNumberOfLawyersInDistrict()
        {
            int countOfLawyers = 0;
            foreach (Person person in peopleInDistrict)
            {
                if (person == null)
                {
                    return 0;
                }
                if (person is Lawyer)
                {
                    countOfLawyers++;
                }
            }
            return countOfLawyers;
        }

        public float calculateAvgLevelInDistrict()
        {

            int sum = 0;
            foreach (Person person in this.peopleInDistrict)
            {
                if (person == null)
                    break;
                if (person is Officer)
                {
                    sum += (person as Officer).calculatedLevel();
                }
            }
            return (float)sum / (float)this.getNumberOfOfficersInDistrict();

        }

        public override string ToString()
        {
            return Title + "\n" +
           "\tCity : " + City + "\n" +
           "\tDistrict ID : " + DistrictID + "\n" +
           "\tAvg Level in the district : " + calculateAvgLevelInDistrict() + "\n" +
           "\tNumber of officers : " + getNumberOfOfficersInDistrict() + "\n" +
           "\tNumber of lawyers : " + getNumberOfLawyersInDistrict() + "\n";
        }
    }
}