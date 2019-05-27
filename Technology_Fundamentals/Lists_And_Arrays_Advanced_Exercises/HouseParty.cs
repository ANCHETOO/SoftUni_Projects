using System;
using System.Collections.Generic;
using System.Linq;

namespace HouseParty
{
    class HouseParty
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();

            for (int i = 0; i < n; i++)
            {
                List<string> input = Console.ReadLine().Split(' ').ToList();

                if (input[2] == "going!")
                {
                    if (guests.Contains(input[0]))
                    {
                        Console.WriteLine($"{input[0]} is already in the list!");
                    }
                    else
                    {
                        guests.Add(input[0]);
                    }
                }
                else
                {
                    if (guests.Contains(input[0]))
                    {
                        guests.Remove(input[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{input[0]} is not in the list!");
                    }
                }
            }

            for (int j = 0; j < guests.Count; j++)
            {
                Console.WriteLine(guests[j]);
            }
        }
    }
}
