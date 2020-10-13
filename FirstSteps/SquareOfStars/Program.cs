using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int endNumber = int.Parse(Console.ReadLine());
            for (int counter = 0; counter < endNumber; counter++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            int endNumberMid = endNumber - 2;

            for (int i = 0; i < endNumberMid; i++)
            {
                for (int counter = 0; counter < endNumber; counter++)
                {
                    if (counter == 0 | counter == endNumber - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            for (int counter = 0; counter < endNumber; counter++)
            {
                Console.Write("*");
            }
        }
    }
}
