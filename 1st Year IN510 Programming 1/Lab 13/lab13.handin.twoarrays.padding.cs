using System;

namespace ConsoleApplication45
{
    class Program
    {
        static void Main()
        {
            string[] names = { "Krissi", "Dale", "Bo", "Christopher" };
            double[] wealth = { 150000, 1000000, 5.66, 10 };

            Console.Write("Names".PadRight(12));
            Console.WriteLine("Wealth".PadLeft(8));

            for (int i = 0; i < names.Length; i++)
            {
                Console.Write(names[i].PadRight(12));
                Console.WriteLine(wealth[i].ToString().PadLeft(8));
            }
            Console.Read();
        }
    }
}
