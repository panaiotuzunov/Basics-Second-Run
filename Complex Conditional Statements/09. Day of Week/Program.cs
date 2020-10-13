using System;

namespace _09.Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            string dayStr = string.Empty;

            if (day <= 7 && day >= 1)
            {
                switch (day)
                {
                    case 1:
                        dayStr = "Monday";
                        break;
                    case 2:
                        dayStr = "Tuesday";
                        break;
                    case 3:
                        dayStr = "Wednesday";
                        break;
                    case 4:
                        dayStr = "Thursday";
                        break;
                    case 5:
                        dayStr = "Friday";
                        break;
                    case 6:
                        dayStr = "Saturday";
                        break;
                    case 7:
                        dayStr = "Sunday";
                        break;
                }
                Console.WriteLine(dayStr);
            }
            else
                Console.WriteLine("Error");
        }
    }
}
