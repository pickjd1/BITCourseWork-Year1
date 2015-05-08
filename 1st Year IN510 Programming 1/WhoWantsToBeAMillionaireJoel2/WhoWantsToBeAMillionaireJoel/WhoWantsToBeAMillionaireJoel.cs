using System;
using System.IO;

namespace WhoWantsToBeAMillionaireJoel
{
    public struct Contestants
    {
        public string firstname;
        public string lastname;
        public string interests;
    }

    class WhoWantsToBeAMillionaireJoel
    {
        public static Contestants[] contestant = new Contestants[26];
        public static Contestants[] finalists = new Contestants[9];
        public static Contestants[] player = new Contestants[2];
        public static void Menu()
        {
            Console.Clear();
            string userchoice;
            int choice;
            Console.WriteLine("Please choose an option from the menu below: ");
            Console.WriteLine();
            Console.WriteLine("1)".PadRight(8) + "List the contestants");
            Console.WriteLine();
            Console.WriteLine("2)".PadRight(8) + "Locate contestant and update their interest field");
            Console.WriteLine();
            Console.WriteLine("3)".PadRight(8) + "Add contestant");
            Console.WriteLine();
            Console.WriteLine("4)".PadRight(8) + "Answer a Practice Question");
            Console.WriteLine();
            Console.WriteLine("5)".PadRight(8) + "Play Game!");
            Console.WriteLine();
            Console.WriteLine("6)".PadRight(8) + "Exit");

            userchoice = Console.ReadLine();
            choice = Convert.ToInt32(userchoice);

            if (choice == 1)
            {
                writeList();
            }
            else
            {
                if (choice == 2)
                {
                    Update();
                }
                else
                {
                    if (choice == 3)
                    {
                        Add();
                    }
                    else
                    {
                        if (choice == 4)
                        {
                            Practice();
                        }
                        else
                        {
                            if (choice == 5)
                            {
                                Game();
                            }
                            else
                            {
                                if (choice == 6)
                                {
                                    Exit();
                                }
                                else
                                {
                                    Console.WriteLine("You have entered an incorrect option");
                                }
                            }
                        }
                    }
                }
            }
            Console.ReadLine();
        }

        public static void sort()
        {
            Contestants temp;
            for (int i = 0; i < contestant.Length - 1; i++)
            {
                for (int pos = 0; pos < contestant.Length - 1; pos++)
                {
                    if (contestant[pos + 1].lastname.CompareTo(contestant[pos].lastname)<0)
                    {
                        temp = contestant[pos + 1];
                        contestant[pos + 1] = contestant[pos];
                        contestant[pos] = temp;
                    }
                }
            }
        }


        public static void readList()
        {
            int i = 0;
            Console.Clear();
            StreamReader sr = new StreamReader(@"H:\WhoWantsToBeAMillionaireJoel\Millionaire.txt");
            while (!sr.EndOfStream)
            {
                    contestant[i].lastname = sr.ReadLine();
                    contestant[i].firstname = sr.ReadLine();
                    contestant[i].interests = sr.ReadLine();
                    i++;
            }
           sr.Close();
        }

        public static void writeList()
        {
            Console.Clear();
            sort();
            for (int i = 0; i < contestant.Length; i++)
            {
                Console.WriteLine("{0} {1} {2}", contestant[i].firstname.PadRight(15), contestant[i].lastname.PadRight(15), contestant[i].interests);
                Console.WriteLine();
            }
            Console.WriteLine("Press any Key to return to the Menu: ");
            Console.ReadLine();
            Menu();
        }


        public static void Update()
        {
            Console.Clear();
            bool found = false;
            Console.WriteLine("Please enter the contestants name whose interest you would like to edit: ");
            string wanted = Console.ReadLine();
            for (int i = 0; i < contestant.Length; i++)
            {
                if (contestant[i].firstname == wanted)
                {
                    Console.WriteLine();
                    Console.WriteLine("{0} {1} {2} ",contestant[i].firstname.PadRight(15), contestant[i].lastname.PadRight(15), contestant[i].interests);
                    Console.WriteLine("Please enter the new interest of the contestant: ");
                    contestant[i].interests = Console.ReadLine();
                    Console.WriteLine("Thanks you {0}s interests have been updated",contestant[i].firstname);
                    found = true;
                }
            }
            if (found == false)
            {
                Console.WriteLine ("Unable to locate contestant.");
            }
            Console.WriteLine("Press any Key to return to the Menu:");
            Console.ReadLine();
            Menu();
        }


        public static void Add()
        {
            Console.Clear();
            Array.Resize(ref contestant, contestant.Length + 1);
        }


        public static void Practice()
        {
            Console.Clear();
        }


        public static void Game()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Who Wants to be a Millionaire!");
            Console.WriteLine("The Finalists for the show are about to be announced! Press any Key to see the results: ");
            Console.ReadLine();
            Finalists();
            Console.Clear();
            Console.WriteLine("Ok {0} lets begin: ");
            Console.WriteLine();
            Console.WriteLine("Your first question for $100 is: ");

        }


        public static void Exit()
        {
            char temp;
            Console.Clear();
            Console.WriteLine("Are you sure you want to Exit? Press y for yes or any other key to return to menu:");
            temp = Convert.ToChar(Console.ReadLine());
            if (temp != "n")
            {
                Menu();
            }
            else
            {

            }
        }


        public static void Finalists()
        {
            int temp, temp2;
            int[] final = new int [10];
            Random rand = new Random();
            temp = rand.Next(26);
            for (int i = 0; i < finalists.Length; i++)
            {
                temp = rand.Next(26);

                while ((temp == final[0]) || (temp == final[1]) || (temp == final[2]) || (temp == final[3]) || (temp == final[4]) || (temp == final[5]) || (temp == final[6]) || (temp == final[7]) || (temp == final[8]) || (temp == final[9]))
                {
                    temp = rand.Next(26);
                }
                final[i] = temp;
            }
                for (int i = 0; i < finalists.Length; i++)
                {
                    finalists[i] = contestant[final[i]];
                    Console.WriteLine("{0} {1} {2}", finalists[i].firstname.PadRight(15), finalists[i].lastname.PadRight(15), finalists[i].interests);
                }

                Console.WriteLine("Press any key to view the Final Player for the Game Show: ");
                Console.ReadLine();
                temp2 = rand.Next(1, 10);
                Console.WriteLine();
                Console.WriteLine("Congratulations {0} {1} you have been selected to play Who Wants to be a Millionaire!", finalists[temp2].firstname, finalists[temp2].lastname);
                Console.WriteLine();
                Console.WriteLine("Lets Play! Press any key to continue: ");
                Console.ReadLine();
        }

        public static void Greeting()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Welcome To Who Wants To Be A Millionaire");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue to the game menu: " );
            Console.ReadLine();
        }


        static void Main()
        {
            Greeting();
            Console.Clear();
            readList();
            Menu();
        }
    }
}
