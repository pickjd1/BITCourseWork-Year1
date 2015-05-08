using System;

namespace Lab17AssignmentSkeleton
{
    class Lab17AssignmentSkeleton
    {
        static void Task1()
        {
            Console.WriteLine("This is Task 1");
        }
        static void Task2()
        {
            Console.WriteLine("This is Task 2");
        }

        static void Task3()
        {
            Console.WriteLine("This is Task 3");
        }

        static void Task4()
        {
            Console.WriteLine("This is Task 4");
        }

        static void Task5()
        {
            Console.WriteLine("This is Task 5");
        }

        static void Main()
        {          
            do 
            {
                Console.WriteLine("Main Menu: Enter the Task Number You Wish To Run:");
                Console.WriteLine("Key".PadRight(10));
                Console.WriteLine("Task".PadLeft(8));

                temp = Console.Read();
            } while(temp!=0);

            Console.ReadLine();
        }
    }
}
