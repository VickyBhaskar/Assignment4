// See https://aka.ms/new-console-template for more information
using System;
namespace Assignment4
{
    internal class Program
    {
        static void Main(string[]args)
        {
            Console.Write("Enter a number: ");
            int number;
            string evenOdd;
            if (int.TryParse(Console.ReadLine(), out  number))
            {
                if (number > 0)
                {
                    Console.WriteLine("The number is positive.");
                }
                else if (number < 0)
                {
                    Console.WriteLine("The number is negative.");
                }
                else
                {
                    Console.WriteLine("The number is zero.");
                }

                // Check if the number is even or odd using the conditional operator
                if (number % 2 == 0)
                {
                    evenOdd = "even";
                }
                else
                {
                    evenOdd = "odd";
                }
                Console.WriteLine("The number is "+ evenOdd);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
    }
}
