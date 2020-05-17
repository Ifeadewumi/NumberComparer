using System.Text.RegularExpressions;
using System;

namespace NumberComparer
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;

            Console.Write("Enter the first (positive) number: ");
            firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter the second (positive) number: ");
            secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber < 0 )
            {
                Console.WriteLine(firstNumber + " is a negative number. This program only takes in positive numbers.");
            }
            else if (secondNumber < 0)
            {
                Console.WriteLine(secondNumber + " is a negative number. This program only takes in positive numbers.");
            }
            else
            {
                if (firstNumber > secondNumber)
                {
                    Console.WriteLine(firstNumber + " with square root " + Math.Sqrt(firstNumber) + 
                    " has a higher square root than " + secondNumber + " with square root " + Math.Sqrt(secondNumber) );
                }
                else if (firstNumber < secondNumber)
                {
                    Console.WriteLine(secondNumber + " with square root " + Math.Sqrt(secondNumber) + 
                    " has a higher square root than " + firstNumber + " with square root " + Math.Sqrt(firstNumber) );
                }
                else
                {
                    Console.WriteLine(firstNumber + " with square root " + Math.Sqrt(firstNumber) + 
                    " has the same square root than " + secondNumber + " with square root " + Math.Sqrt(secondNumber) );
                }
            }
        }
    }
}
