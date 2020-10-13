using System;

namespace _10.Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int maxNumber = int.MinValue;
            for (int count = 0; count < n; count++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num > maxNumber)
                    maxNumber = num;

                sum += num;
            }

            if (maxNumber == (sum - maxNumber))
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", maxNumber);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}", Math.Abs(maxNumber - (sum - maxNumber)));
            }
        }
    }
}
