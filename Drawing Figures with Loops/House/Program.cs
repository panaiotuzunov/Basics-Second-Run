using System;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            DrawRoof(n);
            DrawBase(n);
        }
        static void DrawRoof(int n)
        {
            int stars = 0;

            if (n % 2 == 0)
            {
                stars = 2;
            }
            else
            {
                stars = 1;
            }

            for (int row = 0; row < (n + 1) / 2; row++)
            {
                for (int col = 0; col < (n - stars) / 2; col++)
                {
                    Console.Write("-");
                }
                for (int col = 0; col < stars; col++)
                {
                    Console.Write("*");
                }
                for (int col = 0; col < (n - stars) / 2; col++)
                {
                    Console.Write("-");
                }
                stars += 2;
                Console.WriteLine();
            }
        }
        static void DrawBase(int n)
        {
            for (int row = 0; row <= n / 2 - 1; row++)
            {
                Console.Write("|");
                for (int col = 0; col < n - 2; col++)
                {
                    Console.Write("*");
                }
                Console.Write("|");

                Console.WriteLine();
            }
        }
    }
}
