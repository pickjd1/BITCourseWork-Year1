using System;


namespace NestedForLoop
{
    class Lab14NestedForLoopAsterickRectangle
    {
        static void Main()
        {
            for (int row = 0; row < 3; row ++)
            {
                for (int col = 0; col < 5; col++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
