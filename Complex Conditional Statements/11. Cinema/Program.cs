using System;

namespace _11.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            double rows = double.Parse(Console.ReadLine());
            double columns = double.Parse(Console.ReadLine());

            if (type == "Premiere")
                Console.WriteLine("{0:f2} leva", rows*columns*12.0);
            else if (type == "Normal")
                Console.WriteLine("{0:f2} leva", rows * columns * 7.5);
            else if (type == "Discount")
                Console.WriteLine("{0:f2} leva", rows * columns * 5.0);
        }
    }
}
