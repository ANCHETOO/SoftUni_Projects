using System;

namespace LongerLine
{
    class LongerLine
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());

            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            if (IsFirst(x1, y1, x2, y2) == false)
            {
                double swap = x1;
                x1 = x2;
                x2 = swap;
                swap = y1;
                y1 = y2;
                y2 = swap;
            }

            if (IsFirst(x3, y3, x4, y4) == false)
            {
                double swap = x3;
                x3 = x4;
                x4 = swap;
                swap = y3;
                y3 = y4;
                y4 = swap;
            }

            if (IsLongerFirst(x1, y1, x2, y2, x3, y3, x4, y4) == 1)
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else if (IsLongerFirst(x1, y1, x2, y2, x3, y3, x4, y4) == -1)
            {
                Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
            }
            else
            {
                if (IsFirst(x1, y1, x3, y3))
                {

                }

                if (IsFirst(x1, y1, x3, y3))
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
            }
        }

        public static bool IsFirst(double x1, double y1, double x2, double y2)
        {
            bool result = false;
            double r1 = Math.Sqrt(x1 * x1 + y1 * y1);
            double r2 = Math.Sqrt(x2 * x2 + y2 * y2);

            if (r1 <= r2)
            {
                result = true;
            }

            return result;
        }

        public static int IsLongerFirst(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double d1 = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
            double d2 = Math.Sqrt((x3 - x4) * (x3 - x4) + (y3 - y4) * (y3 - y4));
            int result = -1;

            if (d1 > d2)
            {
                result = 1;
            }

            if (d1 == d2)
            {
                result = 0;
            }

            return result;
        }
    }
}
