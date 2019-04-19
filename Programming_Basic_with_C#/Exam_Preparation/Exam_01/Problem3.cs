using System;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            int countBottles = int.Parse(Console.ReadLine());
            int countChips = int.Parse(Console.ReadLine());
            double moneyLeft = 0;

            double beerPrice = 1.20 * countBottles;
            double chipsPrice = 0.45 * beerPrice;
            chipsPrice *= countChips;
            chipsPrice = Math.Ceiling(chipsPrice);
            moneyLeft = budget - beerPrice - chipsPrice;

            if (moneyLeft >= 0)
            {
                Console.WriteLine($"{name} bought a snack and has {moneyLeft:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"{name} needs {-moneyLeft:f2} more leva!");
            }
        }
    }
}
