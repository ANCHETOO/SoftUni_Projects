using System;
using System.Linq;
using System.Collections.Generic;

namespace StudentAcademy
{
    class StudentAcademy
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double mark = double.Parse(Console.ReadLine());

                if (!dict.ContainsKey(name))
                {
                    dict.Add(name, new List<double>());
                    dict[name].Add(mark);
                }
                else
                {
                    dict[name].Add(mark);
                }
            }

            var result = dict.OrderByDescending(kvp => dict[kvp.Key].Average()).Where(kvp => dict[kvp.Key].Average() >= 4.5);

            foreach (var kvp in result)
            {
                double avarage = dict[kvp.Key].Average();
                Console.WriteLine($"{kvp.Key} -> {avarage:f2}");
            }
        }
    }
}
