using System;
using System.Collections.Generic;

namespace MinerTask
{
    class MinerTask
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();
            var dict = new Dictionary<string, int>();

            while (comand != "stop")
            {
                string resource = comand;
                int quantity = int.Parse(Console.ReadLine());

                if (!dict.ContainsKey(resource))
                {
                    dict.Add(resource, quantity);
                }
                else
                {
                    dict[resource] += quantity;
                }

                comand = Console.ReadLine();
            }

            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}