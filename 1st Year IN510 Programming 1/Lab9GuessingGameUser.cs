using System;


namespace Lab9GuessingGameUser
{
    class GuessingGameUser
    {
        static void Main()
        {
            int number, guess, attempts = 1;
            string userNumber;
            Random rand = new Random();

            number = rand.Next(100);
            Console.WriteLine("I have a number between 1 and 100 please enter your guess: ");
            userNumber = Console.ReadLine();
            guess = Convert.ToInt32(userNumber);

            do
            {
                if (guess == number)
                {
                    Console.WriteLine("You Win in " + attempts + " attempt");
                }
                else
                {
                    if (guess > number)
                    {
                        Console.WriteLine("Your guess is too high, please try again: ");
                        userNumber = Console.ReadLine();
                        guess = Convert.ToInt32(userNumber);
                        attempts = attempts + 1;

                    }
                    else 
                    {
                        if (guess < number)
                        {
                            Console.WriteLine("Your guess is too low, please try again: ");
                            userNumber = Console.ReadLine();
                            guess = Convert.ToInt32(userNumber);
                            attempts = attempts + 1;

                        else 
                        {
                            if (attempts > 6)
                            {
                                Console.WriteLine("You have taken more than 6 attempts, please consider a more systematic approach.");
                            }
                        }

                        }
                    }
                }

            } while (number != guess);

            Console.WriteLine("You Win in " + attempts + " attempts");
            Console.ReadLine();

        }
    }
}
