using System;

namespace Water_Overflow
{
    class WaterOverflow
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int tankCapacity = 255;
            int tankAmount = 255;

            for (int i = 0; i < n; i++)
            {
                int currAmount = int.Parse(Console.ReadLine());

                if (currAmount > tankAmount)
                {
                    Console.WriteLine($"Insufficient capacity!");
                }
                else
                {
                    tankAmount -= currAmount;
                }
            }

            Console.WriteLine(255 - tankAmount);
        }
    }
}
