using System;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            double moneySpend = 0;

            switch (name)
            {
                case "Cairo":
                    {
                        moneySpend = 600 + 2 * 250 * count;
                        break;
                    }
                case "Paris":
                    {
                        moneySpend = 350 + 2 * 150 * count;
                        break;
                    }
                case "Lima":
                    {
                        moneySpend = 850 + 2 * 400 * count;
                        break;
                    }
                case "New York":
                    {
                        moneySpend = 650 + 2 * 300 * count;
                        break;
                    }
                case "Tokyo":
                    {
                        moneySpend = 700 + 2 * 350 * count;
                        break;
                    }
                default:
                    break;
            }

            if (count >= 1 && count <= 4)
            {
                if ((name == "Cairo") || (name == "New York"))
                {
                    moneySpend -= moneySpend * 0.03;
                }
            }
            else if (count >= 5 && count <= 9)
            {
                if ((name == "Cairo") || (name == "New York"))
                {
                    moneySpend -= moneySpend * 0.05;
                }
                else if (name == "Paris")
                {
                    moneySpend -= moneySpend * 0.07;
                }
            }
            else if (count >= 10 && count <= 24)
            {
                if (name == "Cairo")
                {
                    moneySpend -= moneySpend * 0.1;
                }
                else if (name == "Paris" || name == "New York" || name == "Tokyo")
                {
                    moneySpend -= moneySpend * 0.12;
                }
            }
            else if (count >= 25 && count <= 49)
            {
                if (name == "Tokyo" || name == "Cairo")
                {
                    moneySpend -= moneySpend * 0.17;
                }
                else if (name == "New York" || name == "Lima")
                {
                    moneySpend -= moneySpend * 0.19;
                }
                else if (name == "Paris")
                {
                    moneySpend -= moneySpend * 0.22;
                }
            }
            else if (count >= 50)
            {
                moneySpend -= moneySpend * 0.30;
            }

            if (budget >= moneySpend)
            {
                Console.WriteLine($"Yes! You have {(budget - moneySpend):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(moneySpend - budget):f2} leva.");
            }
        }
    }
}
