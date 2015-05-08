using System;


namespace ConsoleApplication2
{
    class NumberAddition
    {
        static void Main()
        {     int firstnumber, secondnumber, result;
            string numberOne, numberTwo;
            Console.Write("Please enter a number.");
            numberOne = Console.ReadLine();
            firstnumber = Convert.ToInt32(numberOne);
            Console.WriteLine("Please enter another number.");
            numberTwo = Console.ReadLine();
            secondnumber = Convert.ToInt32(numberTwo);
            Console.WriteLine("Thank You");
            Console.WriteLine(numberOne + numberTwo  );
            Console.Read();
        }
    }
}
