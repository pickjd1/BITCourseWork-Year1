using System;

namespace ConsoleApplication17
{
    class UserNameRepeatForLoop
    {
        static void Main()
        {
            string name;

            Console.WriteLine("Please enter Your Name: ");
            name = Console.ReadLine();

            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            Console.ReadLine();
        }
    }
}
