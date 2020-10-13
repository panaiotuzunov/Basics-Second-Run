using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleOf55stars
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "*";

            for (int counter = 0; counter <= 9; counter++)
            {
                Console.WriteLine(text);
                text+="*";
            }
        }
    }
}
