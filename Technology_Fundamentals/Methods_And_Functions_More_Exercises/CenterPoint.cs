using System;

namespace CenterPoint
{
    class CenterPoint
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            bool result = IsFirst(x1, y1, x2, y2);

            if (result == false)
            {
                Console.WriteLine($"({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x1}, {y1})");
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
    }
}
