using System;

namespace Odd_Even_Positions
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            double sumEven = 0.0;
            double sumOdd = 0.0;
            double minOdd = double.MaxValue;
            double maxOdd = double.MinValue;
            double minEven = double.MaxValue;
            double maxEven = double.MinValue;

            if (count >= 2)
            {
                for (int i = 1; i <= count; i++)
                {
                    double number = double.Parse(Console.ReadLine());

                    if (i % 2 == 0)
                    {
                        sumEven += number;

                        if (number >= maxEven)
                        {
                            maxEven = number;
                        }

                        if (number <= minEven)
                        {
                            minEven = number;
                        }
                    }
                    else
                    {
                        sumOdd += number;

                        if (number >= maxOdd)
                        {
                            maxOdd = number;
                        }

                        if (number <= minOdd)
                        {
                            minOdd = number;
                        }
                    }
                }

                Console.WriteLine($"OddSum={sumOdd},");
                Console.WriteLine($"OddMin={minOdd},");
                Console.WriteLine($"OddMax={maxOdd},");

                Console.WriteLine($"EvenSum={sumEven},");
                Console.WriteLine($"EvenMin={minEven},");
                Console.WriteLine($"EvenMax={maxEven}");
            }
            else if (count == 1)
            {
                double number = double.Parse(Console.ReadLine());

                Console.WriteLine($"OddSum={number},");
                Console.WriteLine($"OddMin={number},");
                Console.WriteLine($"OddMax={number},");

                Console.WriteLine($"EvenSum={sumEven},");
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");
            }
            else if (count == 0)
            {
                Console.WriteLine($"OddSum={sumOdd},");
                Console.WriteLine($"OddMin=No,");
                Console.WriteLine($"OddMax=No,");

                Console.WriteLine($"EvenSum={sumEven},");
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");
            }
        }
    }
}
