using System;

namespace Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int sumCounter = 0;
            double maxDiff = double.MinValue;
            double sumPair = 0.0;

            if (count == 0)
            {
                Console.WriteLine($"Yes, value={sumPair}");
                return;
            }

            double[] pair = new double[2];
            pair[0] = double.Parse(Console.ReadLine());
            pair[1] = double.Parse(Console.ReadLine());
            sumPair = pair[0] + pair[1];

            for (int i = 1; i < count; i++)
            {
                double[] pairCurrent = new double[2];
                pairCurrent[0] = double.Parse(Console.ReadLine());
                pairCurrent[1] = double.Parse(Console.ReadLine());
                double sumCurrent = pairCurrent[0] + pairCurrent[1];

                if (sumPair == sumCurrent)
                {
                    sumCounter++;
                }

                if (Math.Abs(sumPair - sumCurrent) >= maxDiff)
                {
                    maxDiff = (Math.Abs(sumPair - sumCurrent));
                }
                sumPair = sumCurrent;
            }

            if (sumCounter == count - 1)
            {
                Console.WriteLine($"Yes, value={sumPair}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxDiff}");
            }
        }
    }
}
