using System;

namespace Rectangle_of_10_x_10_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int count = 0; count < 10; count++)
            {
                for (int count2 = 0; count2 < 10; count2++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
