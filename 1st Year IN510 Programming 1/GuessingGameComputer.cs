using System;


namespace Lab9RaffleTickets
{
    class GuessingGame
    {
        static void Main()
        {
            int number, guess;
            string userNumber;
            Random rand = new Random();

            Console.WriteLine("Please pick a number between 1 and 10");
            userNumber = Console.ReadLine();
            number = Convert.ToInt32(userNumber);

                do
                {
                    guess = rand.Next(10);
                    Console.WriteLine(guess);

                    if (guess == number)
                    {
                        Console.WriteLine("I Win");
                    }
                    else
                    {
                        guess = rand.Next(10);
                        Console.WriteLine(guess);
                    }
                } while (number != guess);

                Console.ReadLine();
          
        }
    }
}
