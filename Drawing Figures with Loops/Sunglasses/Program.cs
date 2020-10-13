using System;

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            FirstAndLastRow(n);
            Console.WriteLine();
            MiddlePart(n);
            FirstAndLastRow(n);

        }
        static void FirstAndLastRow(int n)
        {
            for (int i = 0; i < n * 2; i++)
            {
                Console.Write("*");
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(" ");
            }
            for (int i = 0; i < n * 2; i++)
            {
                Console.Write("*");
            }
        }
        static void MiddlePart(int n)
        {
            for (int row = 0; row < n - 2; row++)
            {
                for (int col = 0; col < n * 2; col++)
                {
                    if (col == 0 | col == (n * 2) - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("/");
                    }
                }
                for (int col = 0; col < n; col++)
                {
                    if (row == (n - 1) / 2 - 1)
                    {
                        Console.Write("|");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                for (int col = 0; col < n * 2; col++)
                {
                    if (col == 0 | col == (n * 2) - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("/");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

