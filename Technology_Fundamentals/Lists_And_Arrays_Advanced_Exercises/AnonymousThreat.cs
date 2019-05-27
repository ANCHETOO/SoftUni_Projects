using System;
using System.Linq;
using System.Collections.Generic;

namespace AnonymousThreat
{
    class AnonymousThreat
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string comand = Console.ReadLine();

            while (comand != "3:1")
            {
                string[] input = comand
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string opr = input[0];

                if (opr == "merge")
                {
                    int startIndex = int.Parse(input[1]);
                    int endIndex = int.Parse(input[2]);

                    if (startIndex < 0 && endIndex < list.Count && endIndex >= 0)
                    {
                        startIndex = 0;
                        MergeList(list, startIndex, endIndex);
                    }
                    else if (startIndex >= 0 && endIndex < list.Count)
                    {
                        MergeList(list, startIndex, endIndex);
                    }
                    else if (startIndex < 0 && endIndex >= list.Count)
                    {
                        startIndex = 0;
                        endIndex = list.Count - 1;
                        MergeList(list, startIndex, endIndex);
                    }
                    else if (startIndex >= 0 && startIndex < list.Count && endIndex >= list.Count)
                    {
                        endIndex = list.Count - 1;
                        MergeList(list, startIndex, endIndex);
                    }
                }
                else if (opr == "divide")
                {
                    int index = int.Parse(input[1]);
                    int count = int.Parse(input[2]);
                    DivideList(list, index, count);
                }

                comand = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ", list));
        }

        private static void DivideList(List<string> list, int index, int count)
        {
            string divided = list[index];
            int substrIndex = 0;
            list.RemoveAt(index);
            string substr = String.Empty;

            for (int i = 0; i < count - 1; i++)
            {
                substr = divided.Substring(substrIndex, divided.Length / count);
                substrIndex += divided.Length / count;
                list.Insert(index, substr);
                index++;
            }

            substr = divided.Substring(substrIndex);
            list.Insert(index, substr);
        }

        private static void MergeList(List<string> list, int startIndex, int endIndex)
        {
            string merged = String.Empty;

            for (int i = startIndex; i <= endIndex; i++)
            {
                merged += list[i];
            }

            list.Insert(startIndex, merged);
            int index = startIndex + 1;

            for (int j = startIndex; j <= endIndex; j++)
            {
                list.RemoveAt(index);
            }
        }
    }
}
