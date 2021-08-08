using System;

namespace Task2
{

    class arrays
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 10, 4, -4, 7, 0, 9, 1, 3, 7, -5 };
            //array = new int[] { 10, 4, -4, 8, 0, 9, 1, 3, 7, -5 };
            int numberOfOddNumbers = 0;
            int sum = 0;
            double average;
            int belowAverage = 0;

            Console.WriteLine("The negative elements of the array are:");

            for (int i = 0; i < 10; i++)
            {

                if (array[i] < 0)
                {
                    Console.WriteLine(array[i]);
                }

            }
            Console.WriteLine("The odd elements of the array are:");

            for (int i = 0; i < 10; i++)
            {

                if (array[i] % 2 != 0)
                {
                    Console.WriteLine(array[i]);
                    numberOfOddNumbers++;

                }

            }

            Console.WriteLine("There are " + numberOfOddNumbers + " odd numbers in the array.");

            bool isDuplicate = false;
            for (int i = 0; i < 10; i++)
            {
                if (isDuplicate) break;
                for (int j = i + 1; j < 10; j++)
                {
                    if (array[i] == array[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }
            }
            if (isDuplicate)
            {
                Console.WriteLine("There are elements with the same value.");
            }
            else
            {
                Console.WriteLine("There are no elements with the same value.");
            }

            Console.WriteLine("Each second element:");
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(array[i]);
                }

            }
            Console.WriteLine("The average value of the array: ");
            for (int i = 0; i < 10; i++)
            {
                sum += array[i];

            }
            average = (double)sum / 10;

            Console.WriteLine(average);

            for (int i = 0; i < 10; i++)
            {
                if (array[i] < average)
                    belowAverage++;

            }
            Console.WriteLine("There are " + belowAverage + " elements that are below the average value of the array");


        }
    }
}
