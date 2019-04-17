using System;

namespace Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine()); // [1_000 .. 1_000_000]
            string ticket = Console.ReadLine(); //VIP or Normal
            int count = int.Parse(Console.ReadLine()); // pple [1..200]
            double price = 0;

            if (count >= 1 && count <= 4)
            {
                budget -= 0.75 * budget;
            }
            else if (count >= 5 && count <= 9)
            {
                budget -= 0.60 * budget;
            }
            else if (count >= 10 && count <= 24)
            {
                budget -= 0.50 * budget;
            }
            else if (count >= 25 && count <= 49)
            {
                budget -= 0.40 * budget;
            }
            else if (count >= 50)
            {
                budget -= 0.25 * budget;
            }

            if (ticket == "VIP")
            {
                price = count * 499.99;
            }
            else if (ticket == "Normal")
            {
                price = count * 249.99;
            }

            double result;
            if (price <= budget)
            {
                result = budget - price;
                Console.WriteLine($"Yes! You have {result:f2} leva left.");
            }
            else
            {
                result = price - budget;
                Console.WriteLine($"Not enough money! You need {result:f2} leva.");
            }
        }
    }
}
