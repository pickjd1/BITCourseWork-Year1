using System;

namespace IN510PracticalExam1JoelPickworth
{
    class IN510PracticalExam1JoelPickworth
    {
        static void Main()
        {
            int userTotal = 0, computerTotal = 0;
            int userRoll, computerRoll;
            Random rand = new Random();

            Console.WriteLine("Welcome to Snakes And Ladders: Press any key to begin game.");
            Console.Read();
            Console.WriteLine("Thank you. Game Starts: Player One Vs Computer");
            Console.WriteLine();

            do
            {
                Console.WriteLine();
                Console.WriteLine("It is your turn: press any key to roll the dice");
                Console.ReadLine();
                Console.WriteLine();
                userRoll = rand.Next(1,6);
                Console.WriteLine("You have rolled a " + userRoll);
                userTotal = userTotal + userRoll;

                switch (userTotal)
                {
                    case 5:
                        Console.WriteLine("You have landed on a snake, you lose 2 spaces");
                        Console.WriteLine("You are now on 3");
                        userTotal = userTotal - 2;
                        break;

                    case 10:
                        Console.WriteLine("You have landed on a snake, you lose 2 spaces");
                        Console.WriteLine("You are now on 8");
                        userTotal = userTotal - 2;
                        break;

                    case 15:
                        Console.WriteLine("You have landed on a snake, you lose 2 spaces");
                        Console.WriteLine("You are now on 13");
                        userTotal = userTotal - 2;
                        break;

                    case 20:
                        Console.WriteLine("You have landed on a snake, you lose 2 spaces");
                        Console.WriteLine("You are now on 18");
                        userTotal = userTotal - 2;
                        break;

                    case 25:
                        Console.WriteLine("You have landed on a snake, you lose 2 spaces");
                        Console.WriteLine("You are now on 23");
                        userTotal = userTotal - 2;
                        break;

                    case 30:
                        Console.WriteLine("You have landed on a snake, you lose 2 spaces");
                        Console.WriteLine("You are now on 28");
                        userTotal = userTotal - 2;
                        break;


                    default:
                        Console.WriteLine("You are on " + userTotal);
                        break;

                }
                Console.WriteLine();
                Console.WriteLine("It is the computers turn:");
                Console.WriteLine();
                computerRoll = rand.Next(1,6);
                Console.WriteLine("The computer has rolled a " + computerRoll);
                computerTotal = computerTotal + computerRoll;

                switch (userTotal)
                {
                    case 5:
                        Console.WriteLine("The computer has landed on a snake, it loses 2 spaces");
                        Console.WriteLine("The computer is now on 3");
                        computerTotal = computerTotal - 2;
                        break;

                    case 10:
                        Console.WriteLine("The computer has landed on a snake, it loses 2 spaces");
                        Console.WriteLine("The computer is now on 8");
                        computerTotal = computerTotal - 2;
                        break;

                    case 15:
                        Console.WriteLine("The computer has landed on a snake, it loses 2 spaces");
                        Console.WriteLine("The computer is now on 13");
                        computerTotal = computerTotal - 2;
                        break;

                    case 20:
                        Console.WriteLine("The computer has landed on a snake, it loses 2 spaces");
                        Console.WriteLine("The computer is now on 18");
                        computerTotal = computerTotal - 2;
                        break;

                    case 25:
                        Console.WriteLine("The computer has landed on a snake, it loses 2 spaces");
                        Console.WriteLine("The computer is now on 23");
                        computerTotal = computerTotal - 2;
                        break;

                    case 30:
                        Console.WriteLine("The computer has landed on a snake, it loses 2 spaces");
                        Console.WriteLine("The computer is now on 28");
                        userTotal = userTotal - 2;
                        break;

                    default:
                        Console.WriteLine("The computer is on " + computerTotal);
                        break;

                }

            } while(computerTotal<31 || userTotal<31);
            Console.WriteLine();

            if (userTotal > 31)
            {
                Console.WriteLine("Player One Wins");
            }
            else
            {
                Console.WriteLine("Computer Wins");
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to exit:");
            Console.Read();
        }
    }
}
