using System;

namespace Task3
{

    class grades
    {
        static void Main(string[] args)
        {

            byte[] array = new byte[10];
            byte inputGrades = 0;


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Please enter a grade (" + (i + 1) + " of 10)!");
                while ((!Byte.TryParse(Console.ReadLine(), out inputGrades)) || inputGrades < 0 || inputGrades > 10)
                {
                    Console.WriteLine("Please enter a valid grade! (0 to 10)");
                }

                Console.WriteLine("The grade you entered is " + inputGrades);
                array[i] = inputGrades;
            }

            int studentsFailed = 0;
            int straightAStudent = 0;
            for (int i = 0; i < 10; i++)
            {
                if (array[i] < 4)
                    studentsFailed++;

                else if (array[i] == 10)
                    straightAStudent++;

            }
            Console.WriteLine("There are " + studentsFailed + " students who failed!");
            Console.WriteLine("There are " + straightAStudent + " students who had a 10!");

            int[] histogram = new int[11];
            for (int i = 0; i < 10; i++)
            {
                histogram[array[i]]++;
            }
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine($"{histogram[i]} students with the grade {i}!");
            }

            

        }
    }
}