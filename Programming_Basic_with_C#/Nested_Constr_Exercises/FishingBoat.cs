using System;

namespace Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {

            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            double price = 0.0;

            switch (season)
            {
                case "Spring":
                    price = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    price = 4200;
                    break;
                case "Winter":
                    price = 2600;
                    break;
                default:
                    break;
            }

            if (count <= 6)
            {
                price -= 0.10 * price;
            }
            else if (count >= 7 && count <= 11)
            {
                price -= 0.15 * price;
            }
            else if (count >= 12)
            {
                price -= 0.25 * price;
            }

            if (count % 2 == 0 && (season != "Autumn"))
            {
                price -= 0.05 * price;
            }

            double result = budget - price;

            if (result >= 0)
            {
                Console.WriteLine($"Yes! You have {result:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {-result:f2} leva.");
            }
        }
    }
}
