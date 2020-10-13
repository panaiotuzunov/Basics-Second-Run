using System;

namespace _05.Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersCounter = int.Parse(Console.ReadLine());
            int minNumber = int.MaxValue;

            for (int i = 0; i < numbersCounter; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber < minNumber)
                    minNumber = currentNumber;
            }
            Console.WriteLine(minNumber);
        }
    }
}
