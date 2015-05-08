/*
 Sample: Demonstrating Calculations in VS
 Author: Joel Pickworth
 Date: 27/07/2012
 */

using System;

namespace ConsoleApplication3
{
    class AgeCalculator
    {
        static void Main()
        {
            int AgeDays;
            string age;
            Console.Write("Please enter your age.");
            age = Console.ReadLine();
            AgeDays = Convert.ToInt32(age);
            Console.WriteLine("You have been alive for " + AgeDays * 356 + " days");
            Console.WriteLine("This means you have been alive for " + AgeDays * 356 * 24 +" hours");
            Console.Read();
        }
    }
}
