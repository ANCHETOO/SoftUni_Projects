using System;

namespace Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int volume = width * lenght * height;
            int placeLeft = volume;

            string comand = comand = Console.ReadLine();

            while (comand != "Done")
            {
                int current = int.Parse(comand);
                placeLeft -= current;

                if (placeLeft < 0)
                {
                    Console.WriteLine($"No more free space! You need {-placeLeft} Cubic meters more.");
                    return;
                }

                comand = Console.ReadLine();
            }

            Console.WriteLine($"{placeLeft} Cubic meters left.");
        }
    }
}
