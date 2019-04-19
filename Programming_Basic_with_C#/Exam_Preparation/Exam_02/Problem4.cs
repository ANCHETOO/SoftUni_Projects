using System;

namespace Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string comand = Console.ReadLine();
            int counterBalloons = 0;
            int counterFlowers = 0;
            int counterCandles = 0;
            int counterRibbon = 0;
            double moneySpend = 0;

            while (comand != "stop")
            {
                switch (comand)
                {
                    case "balloons":
                        {
                            int balloons = int.Parse(Console.ReadLine());
                            counterBalloons += balloons;
                            moneySpend += balloons * 0.1;
                            break;
                        }
                    case "flowers":
                        {
                            int flowers = int.Parse(Console.ReadLine());
                            counterFlowers += flowers;
                            moneySpend += flowers * 1.50;
                            break;
                        }
                    case "candles":
                        {
                            int candles = int.Parse(Console.ReadLine());
                            counterCandles += candles;
                            moneySpend += candles * 0.5;
                            break;
                        }
                    case "ribbon":
                        {
                            int ribbon = int.Parse(Console.ReadLine());
                            counterRibbon += ribbon;
                            moneySpend += ribbon * 2;
                            break;
                        }
                    default:
                        break;
                }

                if (moneySpend >= budget)
                {
                    Console.WriteLine("All money is spent!");
                    Console.WriteLine($"Purchased decoration is {counterBalloons} balloons, {counterRibbon} m ribbon, {counterFlowers} flowers and {counterCandles} candles.");
                    return;
                }

                comand = Console.ReadLine();
            }

            Console.WriteLine($"Spend money: {moneySpend:f2}");
            Console.WriteLine($"Money left: {(budget - moneySpend):f2}");
            Console.WriteLine($"Purchased decoration is {counterBalloons} balloons, {counterRibbon} m ribbon, {counterFlowers} flowers and {counterCandles} candles.");
        }
    }
}
