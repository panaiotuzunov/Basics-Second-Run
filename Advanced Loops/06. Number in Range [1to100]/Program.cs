using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Number_in_Range__1to100_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Еnter a number in the range [1...100]: ");
            bool isInRange = false;

            while (!isInRange)
            {
                int n = int.Parse(Console.ReadLine());

                if (n >= 1 & n <= 100)
                {
                    Console.WriteLine("The number is: {0}", n);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                    Console.Write("Еnter a number in the range [1...100]: ");
                }
            }


        }
    }
}
