using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int sum = num1 + num2 + num3;
            int minutesOnly = sum / 60;
            int secondsOnly = sum - minutesOnly * 60;

            if (secondsOnly < 10)
            {
                Console.WriteLine($"{minutesOnly}:0{secondsOnly}");
            }
            else
            {
                Console.WriteLine($"{minutesOnly}:{secondsOnly}");
            }
        }
    }
}
