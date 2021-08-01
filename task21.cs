using System;

namespace Task2_1
{

    class Days
    {
        static void Main(string[] args)
        {
            int weekDay;
            Console.WriteLine("Please enter a day number in the week!");

            while (!Int32.TryParse(Console.ReadLine(), out weekDay) || weekDay < 1 || weekDay > 7)
            {
                Console.WriteLine("Please enter a valid day number - 1 to 7!");
            }


            switch (weekDay)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("It is a working day");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("It is holiday");
                    break;
            }

        }

    }

}