﻿using System;

namespace _07.Greatest_Common_Divisor__CGD_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            while (b != 0)
            {
                var temp = b;
                b = a % b;
                a = temp;
            }

            Console.WriteLine(a);
        }
    }
}
