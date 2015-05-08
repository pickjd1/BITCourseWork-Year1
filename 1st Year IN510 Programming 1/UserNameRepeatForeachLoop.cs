using System;

namespace ConsoleApplication16
{
    class UserNameRepeatForeachLoop
    {
        static void Main()
        {
            string name;

            Console.WriteLine("Please enter Your Name: ");
            name = Console.ReadLine();

            foreach (char i in name)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
