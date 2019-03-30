using System;
using System.Linq;

/* Write a program and ask the user to enter 5 numbers.
 If a number has been previously entered, display an error message 
 and ask the user to re-try. Once the user successfully enters 5 
 unique numbers, sort them and display the result on the console. */

namespace SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[5];

            Console.WriteLine("Enter first number");

            int num1 = int.Parse(Console.ReadLine());
            numbers[0] = num1;

            while (true)
            {
                Console.WriteLine("Enter second number");
                int num2 = int.Parse(Console.ReadLine());
                if (num2 == num1)
                {
                    Console.WriteLine("You entered that number before");
                }
                else
                {
                    numbers[1] = num2;
                    break;
                }
            }

            while (true)
            {
                Console.WriteLine("Enter third number");
                int num3 = int.Parse(Console.ReadLine());
                if (num3 == num1 || num3 == numbers[1])
                {
                    Console.WriteLine("You entered that number before");
                }
                else
                {
                    numbers[2] = num3;
                    break;
                }
            }

            while (true)
            {
                Console.WriteLine("Enter fourth number");
                int num4 = int.Parse(Console.ReadLine());
                if (num4 == num1 || num4 == numbers[1] || num4 == numbers[2])
                {
                    Console.WriteLine("You entered that number before");
                }
                else
                {
                    numbers[3] = num4;
                    break;
                }
            }

            while (true)
            {
                Console.WriteLine("Enter fifth number");
                int num5 = int.Parse(Console.ReadLine());
                if (num5 == num1 || num5 == numbers[1] || num5 == numbers[2] || num5 == numbers[3])
                {
                    Console.WriteLine("You entered that number before");
                }
                else
                {
                    numbers[4] = num5;
                    break;
                }
            }

            Array.Sort(numbers);

            Console.WriteLine("After sort: ");
            numbers.ToList().ForEach(Console.WriteLine);

            Console.ReadLine();
        }
    }
}
