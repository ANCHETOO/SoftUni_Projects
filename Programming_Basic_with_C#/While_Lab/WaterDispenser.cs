using System;

namespace Water_Dispenser
{
    class WaterDispenser
    {
        static void Main(string[] args)
        {
            int volumeMl = int.Parse(Console.ReadLine());
            string buttonPress = string.Empty;
            int waterMl = 0;
            int count = 0;

            while (waterMl<volumeMl)
            {
                buttonPress = Console.ReadLine();

                switch (buttonPress)
                {
                    case "Easy":
                        waterMl += 50;
                        break;
                    case "Medium":
                        waterMl += 100;
                        break;
                    case "Hard":
                        waterMl += 200;
                        break;
                    default:
                        return;
                }

                count++;
            }

            if (waterMl==volumeMl)
            {
                Console.WriteLine($"The dispenser has been tapped {count} times.");
            }
            else if (waterMl>volumeMl)
            {
                Console.WriteLine($"{waterMl-volumeMl}ml has been spilled.");
            }           
        }
    }
}
