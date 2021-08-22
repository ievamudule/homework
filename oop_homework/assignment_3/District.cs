using System.Collections.Generic;
namespace assignment_3
{
    class District
    {
        private LinkedList<Officer> officersInDistrict = new LinkedList<Officer>();

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
        public void addOfficerToDistrict(Officer officer)
        {
            this.officersInDistrict.AddLast(officer);
        }

        public void removeOfficerFromDistrict(Officer officer)
        {
            this.officersInDistrict.Remove(officer);
        }

        public int getNumberOfOfficerInDistrict()
        {
            return this.officersInDistrict.Count;
        }

        public float calculateAvgLevelInDistrict()
        {
            int sum = 0;
            foreach (Officer officer in this.officersInDistrict)
            {
                if (officer == null)
                    break;
                sum += officer.calculatedLevel();
            }
            return (float)sum / (float)this.getNumberOfOfficerInDistrict();
        }

        public override string ToString()
        {
            return Title + "\n" +
           "\tCity : " + City + "\n" +
           "\tDistrict ID : " + DistrictID + "\n" +
           "\tAvg Level in the district : " + calculateAvgLevelInDistrict() + "\n" +
           "\tNumber of officers : " + getNumberOfOfficerInDistrict() + "\n";
        }
    }
}