/*
Author: Alejandro Sanchez
Date: 1/31/2023
Description: C# Listing even or odd numbers between 0 and chosen number
 */
using System;
namespace Deliverable_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter an interger number between 1 and 100: ");
                int input = int.Parse(Console.ReadLine());

                Console.Write("Specify the series type: Even or Odd ");
                string series = Console.ReadLine();

                if (series == "Odd")
                {
                    Console.Write("You have selected the " + series + " series. The odd numbers between 0 and " + input + " are: ");
                    for (int i = 1; i <= input; i = i + 2)
                    {
                        Console.WriteLine(i);
                    }
                }
                if (series == "Even")
                {
                    Console.Write("You have selected the " + series + " series. The even numbers between 0 and " + input + " are: ");
                    for (int i = 0; i <= input; i = i + 2)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Error : Enter a number in interger form not word form");
            }
        }
    }
}