using System;


namespace RugbyScoreGenerator
{
    class RugbyScoreGenerator
    {
        static void Main()
        {
            int team1, team2, team1a, team2a, team1b, team2b, team1c, team2c;

            Console.WriteLine("Game Begins");
            Random rand = new Random();

            team1a = rand.Next(8);

            Console.WriteLine("Play One:");
            switch (team1a)
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
                    Console.WriteLine("Team 1: No score = 0");
                    break;
            }

            Console.WriteLine("Press any key for the next play:");
            Console.ReadLine();

            team2a = rand.Next(8);

            Console.WriteLine("Play Two:");
            switch (team2a)
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
                    Console.WriteLine("Team 2: No score = 0");
                    break;
            }

            Console.WriteLine("Press any key for the next play:");
            Console.ReadLine();

            team1b = rand.Next(8);

            Console.WriteLine("Play Three:");
            switch (team1b)
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
                    Console.WriteLine("Team 1: No score = 0");
                    break;
            }

            Console.WriteLine("Press any key for the next play:");
            Console.ReadLine();

            team2b = rand.Next(8);

            Console.WriteLine("Play Four:");
            switch (team2b)
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
                    Console.WriteLine("Team 2: No score = 0");
                    break;
            }

            Console.WriteLine("Press any key for the next play:");
            Console.ReadLine();

            team1c = rand.Next(8);

            Console.WriteLine("Play Five:");
            switch (team1c)
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
                    Console.WriteLine("Team 1: No score = 0");
                    break;
            }

            Console.WriteLine("Press any key for the next play:");
            Console.ReadLine();

            team2c = rand.Next(8);

            Console.WriteLine("Play Six:");
            switch (team2c)
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
                    Console.WriteLine("Team 2: No score = 0");
                    break;
            }

            Console.WriteLine("Game Ends");
            team1 = team1a + team1b + team1c;
            team2 = team2a + team2b + team2c;
            Console.WriteLine("Press any key for the final result:");
            Console.ReadLine();
            if (team1 > team2)
            {
                Console.WriteLine("Team 1 Wins:");
            }
            else if (team1 == team2)
            {
                Console.WriteLine ("It was Draw.");
            }
            else 
            {
                Console.WriteLine ("Team 2 wins:");
            }

            Console.WriteLine(team1 + " vs " + team2);
            Console.ReadLine();
        }
    }
}
