using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();
            double a = double.Parse(Console.ReadLine());
            double result = 0;

            if (figureType == "square")
                result = a * a;
            else if (figureType == "rectangle")
            {
                double b = double.Parse(Console.ReadLine());
                result = (a * b);
            }
            else if (figureType == "circle")
                result = (Math.PI * (a * a));
            else if (figureType == "triangle")
            {
                double b = double.Parse(Console.ReadLine());
                result = (a * (b/2));
            }
            else
                Console.WriteLine("penis");

            Console.WriteLine(Math.Round(result, 3));
        }
    }
}
