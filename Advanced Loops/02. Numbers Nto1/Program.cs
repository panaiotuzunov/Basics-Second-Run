using System;
namespace _02.Numbers_Nto1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int count = n; count >= 1; count --)
            {
                Console.WriteLine(count);
            }
        }
    }
}
