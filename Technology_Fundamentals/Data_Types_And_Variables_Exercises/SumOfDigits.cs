using System;
using System.Numerics;

namespace Sum_Of_Digits
{
    class SumOfDigits
    {
        static void Main(string[] args)
        {
            BigInteger num = BigInteger.Parse(Console.ReadLine());
            BigInteger sum = 0;

            if (num < 0)
            {
                num *= -1;
            }

            while (num != 0)
            {
                sum += num % 10;
                num = num / 10;
            }

            Console.WriteLine(sum);
        }
    }
}
