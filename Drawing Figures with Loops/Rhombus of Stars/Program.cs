using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            upperPart(n);
            lowerPart(n);

        }
        static void upperPart(int n)
        {
            for (int row = 1; row <= n; row++)
            {
                for (int col = 0; col <= n - row; col++)
                {
                    if (col > 0)
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("*");
                for (int col2 = 0; col2 < row - 1; col2++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }

        }
        static void lowerPart(int n)
        {
            for (int row = 1; row < n; row++)
            {
                for (int col = 0; col < row; col++)
                {
                    if (col > 0)
                    {
                        Console.Write(" ");

                    }
                }
                for (int i = row; i < n; i++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
