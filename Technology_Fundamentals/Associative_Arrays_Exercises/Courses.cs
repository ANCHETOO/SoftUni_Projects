using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Courses
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();
            var dict = new Dictionary<string, List<string>>();

            while (comand != "end")
            {
                string[] input = comand.Split(" : ").ToArray();
                string course = input[0];
                string name = input[1];

                if (!dict.ContainsKey(course))
                {
                    dict.Add(course, new List<string>());
                    dict[course].Add(name);
                }
                else
                {
                    dict[course].Add(name);
                }
                comand = Console.ReadLine();
            }

            var ordered = dict.OrderByDescending(kvp => dict[kvp.Key].Count);

            foreach (var kvp in ordered)
            {
                Console.WriteLine($"{kvp.Key}: {dict[kvp.Key].Count}");
                dict[kvp.Key].Sort();

                for (int i = 0; i < dict[kvp.Key].Count; i++)
                {
                    Console.WriteLine($"-- {dict[kvp.Key][i]}");
                }
            }
        }
    }
}