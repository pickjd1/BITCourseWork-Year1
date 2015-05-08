using System;


namespace FirstArray
{
    class FirstArray
    {
        static void Main()
        {
            int[] numbers = new int[10];
            int data;
            Random rand = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                data = rand.Next(10);
                numbers[i] = data;
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("Here is your random array");
            Console.ReadLine();
        }
    }
}
