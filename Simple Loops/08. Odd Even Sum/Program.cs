using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int oddSum = 0;
            int evenSum = 0;

            for (int count = 1; count <= n; count++)
            {
                int num = int.Parse(Console.ReadLine());

                if (count % 2 == 0)
                    evenSum += num;
                else oddSum += num;
            }
            int diff = Math.Abs(oddSum - evenSum);

            if (diff == 0)
            {
                Console.WriteLine($"Yes, sum = {oddSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {diff}");
            }
        }
    }
}
