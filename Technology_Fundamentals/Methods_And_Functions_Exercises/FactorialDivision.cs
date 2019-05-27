using System;
using System.Numerics;

namespace FactorialDivision
{
    class FactorialDivision
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"{GetDiv(a, b):f2}");
        }

        static BigInteger Factorial(int num)
        {

            BigInteger factorial = 1;

            if (num > 0)
            {
                for (int i = 1; i <= num; i++)
                {
                    factorial *= i;
                }
            }

            return factorial;
        }

        static double GetDiv(int a, int b)
        {
            double div = (double)(Factorial(a)) / ((double)(Factorial(b)));
            return div;
        }
    }
}
