using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication46
{
    class Program
    {
        static void Main(string[] args)
        {
            string userBday;
            int day, month, year;
            
            Console.WriteLine("Enter your birth date in this form -> dd/mm/yyyy ");
            userBday = Console.ReadLine();

            string result = userBday.Substring(0,2);
            string result2 = userBday.Substring(3,2);
            string result3 = userBday.Substring(6,4);


            Console.WriteLine(result);
            day = int.Parse(result);
            
            Console.WriteLine(result2);
            month = int.Parse(result2);
            
            Console.WriteLine(result3);
            year = int.Parse(result3);
            





            Console.Read();
        }
    }
}
