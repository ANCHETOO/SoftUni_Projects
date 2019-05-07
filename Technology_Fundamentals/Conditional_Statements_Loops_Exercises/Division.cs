using System;
using System.Collections.Generic;

namespace Division
{
    class Division
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var divisions = new List<int>();

            if (n % 2 == 0)
            {
                divisions.Add(2);
            }

            if (n % 3 == 0)
            {
                divisions.Add(3);
            }

            if (n % 6 == 0)
            {
                divisions.Add(6);
            }

            if (n % 7 == 0)
            {
                divisions.Add(7);
            }

            if (n % 10 == 0)
            {
                divisions.Add(10);
            }

            if (divisions.Count>0)
            {
                Console.WriteLine($"The number is divisible by {divisions[divisions.Count-1]}");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}
