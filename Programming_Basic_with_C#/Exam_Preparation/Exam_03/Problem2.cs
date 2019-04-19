using System;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double lenght = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double astroHeight = double.Parse(Console.ReadLine());

            double volume = width * lenght * height;
            double volumeNeeded = 2 * 2 * (astroHeight + 0.40);
            int count = (int)(Math.Floor(volume / (volumeNeeded * 1.0)));

            if (count > 10)
            {
                Console.WriteLine("The spacecraft is too big.");
            }
            else if (count < 3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            else
            {
                Console.WriteLine($"The spacecraft holds {count} astronauts.");
            }
        }
    }
}
