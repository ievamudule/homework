using System;

namespace Task2_3
{

    class Calculate
    {
        static void Main(string[] args)
        {
            int value1;
            int value2;

            Console.WriteLine("Please enter value 1");
            Int32.TryParse(Console.ReadLine(), out value1);
            Console.WriteLine("Please enter value 2");
            Int32.TryParse(Console.ReadLine(), out value2);

            Console.WriteLine("Please enter a mathematical operation (+ for sum, - for subtraction, / for dividing, * for multiplication, & for remainder when the first value is devided by the second, p for printing put both elements, b for verifying the bigger one and s for the smaller one)!");
            char operation = Char.Parse(Console.ReadLine());

            switch (operation)
            {
                case '+':
                    int sum = value1 + value2;

                    Console.WriteLine("The result is " + sum);
                    break;
                case '-':
                    int subtraction = value1 - value2;
                    Console.WriteLine("The result is " + subtraction);
                    break;
                case '/':
                    int division = value1 / value2;
                    Console.WriteLine("The result is " + division);
                    break;

                case '*':
                    int multiplication = value1 * value2;
                    Console.WriteLine("The result is " + multiplication);
                    break;
                case '%':
                    int remainder = value1 % value2;
                    Console.WriteLine("The result is " + remainder);
                    break;

                case 'p':
                    Console.WriteLine("Your elements are  " + value1 + " and " + value2);
                    break;

                case 'b':
                    int max = Math.Max(value1, value2);
                    Console.WriteLine("The result is " + max);
                    break;

                case 's':
                    int min = Math.Min(value1, value2);
                    Console.WriteLine("The result is " + min);
                    break;


            }

        }
    }
}

