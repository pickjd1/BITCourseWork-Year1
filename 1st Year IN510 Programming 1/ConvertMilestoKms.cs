using System;


namespace ActivityDiagram
{
    class ConvertMilestoKms
    {
        static void Main()
        {
            const double Factor = 1.609344;
            double miles, Kms;
            string temp;

            Console.WriteLine("Please enter the number of miles.");
            temp = Console.ReadLine();
            miles = Convert.ToDouble(temp);
            Kms = miles * Factor;
            Console.WriteLine("This converts to {0:F2}", Kms );
            Console.ReadLine();

        }
    }
}
