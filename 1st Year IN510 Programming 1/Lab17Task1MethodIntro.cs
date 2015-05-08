using System;

namespace Lab17Task1MethodIntro
{
    class Lab17Task1MethodIntro
    {
        static void SecondMethod()
        {
            FirstMethod();
            Console.WriteLine("This is method two.");
        }

        static void FirstMethod()
        {
            Console.WriteLine("This is method one.");
        }
        static void Main()
        {
            SecondMethod();
            Console.ReadLine();
        }
    }
}
