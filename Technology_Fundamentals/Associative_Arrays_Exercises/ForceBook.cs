using System;
using System.Linq;
using System.Collections.Generic;

namespace ForceBook
{
    class ForceBook
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();
            var dict = new Dictionary<string, List<string>>();

            while (comand != "Lumpawaroo")
            {
                var input = comand.Split(" | ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (input.Length == 2)
                {
                    string side = input[0];
                    string name = input[1];

                    if (dict.ContainsKey(side) == true)
                    {
                        if (!dict.Any(x => x.Value.Contains(name)))
                        {
                            dict[side].Add(name);
                        }
                    }
                    else if (dict.ContainsKey(side) == false)
                    {
                        dict.Add(side, new List<string>());

                        if (!dict.Any(x => x.Value.Contains(name)))
                        {
                            dict[side].Add(name);
                        }
                    }
                }
                else
                {
                    input = comand.Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string side = input[1];
                    string name = input[0];

                    if (dict.ContainsKey(side) == true)
                    {
                        if (!dict.Any(x => x.Value.Contains(name)))
                        {
                            dict[side].Add(name);
                            Console.WriteLine($"{name} joins the {side} side!");
                        }
                        else
                        {
                            foreach (var user in dict)
                            {
                                if (dict[user.Key].Contains(name))
                                {
                                    dict[user.Key].Remove(name);
                                    dict[side].Add(name);
                                    Console.WriteLine($"{name} joins the {side} side!");
                                    break;
                                }
                            }
                        }
                    }
                    else
                    {
                        if (!dict.Any(x => x.Value.Contains(name)))
                        {
                            dict.Add(side, new List<string>());
                            dict[side].Add(name);
                            Console.WriteLine($"{name} joins the {side} side!");
                        }
                        else
                        {
                            string matched = string.Empty;

                            foreach (var user in dict)
                            {
                                if (dict[user.Key].Contains(name))
                                {
                                    matched = user.Key;
                                }
                            }

                            dict[matched].Remove(name);
                            dict.Add(side, new List<string>());
                            dict[side].Add(name);
                            Console.WriteLine($"{name} joins the {side} side!");
                        }
                    }
                }

                comand = Console.ReadLine();
            }

            var sorted = dict.OrderByDescending(x => x.Value.Count).ThenBy(y => y.Key).ToDictionary(x => x.Key, y => y.Value);

            foreach (var side in sorted)
            {
                if (side.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");

                    foreach (var name in side.Value.OrderBy(x => x))
                    {
                        Console.WriteLine($"! {name}");
                    }
                }
            }
        }
    }
}
