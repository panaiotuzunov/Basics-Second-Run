using System;

namespace _03.Powers_of_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;

            for (int count = 0; count <= n; count++)
            {
                Console.WriteLine(num);
                num *= 2;
            }
        }
    }
}
