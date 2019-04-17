using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = string.Empty;
            string output = string.Empty;

            if (budget<=100)
            {
                destination = "Bulgaria";

                if (season=="summer")
                {
                    budget = 0.30 * budget;
                    output = "Camp";
                }
                else
                {
                    budget = 0.70 * budget;
                    output = "Hotel";
                }
            }
            else if (budget>100&&budget<=1000)
            {
                destination = "Balkans";

                if (season == "summer")
                {
                    budget = 0.40 * budget;
                    output = "Camp";
                }
                else
                {
                    budget = 0.80 * budget;
                    output = "Hotel";
                }
            }
            else if (budget>1000)
            {
                destination = "Europe";
                budget = 0.90 * budget;

                if (season == "summer")
                {
                    output = "Hotel";
                }
                else
                {
                    output = "Hotel";
                }
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{output} - {budget:f2}");
        }    
    }
}
