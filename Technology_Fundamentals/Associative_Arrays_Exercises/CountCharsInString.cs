using System;
using System.Collections.Generic;

namespace CountCharsInString
{
    class CountCharsInString
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var dict = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                char letter = input[i];

                if (letter != ' ')
                {
                    if (!dict.ContainsKey(letter))
                    {
                        dict.Add(letter, 1);
                    }
                    else
                    {
                        dict[letter]++;
                    }
                }
            }

            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}