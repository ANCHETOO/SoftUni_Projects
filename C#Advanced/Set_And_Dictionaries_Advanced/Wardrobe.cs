using System;
using System.Linq;
using System.Collections.Generic;

namespace Wardrobe
{
    class Wardrobe
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine()
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string color = line[0];
                string[] clothes = line[1]
                    .Split(",", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (dict.ContainsKey(color))
                {
                    for (int j = 0; j < clothes.Length; j++)
                    {
                        string curr = clothes[j];

                        if (dict[color].ContainsKey(curr))
                        {
                            dict[color][curr]++;
                        }
                        else
                        {
                            dict[color].Add(curr, 1);
                        }
                    }
                }
                else
                {
                    dict.Add(color, new Dictionary<string, int>());

                    for (int j = 0; j < clothes.Length; j++)
                    {
                        string curr = clothes[j];

                        if (dict[color].ContainsKey(curr))
                        {
                            dict[color][curr]++;
                        }
                        else
                        {
                            dict[color].Add(curr, 1);
                        }
                    }
                }
            }

            string lastLine = Console.ReadLine();
            string[] found = lastLine
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string colorFound = found[0];
            string clothFound = found[1];

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} clothes:");
                var currDict = item.Value;
                var color = item.Key;

                foreach (var cloth in currDict)
                {
                    if (color == colorFound && cloth.Key == clothFound)
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");

                    }
                    else
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                    }
                }

            }
        }
    }
}
