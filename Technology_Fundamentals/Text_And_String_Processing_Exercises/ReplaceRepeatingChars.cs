using System;
using System.Collections.Generic;

namespace ReplaceRepeatingChars
{
    class ReplaceRepeatingChars
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            var list = new List<char>();
            char prev = new Char();

            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];

                if (ch != prev)
                {
                    list.Add(ch);
                    prev = ch;
                }
                else
                {
                    continue;
                }
            }

            Console.WriteLine(string.Join("", list));
        }
    }
}