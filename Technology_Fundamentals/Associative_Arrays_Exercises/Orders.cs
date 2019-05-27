using System;
using System.Collections.Generic;
using System.Linq;

namespace Orders
{
    class Orders
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();
            var dict = new Dictionary<string, double[]>();

            while (comand != "buy")
            {
                string[] input = comand.Split(' ').ToArray();
                string name = input[0];
                double price = double.Parse(input[1]);
                double quantity = double.Parse(input[2]);

                if (!dict.ContainsKey(name))
                {
                    dict.Add(name, new double[2]);
                    dict[name][0] = price;
                    dict[name][1] = quantity;
                }
                else
                {
                    if (dict[name][0] != price)
                    {
                        dict[name][0] = price;
                        dict[name][1] += quantity;
                    }
                    else
                    {
                        dict[name][1] += quantity;
                    }
                }

                comand = Console.ReadLine();
            }

            foreach (var kvp in dict)
            {
                double totalPrice = dict[kvp.Key][0] * dict[kvp.Key][1];

                Console.WriteLine($"{kvp.Key} -> {totalPrice:f2}");
            }
        }
    }
}