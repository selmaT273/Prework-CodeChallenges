using System;
using System.Collections.Generic;

namespace prework_DSA
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayMaxResult();
            LeapYearCalculator();
        }

        private static void ArrayMaxResult()
        {
            Console.WriteLine("Please enter 5 whole numbers between 1 and 10.");
            string userInputArray = Console.ReadLine();

            Console.WriteLine($"You entered: {userInputArray}. " +
                              $"Type one of the numbers you entered.");
            string userInputNumber = Console.ReadLine();

            int numberSelected = int.Parse(userInputNumber);
            string[] eachNum = userInputArray.Split(' ');

            int counter = 0;

            foreach (string s in eachNum)
            {
                if(s == userInputNumber)
                {
                    counter++;
                }
            }

            int score = numberSelected * counter;

            Console.Write($"Your score is {score}");
        }

        private static void LeapYearCalculator()
        {
            Console.WriteLine("Enter a year to see if it is a leap year.");
            int year = int.Parse(Console.ReadLine());

            if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
            {
                Console.Write($" {year} is a leap year!");
            }
            else
            {
                Console.Write($"{year} is not a leap year.");
            }
        }
    }
}
