using System;

namespace InchesToCm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("inches = ");
            double inches = double.Parse(Console.ReadLine());
            double cm = inches * 2.54;
            Console.Write("Centimeters = ");
            Console.WriteLine(cm);
        }
    }
}
