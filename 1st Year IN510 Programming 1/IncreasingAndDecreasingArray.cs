using System;
using System.IO;
namespace IncreasingAndDecreasingArray
{
    public struct Icecreams
    {
        public string name;
        public string brand;
        public string decade;

    }
    class IncreasingAndDecreasingArray
    {
        public static Icecreams[] icecream = new Icecreams[22];

        public static void readText()
        {
            int i = 0;
            StreamReader sr = new StreamReader(@"H:\icecream.txt");
            while (!sr.EndOfStream)
            {
                icecream[i].name = sr.ReadLine();
                icecream[i].brand = sr.ReadLine();
                icecream[i].decade = sr.ReadLine();
                i++;
            }
            sr.Close();
        }

        public static void writeText()
        {
            for(int i = 0; i < icecream.Length; i++)
            {
                Console.WriteLine("{0} {1} {2}", icecream[i].name.PadRight(20), icecream[i].brand.PadRight(10), icecream[i].decade);
            }
        }

        public static void increaseArray()
        {
            Array.Resize(ref icecream, icecream.Length + 2);

        }

        public static void search()
        {
            bool found = false;
            Console.WriteLine("Please enter the brand you would like to display: ");
            string wanted = Console.ReadLine();
            
            for (int i = 0; i < icecream.Length; i++)
            {
                if (icecream[i].brand == wanted)
                {
                    Console.WriteLine();
                    Console.WriteLine("{0} Created {1} in {2} ",icecream[i].brand, icecream[i].name.PadRight(5), icecream[i].decade);
                    found = true;
                }
            }
            if (found == false)
            {
                Console.WriteLine ("Unable to locate brand.");
            }

        }

        public static void search2()
        {
            bool found = false;
            Console.WriteLine("Please enter the decade you would like to display: ");
            string wanted = Console.ReadLine();

            for (int i = 0; i < icecream.Length; i++)
            {
                if (icecream[i].decade == wanted)
                {
                    Console.WriteLine();
                    Console.WriteLine("In {0} {1} created {2} ", icecream[i].decade, icecream[i].brand, icecream[i].name.PadLeft(5));
                    found = true;
                }
            }
            if (found == false)
            {
                Console.WriteLine("Unable to locate decade.");
            }

        }

        public static void edit()
        {
            bool found = false;
            Console.WriteLine("Please enter the ice cream you would like to edit: ");
            string wanted = Console.ReadLine();

            for (int i = 0; i < icecream.Length; i++)
            {
                if (icecream[i].name == wanted)
                {
                    Console.WriteLine("Please enter the manufacturer you wish to change this ice cream too: ");
                    Console.ReadLine();

                    found = true;
                }
            }
            if (found == false)
            {
                Console.WriteLine("Unable to locate ice cream.");
            }

        }


        static void Main()
        {
            readText();

            writeText();

            increaseArray();
            Console.ReadLine();

            search();
            Console.ReadLine();

            search2();
            Console.ReadLine();

        }
    }
}
