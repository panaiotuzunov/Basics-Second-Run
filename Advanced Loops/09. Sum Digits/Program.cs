using System;

namespace _09.Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            while (n != 0)
            {
                int temp = n % 10;
                sum += temp;
                n /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
