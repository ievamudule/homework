using System;

namespace Task1_3
{

    class Dates
    {
        static void Main(string[] args)
        {
            int day;
            int month;
            int year;
            int dateForm;

            Console.WriteLine("Please write the day:");
            while (!Int32.TryParse(Console.ReadLine(), out day) || day < 1 || day > 31)
            {
                Console.WriteLine("Please enter a valid day number! (1 to 31)");
            }

            Console.WriteLine("Please write the month:");
            while (!Int32.TryParse(Console.ReadLine(), out month) || month < 1 || month > 12)
            {
                Console.WriteLine("Please enter a valid month number! (1 to 12)");

            }

            Console.WriteLine("Please write the year:");
            while (!Int32.TryParse(Console.ReadLine(), out year) || year < 1)
            {
                Console.WriteLine("Please enter a valid year number!");
            }

            Console.WriteLine("Please select the date formatting. 1 - YYYY/MM/DD, 2- YYYY.MM.DD:");
            while (!Int32.TryParse(Console.ReadLine(), out dateForm) || dateForm < 1 || dateForm > 2)
            {
                Console.WriteLine("Enter one of two possible choices - 1 or 2!");
            }

            if (dateForm == 1)
            {
                Console.WriteLine("Your date is " + year + "/" + month + "/" + day);
            }
            else
                Console.WriteLine("Your date is " + year + "." + month + "." + day);


        }
    }
}