using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication41
{
    class Program
    {
        static void Main()
        {
            string user;
            Console.Write("\nEnter string here ");
            user = Console.ReadLine();
            string[] split = user.Split();

            foreach (string item in split)
            {
                Console.Write("\n "+item);
            }


            Console.Read();

        }
    }
}
