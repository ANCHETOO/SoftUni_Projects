using System;
using System.Linq;
using System.Collections.Generic;

namespace BombNumbers
{
    class BombNumbers
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string bombNumber = input[0];
            int power = int.Parse(input[1]);

            MarkBomsInList(list, bombNumber, power);

            int sum = 0;

            if (list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] != "*" && list[i] != "X")
                    {
                        sum += int.Parse(list[i]);
                    }
                }

                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine(0);
            }
        }

        private static void MarkBomsInList(List<string> list, string bombNumber, int power)
        {
            if (list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    string curr = list[i];

                    if (curr == bombNumber)
                    {
                        list[i] = "*";
                        MarkElementsToDetonateInListAtIndex(list, i, power);
                    }
                }
            }
        }

        private static void MarkElementsToDetonateInListAtIndex(List<string> list, int i, int power)
        {
            int startIndex = i - power;

            if (startIndex <= 0)
            {
                startIndex = 0;
            }

            for (int j = startIndex; j < i; j++)
            {
                if (list[j] != "*")
                {
                    list[j] = "X";
                }
            }

            int endIndex = i + power;

            if (endIndex >= list.Count)
            {
                endIndex = list.Count - 1;
            }

            for (int k = i + 1; k <= endIndex; k++)
            {
                if (list[k] != "*")
                {
                    list[k] = "X";
                }
            }
        }
    }
}
