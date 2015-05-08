//First Program Written in VS
   /*
    Sample: Demonstrating C#
    Author: Joel Pickworth
    Date: 19/07/2012
    */

using System;

namespace FirstProgramme
{
    class HelloWorld
    {
        static void Main()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Hello World");
            Console.WriteLine("////////////////\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\");
            Console.WriteLine("Joel Pickworth");
            Console.WriteLine("Mornington, Dunedin");
            Console.WriteLine("Programming 1");
            Console.WriteLine("////////////////\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\");
            Console.WriteLine(2.3456 + 1);
            Console.Write("what goes\nup\nmust come \tdown\n");
            Console.WriteLine("////////////////\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\");
            Console.Read()
        }
    }
}
