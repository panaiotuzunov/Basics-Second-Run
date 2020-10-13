using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            double score = int.Parse(Console.ReadLine());
            double bonus = 0;

            if (score <= 100)
                bonus += 5;
            else if (score > 1000)
                bonus += ((double)10 / 100) * score;
            else if (score > 100)
                bonus += ((double)20 / 100) * score;

            if (score % 2 == 0)
                bonus += 1;
            string scoreAsStr = score.ToString();

            if (scoreAsStr[scoreAsStr.Length-1] == '5')
                bonus += 2;

            Console.WriteLine(bonus);
            Console.WriteLine(bonus + score);
        }
    }
}
