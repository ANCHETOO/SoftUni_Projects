using System;
using System.Linq;
using System.Collections.Generic;

namespace CardsGame
{
    class CardsGame
    {
        static void Main(string[] args)
        {
            var list1 = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            var list2 = Console.ReadLine()
               .Split(' ', StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();

            while (list1.Count > 0 && list2.Count > 0)
            {
                int curr1 = list1[0];
                int curr2 = list2[0];

                if (curr1 == curr2)
                {
                    list1.RemoveAt(0);
                    list2.RemoveAt(0);
                }
                else if (curr1 > curr2)
                {
                    list1.RemoveAt(0);
                    list2.RemoveAt(0);
                    list1.Add(curr1);
                    list1.Add(curr2);
                }
                else if (curr2 > curr1)
                {
                    list1.RemoveAt(0);
                    list2.RemoveAt(0);
                    list2.Add(curr2);
                    list2.Add(curr1);
                }
            }

            if (list1.Count > 0)
            {
                Console.WriteLine($"First player wins! Sum: {list1.Sum()}");
            }
            else if (list2.Count > 0)
            {
                Console.WriteLine($"Second player wins! Sum: {list2.Sum()}");
            }
            else if (list1.Count == 0 && list2.Count == 0)
            {
                Console.WriteLine($"First/Second player wins! Sum: {0}");
            }
        }
    }
}
