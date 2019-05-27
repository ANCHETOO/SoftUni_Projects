using System;

namespace MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine(GetSign(a, b, c));
        }

        public static string GetSign(double a, double b, double c)
        {
            string result = string.Empty;

            if (a == 0 || b == 0 || c == 0)
            {
                result = "zero";
            }
            else if ((a > 0 && b > 0 && c > 0) || (a > 0 && b < 0 && c < 0) || (a < 0 && b < 0 && c > 0) || (a < 0 && b > 0 && c < 0))
            {
                result = "positive";
            }
            else
            {
                result = "negative";
            }

            return result;
        }
    }
}
