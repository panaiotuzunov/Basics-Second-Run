using System;
namespace _13.Point_in_the_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (isInsideBottom(h, x, y) || isInsideTop(h, x, y))
            {
                Console.WriteLine("inside");
            }
            else if (isOnBorder(h, x, y))
                Console.WriteLine("border");
            else
                Console.WriteLine("outside");
        }
        static bool isInsideBottom(int h, double x, double y)
        {
            int x1 = 0;
            int y1 = 0;
            int x2 = 3 * h;
            int y2 = h;

            bool isInside = (x > x1) && (x < x2) && (y > y1) && (y < y2);
            return isInside;
        }
        static bool isInsideTop(int h, double x, double y)
        {
            int x1 = h;
            int y1 = 0;
            int x2 = 2 * h;
            int y2 = 4 * h;

            bool isInside = (x > x1) && (x < x2) && (y > y1) && (y < y2);
            return isInside;
        }
        static bool isOnBorder(int h, double x, double y)
        {

            int x1 = h;
            int y1 = 0;
            int x2 = 2 * h;
            int y2 = 4 * h;

            int bx1 = 0;
            int by1 = 0;
            int bx2 = 3 * h;
            int by2 = h;

            bool isOnBorderTop = ((x == x1 | x == x2) && (y <= y2 && y >= h)) | (y == y2 && x <= x2 && x >= x1);
            bool isOnBorderBottom = ((x == bx1 | x == bx2) && (y <= by2 && y >= by1)) |
                (y == by1 && (x >= bx1 && x <= bx2)) |
                (y == by2 && (x >= bx1 && x <= h)) |
                (y == by2 && (x >= (h * 2) && x <= bx2));

            bool isOnBorder = isOnBorderTop | isOnBorderBottom;
            return isOnBorder;
        }

    }
}
