using System;
using System.Collections.Generic;
using System.Linq;

namespace PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var set = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int j = 0; j < line.Length; j++)
                {
                    set.Add(line[j]);
                }
            }

            foreach (var item in set)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
        }
    }
}
