using System;
using System.Collections.Generic;
using System.Linq;

namespace prework_DSA
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayMaxResult();
            //LeapYearCalculator();
            PerfectSequence();
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

        private static void PerfectSequence()
        {
            int[] array1 = { 1, 2, -1 };
            int[] array2 = { 1, 2, 3 };
            int[] array3 = { 0, 0, 0 };
            int[] array4 = { 3, 6, 9 };

            int sum = 0;
            int product = 1;

            foreach(int num in array2)
            {
                sum = sum + num;
                product = product * num;
            }

            Console.WriteLine(sum);
            Console.WriteLine(product);

            if (sum == product)
            {
                Console.Write("Yes");
            } else
            {
                Console.Write("No");
            }
        }
    }
}
