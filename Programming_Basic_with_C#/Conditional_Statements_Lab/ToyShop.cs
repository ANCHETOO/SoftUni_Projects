using System;

namespace Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {


            double priceTour = double.Parse(Console.ReadLine());
            int puzzelsCount = int.Parse(Console.ReadLine());
            int dollsCount = int.Parse(Console.ReadLine());
            int bearsCount = int.Parse(Console.ReadLine());
            int minionsCount = int.Parse(Console.ReadLine());
            int trucksCount = int.Parse(Console.ReadLine());

            double pricePuzzels = puzzelsCount * 2.60;
            double priceDolls = dollsCount * 3.00;
            double priceBear = bearsCount * 4.10;
            double priceMinions = minionsCount * 8.20;
            double priceTrucks = trucksCount * 2.00;

            double totalPrice = pricePuzzels + priceDolls + priceBear + priceMinions + priceTrucks;

            if (puzzelsCount + dollsCount + bearsCount + minionsCount + trucksCount >= 50)
            {
                totalPrice -= 0.25 * totalPrice;
            }

            totalPrice -= 0.10 * totalPrice;

            double result = Math.Abs(totalPrice - priceTour);
            if (totalPrice >= priceTour)
            {
                Console.WriteLine($"Yes! {result:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {result:f2} lv needed.");
            }
        }
    }
}
