using System;

namespace Outing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string comand = Console.ReadLine();
            double price = 0;
            int counter = 0;
            double totalMoney = 0;

            while (comand != "Stop")
            {
                string fishName = comand;
                double weight = double.Parse(Console.ReadLine());
                counter++;

                if (counter % 3 == 0)
                {
                    totalMoney += GetFishPrice(fishName, weight);
                }
                else
                {
                    totalMoney -= GetFishPrice(fishName, weight);
                }

                if (counter == n)
                {
                    Console.WriteLine("Lyubo fulfilled the quota!");
                    break;
                }

                comand = Console.ReadLine();
            }

            if (totalMoney > 0)
            {
                Console.WriteLine($"Lyubo's profit from {counter} fishes is {totalMoney:f2} leva.");
            }
            else
            {
                Console.WriteLine($"Lyubo lost {(-totalMoney):f2} leva today.");
            }
        }

        static double GetFishPrice(string name, double weight)
        {
            double result = 0;

            for (int i = 0; i < name.Length; i++)
            {
                char letter = name[i];
                result += (double)(letter);
            }

            result = (result * 1.0) / (weight * 1.0);
            return result;
        }
    }
}
