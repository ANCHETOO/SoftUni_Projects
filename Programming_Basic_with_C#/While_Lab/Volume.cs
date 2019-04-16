using System;

namespace Moving
{
    class Volume
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            string comand = string.Empty;

            int freeVolume = width * length * height;
            int volume = 0;

            while (freeVolume > volume)
            {
                comand = Console.ReadLine();

                if (comand == "Done")
                {
                    break;
                }
                else
                {
                    volume += int.Parse(comand);
                }
            }

            if (comand == "Done")
            {
                Console.WriteLine($"{freeVolume - volume} Cubic meters left.");
            }

            if (freeVolume <= volume)
            {
                Console.WriteLine($"No more free space! You need {volume - freeVolume} Cubic meters more.");
            }
        }
    }
}
