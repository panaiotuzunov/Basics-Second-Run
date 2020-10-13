using System;

namespace _11.Enter_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;

            while (num % 2 != 0)
            {
                try
                {
                    Console.Write("Enter even number: ");
                    num = int.Parse(Console.ReadLine());
                    if (num % 2 != 0)
                    {
                        Console.WriteLine("The number is not even.");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid number!");
                }

            }
            Console.WriteLine("Even number entered: {0}", num);
        }
    }
}
