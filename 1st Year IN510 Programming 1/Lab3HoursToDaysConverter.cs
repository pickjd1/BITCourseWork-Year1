using System;

namespace Lab3HoursToDaysConverter
{
    class Lab3HoursToDaysConverter
    {
        static void Main()
        {
            int totalHours, days, hours;
            string temp;

            Console.WriteLine("Please enter the number of hours you wish to convert into days.");

            temp = Console.ReadLine();
            totalHours = Convert.ToInt32(temp);
            days = (totalHours / 24);
            hours = ((totalHours % 24));

            Console.WriteLine("Thank You. This equals " + days + " days " + hours + " hours");
            Console.ReadLine();

        }
    }
}
