using System;
using System.Linq;
using System.Collections.Generic;

namespace PokemonDontGo
{
    class PokemonDontGo
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int sum = 0;

            while (list.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());

                if (index >= 0 && index < list.Count)
                {
                    int num = list[index];
                    sum += num;
                    list.RemoveAt(index);
                    DecreaseIncreaseElements(num, list);
                }
                else if (index < 0)
                {
                    int num = list[0];
                    sum += num;
                    list[0] = list[list.Count - 1];
                    DecreaseIncreaseElements(num, list);
                }
                else if (index >= list.Count)
                {
                    int num = list[list.Count - 1];
                    sum += num;
                    list[list.Count - 1] = list[0];
                    DecreaseIncreaseElements(num, list);
                }
            }

            Console.WriteLine(sum);
        }

        private static void DecreaseIncreaseElements(int num, List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (num < list[i])
                {
                    list[i] -= num;
                }
                else if (num >= list[i])
                {
                    list[i] += num;
                }
            }
        }
    }
}
