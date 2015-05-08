using System;


namespace ConsoleApplication6
{
    class NZDConverter
    {
        static void Main()
        {
            const double AUD = 0.7779, USD = 0.7721, PND = 0.4875, YEN = 63.33, EUR = 0.5675;
            double NZD,ConAUD,ConUSD,ConPND,ConYEN,ConEUR;
            string temp;

            Console.WriteLine("Please enter the amount of NZ Dollars you wish to convert:");
            temp = Console.ReadLine();
            NZD = Convert.ToDouble(temp);
            ConAUD = NZD * AUD;
            ConUSD = NZD * USD;
            ConPND = NZD * PND;
            ConYEN = NZD * YEN;
            ConEUR = NZD * EUR;
            Console.WriteLine("This converts to {0:C2}AUD", ConAUD );
            Console.WriteLine("This converts to {0:C2}USD", ConUSD );
            Console.WriteLine("This converts to {0:C2}PND", ConPND );
            Console.WriteLine("This converts to {0:C2}YEN", ConYEN );
            Console.WriteLine("This converts to {0:C2}EUR", COnEUR );
            Console.ReadLine();

        }
    }
}
