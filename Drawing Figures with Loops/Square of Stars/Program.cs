using System;

namespace Rectangle_of_10_x_10_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int count = 0; count < n; count++)
            {
                for (int count2 = 0; count2 < n; count2++)
                {
                    if (count2 == n - 1)
                        Console.Write("*");

                    else Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
