using System;
using System.Numerics;

namespace From_Left_To_Right
{
    class FromLeftToRight
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger result = 0;

            for (int i = 0; i < n; i++)
            {
                var row = Console.ReadLine().Split(' ');
                BigInteger left = BigInteger.Parse(row[0]);
                BigInteger right = BigInteger.Parse(row[1]);

                if (left >= right)
                {
                    result = SumOfDigits(left);
                }
                else
                {
                    result = SumOfDigits(right);
                }

                Console.WriteLine(result);
            }
        }

        public static BigInteger SumOfDigits(BigInteger number)
        {
            BigInteger sum = 0;

            if (number < 0)
            {
                number *= -1;
            }

            while (number != 0)
            {
                sum += number % 10;
                number = number / 10;
            }
            return sum;
        }
    }
}
