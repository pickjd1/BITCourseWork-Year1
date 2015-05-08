using System;


namespace Lab14
{ 
    class Lab14ExcelRowAndCol
    {
        static void Main()
        {
            for (int row = 1; row < 21; row++)
            {
                for (char col = 'A'; col < 'L'; col++)
                {
                    Console.Write("{0}{1} ",col,row);
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}