using System;


namespace MarksArray2
{
    class MarksArray2
    {
        static void Main()
        {
            int[] marks = new int[5];
            int data, total = 0, average, i;
            string mark;
            Random rand = new Random();

            for (i = 0; i < marks.Length; i++)
            {
                Console.WriteLine ("Please enter a mark");
                mark = Console.ReadLine();
                data = Convert.ToInt32 (mark);
                marks[i] = data;
                total = total + data;
            }
            Console.WriteLine("Here are your marks:");
            for (i = 0; i < marks.Length; i++)
            {
                Console.WriteLine(marks[i]);
            }
            Console.WriteLine("The average mark is:");
            average = total / i;
            Console.WriteLine(average);
            Console.ReadLine();
        }
    }
}
