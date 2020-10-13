using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_0_100_to_Text
{
    class Program
    {
        static string oneToTenInText
        {
        }
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string firstDigitStr = string.Empty;
            string secondDigitStr = string.Empty;
            int firstDigit = 0;
            int secondDigit = 0;

            if (number <= 12)
            {
                switch (number)
                {
                    case 0:
                        firstDigitStr = "zero";
                    break;
                    case 1:
                        firstDigitStr = "one";
                        break;
                    case 2:
                        firstDigitStr = "two";
                        break;
                    case 3:
                        firstDigitStr = "three";
                        break;
                    case 4:
                        firstDigitStr = "four";
                        break;
                    case 5:
                        firstDigitStr = "five";
                        break;
                    case 6:
                        firstDigitStr = "six";
                        break;
                    case 7:
                        firstDigitStr = "seven";
                        break;
                    case 8:
                        firstDigitStr = "eight";
                        break;
                    case 9:
                        firstDigitStr = "nine";
                        break;
                    case 10:
                        firstDigitStr = "ten";
                        break;
                    case 11:
                        firstDigitStr = "eleven";
                        break;
                    case 12:
                        firstDigitStr = "twelve";
                        break;
                    case 13:
                        firstDigitStr = "thirteen";
                        break;
                    case 14:
                        firstDigitStr = "fourteen";
                        break;
                    case 15:
                        firstDigitStr = "fifteen";
                        break;
                    case 16:
                        firstDigitStr = "sixteen";
                        break;
                    case 17:
                        firstDigitStr = "seventeen";
                        break;
                    case 18:
                        firstDigitStr = "eighteen";
                        break;
                    case 19:
                        firstDigitStr = "nineteen";
                        break;
                    case 20:
                        firstDigitStr = "twenty";
                        break;
                }
                Console.WriteLine(firstDigitStr);
            }
            else if (number > 20 & number < 30)
            {
                firstDigitStr = "twenty";
                
            }


        }
    }
}
