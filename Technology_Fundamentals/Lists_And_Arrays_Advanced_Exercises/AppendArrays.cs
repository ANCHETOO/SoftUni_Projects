using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendArrays
{
    class AppendArrays
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<int> numbers = new List<int>();
            string item = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                char curr = input[i];

                if (curr != '|')
                {
                    item += curr;
                }
                else
                {
                    PushElements(numbers, SortArr(item));
                    item = string.Empty;
                }
            }

            PushElements(numbers, SortArr(item));
            numbers.Reverse();
            Console.WriteLine(string.Join(' ', numbers));
        }

        public static List<int> SortArr(string item)
        {
            List<int> imbaded = item.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList(); ;
            imbaded.Reverse();
            return imbaded;
        }

        public static List<int> PushElements(List<int> numbers, List<int> input)
        {
            for (int j = 0; j < input.Count; j++)
            {
                numbers.Add(input[j]);
            }

            return numbers;
        }
    }
}
