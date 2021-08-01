using System;

namespace Task2_2
{

    class ExamLvl
    {
        static void Main(string[] args)
        {
            char grade;

            Console.WriteLine("Please enter your grade!");
            grade = Char.Parse(Console.ReadLine());
            switch (grade)
            {
                case 'A':
                case 'B':
                    Console.WriteLine("Perfect! You are so clever!");
                    break;
                case 'C':
                    Console.WriteLine("Good! But you can do better!");
                    break;
                case 'D':
                case 'E':
                    Console.WriteLine("It is not good! You should study!");
                    break;
                case 'F':
                    Console.WriteLine("Fail! You need to repeat the exam!");
                    break;
                default:
                    Console.WriteLine("Please enter a valid grade! A to F");
                    break;

            }
        }

    }
}


