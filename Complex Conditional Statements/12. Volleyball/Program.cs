using System;

namespace _12.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string yearType = Console.ReadLine();
            double holidays = double.Parse(Console.ReadLine());
            double weekendsAtHome = double.Parse(Console.ReadLine());
            double weekendAtSofia = 48 - weekendsAtHome;
            double games = 0;

            games += holidays * (2.0 / 3);
            games += weekendsAtHome;
            games += weekendAtSofia * (3.0 / 4);

            if (yearType == "leap")
                games += games * (15.0 / 100);
            Console.WriteLine(Math.Truncate(games));
        }
    }
}
