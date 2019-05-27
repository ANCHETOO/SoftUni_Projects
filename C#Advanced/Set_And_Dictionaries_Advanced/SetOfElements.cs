using System;
using System.Collections.Generic;
using System.Linq;

namespace SetOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] line = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var set1 = new HashSet<int>();
            var set2 = new HashSet<int>();

            for (int i = 0; i < line[0]; i++)
            {
                set1.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < line[1]; i++)
            {
                set2.Add(int.Parse(Console.ReadLine()));
            }

            foreach (var item in set1)
            {
                if (set2.Contains(item))
                {
                    Console.Write($"{item} ");
                }
            }

            Console.WriteLine();
        }
    }
}
