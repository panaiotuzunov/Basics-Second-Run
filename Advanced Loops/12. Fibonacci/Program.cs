using System;

namespace _12.Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = 1;
            int b = 1;

            for (int i = 1; i < n; i++)
            {
                var temp = a + b;
                a = b;
                b = temp;
            }

            Console.WriteLine(b);

        }
    }
}
