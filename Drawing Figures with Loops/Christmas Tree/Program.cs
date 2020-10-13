using System;

namespace Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                if (row == 1)
                {
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine(" | ");
                }

                for (int space = 1; space < n + 1 - row; space++)
                {
                    Console.Write(" ");
                }

                for (int star = 0; star < row; star++)
                {
                    Console.Write("*");
                }

                Console.Write(" | ");
                //край на лява страна

                for (int star = 0; star < row; star++)
                {
                    Console.Write("*");
                }
                for (int space = 1; space < n + 1 - row; space++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine();
            }
        }
    }
}
