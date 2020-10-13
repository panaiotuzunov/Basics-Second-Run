using System;

namespace _09.Celsius_to_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double temp = double.Parse(Console.ReadLine());
            double tempFh = temp * 9 / 5 + 32;
            Console.WriteLine(Math.Round(tempFh, 2));
        }
    }
}
