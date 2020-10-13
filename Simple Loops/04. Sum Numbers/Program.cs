using System;

namespace _04.Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersCounter = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < numbersCounter; i++)
            {
                sum += int.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }
    }
}
