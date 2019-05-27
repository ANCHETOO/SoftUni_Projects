using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniParking
{
    class SoftUniParking
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                List<string> input = Console.ReadLine().Split(' ').ToList();
                string name = input[1];

                if (input[0] == "register")
                {
                    string license = input[2];

                    if (!dict.ContainsKey(name))
                    {
                        dict.Add(name, license);
                        Console.WriteLine($"{name} registered {license} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {license}");
                    }
                }
                else if (input[0] == "unregister")
                {
                    if (dict.ContainsKey(name))
                    {
                        dict.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                }
            }

            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}
