using System;

namespace _08.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 1;

            for (int a = 2; a <= n; a++)
            {
                sum *= a;
            }
            Console.WriteLine(sum);
        }
    }
}
