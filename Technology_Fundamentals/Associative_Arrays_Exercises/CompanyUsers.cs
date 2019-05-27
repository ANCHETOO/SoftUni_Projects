using System;
using System.Linq;
using System.Collections.Generic;

namespace CompanyUsers
{
    class CompanyUsers
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();
            var dict = new SortedDictionary<string, List<string>>();

            while (comand != "End")
            {
                string[] input = comand.Split(" -> ").ToArray();
                string name = input[0];
                string id = input[1];

                if (!dict.ContainsKey(name))
                {
                    dict.Add(name, new List<string>());
                    dict[name].Add(id);
                }
                else
                {
                    if (!dict[name].Contains(id))
                    {
                        dict[name].Add(id);
                    }
                }

                comand = Console.ReadLine();
            }

            foreach (var kvp in dict)
            {
                Console.WriteLine(kvp.Key);

                for (int i = 0; i < dict[kvp.Key].Count; i++)
                {
                    Console.WriteLine($"-- {dict[kvp.Key][i]}");
                }
            }
        }
    }
}

