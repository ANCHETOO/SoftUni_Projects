using System;
using System.Collections.Generic;
using System.Linq;

namespace Beer_Kegs
{
    class BeerKegs
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string maxKegName = string.Empty;
            double maxKegVolume = 0;

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double volume = Math.PI * radius * radius * height;

                if (volume >= maxKegVolume)
                {
                    maxKegVolume = volume;
                    maxKegName = name;
                }
            }

            Console.WriteLine(maxKegName);
        }
    }
}
