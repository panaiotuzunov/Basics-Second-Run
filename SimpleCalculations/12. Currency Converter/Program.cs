using System;

namespace _12.Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = double.Parse(Console.ReadLine());
            string fromCurency = Console.ReadLine();
            string toCurency = Console.ReadLine();
            double resultInLV = sum;
            double result = 0;

            switch (fromCurency)
            {
                case "USD":
                    resultInLV = sum * 1.79549;
                    break;
                case "EUR":
                    resultInLV = sum * 1.95583;
                    break;
                case "GBP":
                    resultInLV = sum * 2.53405;
                    break;
            }

            switch (toCurency)
            {
                case "USD":
                    result = resultInLV / 1.79549;
                    break;
                case "EUR":
                    result = resultInLV / 1.95583;
                    break;
                case "GBP":
                    result = resultInLV / 2.53405;
                    break;
                case "BGN":
                    result = resultInLV;
                    break;
            }

            Console.WriteLine(Math.Round(result, 2));
        }
    }
}
