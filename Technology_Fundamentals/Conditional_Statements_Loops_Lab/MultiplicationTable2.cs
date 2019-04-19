using System;

namespace Multiplication_Table2
{
    class MultiplicationTable2
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int multipier = int.Parse(Console.ReadLine());

            if (multipier > 10)
            {
                Console.WriteLine($"{n} X {multipier} = {n * multipier}");
            }
            else if (multipier >= 1 && multipier <= 10)
            {
                for (int i = multipier; i < 11; i++)
                {
                    Console.WriteLine($"{n} X {i} = {n * i}");
                }
            }
        }
    }
}