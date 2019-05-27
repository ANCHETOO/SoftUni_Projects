using System;
using System.Collections.Generic;
using System.Linq;

namespace TakeOrSkipRope
{
    class TakeOrSkipRope
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<int> numbers = new List<int>();
            List<char> letters = new List<char>();

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    numbers.Add(int.Parse(input[i].ToString()));
                }
                else
                {
                    letters.Add(input[i]);
                }
            }

            int count = 0;
            int index = 0;
            List<char> result = new List<char>();

            for (int j = 0; j < numbers.Count; j++)
            {
                count = numbers[j];

                if (j % 2 == 0)
                {
                    if (count > 0)
                    {
                        for (int k = 1; k <= count; k++)
                        {
                            result.Add(letters[index]);
                            index++;
                        }
                    }
                }
                else
                {
                    if (count > 0)
                    {
                        for (int l = 1; l <= count; l++)
                        {
                            index++;
                        }
                    }
                }
            }

            foreach (var element in result)
            {
                Console.Write(element);
            }

            Console.WriteLine();
        }
    }
}
