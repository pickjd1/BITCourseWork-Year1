using System;


namespace Lab14
{
    class Lab14NestedForLoopAsterickTriangle
    {
        static void Main()
        {
            for (int row = 0; row < 6; row++)
            {
                for (int col = 0; col < row; col++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}