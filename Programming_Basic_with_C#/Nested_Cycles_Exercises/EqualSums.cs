using System;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            for (int i = num1; i <= num2; i++)
            {
                int sumEven = GetSumEven(i);
                int sumOdd = GetSumOdd(i);

                if (sumEven == sumOdd)
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine();
        }

        static int GetSumEven(int number)
        {
            int result = 0;

            while (number != 0)
            {
                result += number % 10;
                number = number / 100;
            }

            return result;
        }

        static int GetSumOdd(int number)
        {
            int result = 0;

            while (number != 0)
            {
                number = number / 10;
                result += number % 10;
                number = number / 10;
            }

            return result;
        }
    }
}
