using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            drawFirstAndLastRow(n);

            for (int row = 0; row < n; row++)
            {
                if (row == 0)
                {
                    Console.Write("| ");
                }
                else if (row == n - 1)
                {
                    Console.WriteLine("| ");
                }
                else
                {
                    Console.Write("- ");
                }
            }

            drawFirstAndLastRow(n);
        }
        static void drawFirstAndLastRow(int n)
        {
            Console.Write("+ ");
            for (int col = 0; col < n-2; col++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("+");
        }

    }
}
