using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace TreasureFinder
{
    class TreasureFinder
    {
        static void Main(string[] args)
        {
            string sequance = Console.ReadLine();
            string comand = Console.ReadLine();

            while (comand != "find")
            {
                var queue = new Queue<int>();

                foreach (var ch in sequance)
                {
                    if (char.IsDigit(ch) == true)
                    {
                        queue.Enqueue(int.Parse(ch.ToString()));
                    }
                }

                var sb = new StringBuilder();

                foreach (var ch in comand)
                {
                    int curr = queue.Peek();
                    int ascii = (int)ch - curr;
                    queue.Dequeue();
                    queue.Enqueue(curr);
                    sb.Append((char)ascii);
                }

                string decripted = sb.ToString();
                string treasure = string.Empty;
                string coordinates = string.Empty;
                string pattern1 = @"(?:\&)([^\&]+)(?:\&)";
                string pattern2 = @"(?:\<)([^\<\>]+)(?:\>)";
                var regex1 = new Regex(pattern1);
                var match1 = regex1.Match(decripted);

                if (match1.Success)
                {
                    treasure = match1.Groups[1].Value;
                }

                var regex2 = new Regex(pattern2);
                var match2 = regex2.Match(decripted);

                if (match2.Success)
                {
                    coordinates = match2.Groups[1].Value;
                }

                Console.WriteLine($"Found {treasure} at {coordinates}");
                comand = Console.ReadLine();
            }
        }
    }
}