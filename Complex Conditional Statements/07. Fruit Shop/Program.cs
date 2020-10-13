using System;

namespace _07.Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0;
            string errorCheck = string.Empty;

            if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
                price = WeekendPrice(fruit, price);
            else if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" ||
                dayOfWeek == "Thursday" || dayOfWeek == "Friday")
                price = MondayToFridayPrice(fruit, price);
            else errorCheck = "error";

            if (errorCheck == "error")
                Console.WriteLine(errorCheck);
            else if (price == 0)
                Console.WriteLine("error");
            else Console.WriteLine($"{price*quantity:f2}");
        }
        static double WeekendPrice(string fruit, double price)
        {
            switch (fruit)
            {
                case "banana":
                    price = 2.70;
                    break;
                case "apple":
                    price = 1.25;
                    break;
                case "orange":
                    price = 0.90;
                    break;
                case "grapefruit":
                    price = 1.60;
                    break;
                case "kiwi":
                    price = 3;
                    break;
                case "pineapple":
                    price = 5.60;
                    break;
                case "grapes":
                    price = 4.20;
                    break;
            }
            return price;
        }
        static double MondayToFridayPrice(string fruit, double price)
        {
            switch (fruit)
            {
                case "banana":
                    price = 2.50;
                    break;
                case "apple":
                    price = 1.20;
                    break;
                case "orange":
                    price = 0.85;
                    break;
                case "grapefruit":
                    price = 1.45;
                    break;
                case "kiwi":
                    price = 2.70;
                    break;
                case "pineapple":
                    price = 5.50;
                    break;
                case "grapes":
                    price = 3.85;
                    break;
            }
            return price;
        }
    }
}
