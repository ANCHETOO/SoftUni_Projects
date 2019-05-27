using System;
using System.Linq;
using System.Collections.Generic;

namespace LegendaryFarming
{
    class LegendaryFarming
    {
        static void Main(string[] args)
        {
            bool obtained = false;
            var dict = new SortedDictionary<string, int>();
            var dictSpecial = new SortedDictionary<string, int>();
            dictSpecial.Add("motes", 0);
            dictSpecial.Add("fragments", 0);
            dictSpecial.Add("shards", 0);

            while (true)
            {
                string[] input = Console.ReadLine()
                    .ToLower()
                    .Split(' ')
                    .ToArray();

                for (int i = 1; i < input.Length; i += 2)
                {
                    int j = i - 1;

                    switch (input[i])
                    {
                        case "motes":
                            {
                                if (!dictSpecial.ContainsKey(input[i]))
                                {
                                    dictSpecial.Add((input[i]), int.Parse(input[j]));
                                }
                                else
                                {
                                    dictSpecial[input[i]] += int.Parse(input[j]);
                                }

                                if (dictSpecial["motes"] >= 250)
                                {
                                    dictSpecial["motes"] -= 250;
                                    Console.WriteLine("Dragonwrath obtained!");
                                    obtained = true;
                                }

                                break;
                            }
                        case "fragments":
                            {
                                if (!dictSpecial.ContainsKey(input[i]))
                                {
                                    dictSpecial.Add((input[i]), int.Parse(input[j]));
                                }
                                else
                                {
                                    dictSpecial[input[i]] += int.Parse(input[j]);
                                }

                                if (dictSpecial["fragments"] >= 250)
                                {
                                    dictSpecial["fragments"] -= 250;
                                    Console.WriteLine("Valanyr obtained!");
                                    obtained = true;
                                }

                                break;
                            }
                        case "shards":
                            {
                                if (!dictSpecial.ContainsKey(input[i]))
                                {
                                    dictSpecial.Add((input[i]), int.Parse(input[j]));
                                }
                                else
                                {
                                    dictSpecial[input[i]] += int.Parse(input[j]);
                                }

                                if (dictSpecial["shards"] >= 250)
                                {
                                    dictSpecial["shards"] -= 250;
                                    Console.WriteLine("Shadowmourne obtained!");
                                    obtained = true;
                                }

                                break;
                            }

                        default:
                            {
                                if (!dict.ContainsKey(input[i]))
                                {

                                    dict.Add((input[i]), int.Parse(input[j]));
                                }
                                else
                                {
                                    dict[input[i]] += int.Parse(input[j]);
                                }

                                break;
                            }
                    }

                    if (obtained == true)
                    {
                        break;
                    }
                }

                if (obtained == true)
                {
                    break;
                }
            }

            var result = dictSpecial.OrderByDescending(x => x.Value).ThenBy(x => x.Key);

            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
