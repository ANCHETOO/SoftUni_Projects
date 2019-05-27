using System;
using System.Linq;

namespace CarRace
{
    class CarRace
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();
            double sumLeft = 0;
            double sumRight = 0;

            for (int i = 1; i <= input.Length / 2; i++)
            {
                if (input[i - 1] != 0)
                {
                    sumLeft += input[i - 1];
                }
                else
                {
                    sumLeft *= 0.8;
                }
                if (input[input.Length - i] != 0)
                {
                    sumRight += input[input.Length - i];
                }
                else
                {
                    sumRight *= 0.8;
                }
            }

            if (sumLeft > sumRight)
            {
                Console.WriteLine($"The winner is right with total time: {sumRight}");
            }
            else if (sumLeft < sumRight)
            {
                Console.WriteLine($"The winner is left with total time: {sumLeft}");
            }
        }
    }
}
