﻿using System;
namespace _05.Sequence_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int num = 1;

            for (int i = 1; num <= n; i++)
            {
                Console.WriteLine(num);
                num = num * 2 + 1;
            }
        }
    }
}
