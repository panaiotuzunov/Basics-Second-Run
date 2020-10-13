using System;

namespace _12.Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currentSum = 0;
            int lastSum = 0;
            int maxDiff = int.MinValue;
            bool isEqual = true;

            for (int count = 0; count < n; count++)
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());

                currentSum = num1 + num2;

                if (count > 0)
                {
                    if (currentSum != lastSum)
                    {
                        isEqual = false;
                    }
                    int diff = Math.Abs(currentSum - lastSum);

                    if (diff > maxDiff)
                        maxDiff = diff;
                }
                lastSum = currentSum;
            }

            if (isEqual)
            {
                Console.WriteLine("Yes, value={0}",lastSum);
            }
            else Console.WriteLine("No, maxdiff={0}", maxDiff);
        }
    }
}
