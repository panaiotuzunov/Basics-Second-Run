using System;

namespace _03.Point_in_Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            if (isInside(x1, y1, x2, y2, x, y))
                Console.WriteLine("Inside");
            else
                Console.WriteLine("Outside");
        }
        static bool isInside(double x1, double y1, double x2, double y2, double x, double y)
        {
            bool isInside = (x >= x1) && (x <= x2) && (y >= y1) && (y <= y2);
            return isInside;
        }

    }
}
