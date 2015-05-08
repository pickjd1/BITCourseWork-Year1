using System;

namespace ConsoleApplication15
{
    class Lab11MemoryGame
    {
        static void Main()
        {
            int[] numbers = new int[7];
            int data, guess, i;
            string userNumber, userNumber2;

            Random rand = new Random();

            Console.WriteLine("Welcome to a simple game of memory, press any key to continue...");

            for (i = 0; i < numbers.Length; i++)
            {
                data = rand.Next(10);
                numbers[i] = data;
            }
            Console.WriteLine("Here are your random numbers, remember them as best you can:");
            for (i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine("Press any key to continue game...");
            Console.ReadLine();
            Console.Clear();
            for (i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Please enter the number you saw: ");
                userNumber = Console.ReadLine();
                guess = Convert.ToInt32(userNumber);
                do
                {
                    if (guess == numbers[i])
                    {
                        Console.WriteLine("Correct ");
                    }
                    else
                    {
                        if (guess != numbers[i])
                        {
                            Console.WriteLine("Incorrect");
                            userNumber2 = Console.ReadLine();
                            guess = Convert.ToInt32(userNumber2);
                        }
                    }

                } while (numbers[i] != guess);
            }
            Console.WriteLine("You Win, Well Done");
            Console.ReadLine();
 
        }
    }
}
