using System;

namespace Variables
{
    class WhoRU
    {
        static void Main()
        {
            int dunedinTime;
            string aValue, name;
            Console.Write("Who are you?");
            name = Console.ReadLine();
            Console.WriteLine("How have you been in Dunedin?");
            aValue = Console.ReadLine();
            dunedinTime = Convert.ToInt32(aValue);
            Console.WriteLine("Hello " + name);
            Console.WriteLine(dunedinTime + " years is long enough to get a feel for the place");
            Console.WriteLine("I hope you like it");
            Console.Read();
        }
    }
}
