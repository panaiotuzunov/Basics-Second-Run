using System;

namespace Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            string fromUnit = Console.ReadLine();
            string toUnit = Console.ReadLine();
            double numInM = num;
            double result = numInM;

            switch (fromUnit)
            {
                case "mm":
                    numInM = num / 1000;
                    break;
                case "cm":
                    numInM = num / 100;
                    break;
                case "mi":
                    numInM = num / 0.000621371192;
                    break;
                case "in":
                    numInM = num / 39.3700787;
                    break;
                case "km":
                    numInM = num / 0.001;
                    break;
                case "ft":
                    numInM = num / 3.2808399;
                    break;
                case "yd":
                    numInM = num / 1.0936133;
                    break;
            }

            switch (toUnit)
            {
                case "mm":
                    result = numInM * 1000;
                    break;
                case "cm":
                    result = numInM * 100;
                    break;
                case "mi":
                    result = numInM * 0.000621371192;
                    break;
                case "in":
                    result = numInM * 39.3700787;
                    break;
                case "km":
                    result = numInM * 0.001;
                    break;
                case "ft":
                    result = numInM * 3.2808399;
                    break;
                case "yd":
                    result = numInM * 1.0936133;
                    break;
                case "m":
                    result = numInM;
                    break;
            }

            Console.WriteLine(result);
        }
    }
}
