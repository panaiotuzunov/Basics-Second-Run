using System;

namespace _08.Trade_Comissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine().ToLower();
            double sales = double.Parse(Console.ReadLine());
            double commision = -1;

            if (town == "sofia")
                commision = getCommisionSofia(sales);
            else if (town == "varna")
                commision = getCommisionVarna(sales);
            else if (town == "plovdiv")
                commision = getCommisionPlovdiv(sales);

            if (commision < 0)
                Console.WriteLine("error");
            else Console.WriteLine(commision);

        }
        static double getCommisionSofia(double sales)
        {
            double commision = -1;
            if (sales >= 0 && sales <= 500)
                commision = ((double)5 / 100) * sales;
            else if (sales > 500 && sales <= 1000)
                commision = ((double)7 / 100) * sales;
            else if (sales > 1000 && sales <= 10000)
                commision = ((double)8 / 100) * sales;
            else if (sales > 10000)
                commision = ((double)12 / 100) * sales;
            return commision;
        }
        static double getCommisionVarna(double sales)
        {
            double commision = -1;
            if (sales >= 0 && sales <= 500)
                commision = (double)(4.5 / 100) * sales;
            else if (sales > 500 && sales <= 1000)
                commision = ((double)7.5 / 100) * sales;
            else if (sales > 1000 && sales <= 10000)
                commision = ((double)10 / 100) * sales;
            else if (sales > 10000)
                commision = ((double)13 / 100) * sales;

            return commision;
        }
        static double getCommisionPlovdiv(double sales)
        {
            double commision = -1;
            if (sales >= 0 && sales <= 500)
                commision = ((double)5.5 / 100) * sales;
            else if (sales > 500 && sales <= 1000)
                commision = ((double)8 / 100) * sales;
            else if (sales > 1000 && sales <= 10000)
                commision = ((double)12 / 100) * sales;
            else if (sales > 10000)
                commision = (14.5 / 100) * sales;

            return commision;
        }
    }

}
