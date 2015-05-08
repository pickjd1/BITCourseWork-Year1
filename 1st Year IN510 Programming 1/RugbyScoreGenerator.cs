using System;


namespace RugbyScoreGenerator
{
    class RugbyScoreGenerator
    {
        static void Main()
        {
            int team1, team2, i;

            Console.WriteLine("Game Begins");
            Random rand = new Random();

            for (int i = 0; i < 5; i++)
            {
                team1 = rand.Next(8);

                Console.WriteLine("Play One:");
                switch (team1)
                {
                    case 3:
                        Console.WriteLine("Team 1: Penalty Kick = 3");
                        break;

                    case 5:
                        Console.WriteLine("Team 1: Try Without Conversion = 5");
                        break;

                    case 7:
                        Console.WriteLine("Team 1: Try With Conversion = 7");
                        break;

                    default:
                        team1 = 0;
                        Console.WriteLine("Team 1: No score = 0");
                        break;
                }

                Console.WriteLine("Press any key for the next play:");
                Console.ReadLine();

                team2 = rand.Next(8);

                Console.WriteLine("Play Two:");
                switch (team2)
                {
                    case 3:
                        Console.WriteLine("Team 2: Penalty Kick = 3");
                        break;

                    case 5:
                        Console.WriteLine("Team 2: Try Without Conversion = 5");
                        break;

                    case 7:
                        Console.WriteLine("Team 2: Try With Conversion = 7");
                        break;

                    default:
                        team2 = 0;
                        Console.WriteLine("Team 2: No score = 0");
                        break;
                }
            }

            Console.WriteLine("Game Ends");
            Console.WriteLine("Press any key for the final result:");
            Console.ReadLine();
            if (team1 > team2)
            {
                Console.WriteLine("Team 1 Wins:");
            }
            else if (team1 == team2)
            {
                Console.WriteLine("It was Draw.");
            }
            else
            {
                Console.WriteLine("Team 2 wins:");
            }

            Console.WriteLine(team1 + " vs " + team2);
            Console.ReadLine();
        }
    }
}
