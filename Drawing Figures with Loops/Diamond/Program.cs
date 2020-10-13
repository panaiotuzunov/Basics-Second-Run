using System;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            DrawUpperPart(n);
            DrawLowerPart(n);
        }
        static void DrawUpperPart(int n)
        {
            int rows = 0;

            if (n % 2 == 0)
                rows = n / 2;
            else rows = n / 2 + 1;

            int leftRight = (n - 1) / 2;

            for (int row = 0; row < rows; row++)
            {
                int mid = n - 2 * leftRight - 2;
                for (int col = 0; col < leftRight; col++)
                {
                    Console.Write("-");
                }
                Console.Write("*");
                for (int col = 0; col < mid; col++)
                {
                    Console.Write("-");
                }
                if (row != 0)
                {
                    Console.Write("*");
                }
                if (row == 0 & n % 2 == 0)
                {
                    Console.Write("*");
                }
                for (int col = 0; col < leftRight; col++)
                {
                    Console.Write("-");
                }

                leftRight--;
                Console.WriteLine();
            }
        }
        static void DrawLowerPart(int n)
        {
            int rows = n / 2;

            if (n % 2 == 0)
            {
                rows = n / 2 - 1;
            }
            int leftRight = 1;


            for (int row = 0; row < rows; row++)
            {
                int mid = n - 2 * leftRight - 2;
                for (int col = 0; col < leftRight; col++)
                {
                    Console.Write("-");
                }
                Console.Write("*");
                for (int col = 0; col < mid; col++)
                {
                    Console.Write("-");
                }
                if (row != rows - 1)
                {
                    Console.Write("*");
                }
                if (row == rows - 1 & n % 2 == 0)
                {
                    Console.Write("*");
                }
                for (int col = 0; col < leftRight; col++)
                {
                    Console.Write("-");
                }

                leftRight++;
                Console.WriteLine();
            }
        }
    }
}
