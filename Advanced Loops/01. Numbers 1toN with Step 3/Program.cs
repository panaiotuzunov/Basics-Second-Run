using System;

namespace _01.Numbers_1toN_with_Step_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int count = 1; count <= n; count += 3)
            {
                Console.WriteLine(count);
            }
        }
    }
}
