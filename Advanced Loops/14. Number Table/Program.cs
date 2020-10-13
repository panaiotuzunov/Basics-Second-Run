﻿using System;
namespace _14.Number_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (col > 0) Console.Write(" ");
                    var num = row + col + 1;
                    if (num > n) num = 2 * n - num;
                    Console.Write(num);
                }
                Console.WriteLine();
            }
        }
    }
}
