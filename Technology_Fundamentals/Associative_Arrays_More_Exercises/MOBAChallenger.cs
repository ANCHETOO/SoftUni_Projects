using System;
using System.Linq;
using System.Collections.Generic;

namespace MOBAChallenger
{
    class MOBAChallenger
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();
            var dict = new Dictionary<string, Dictionary<string, int>>();

            while (comand != "Season end")
            {
                var input = comand.Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (input.Length > 1)
                {
                    string name = input[0];
                    string line = input[1];
                    int skills = int.Parse(input[2]);

                    if (dict.ContainsKey(name) == true)
                    {
                        if (dict[name].ContainsKey(line) == true)
                        {
                            if (dict[name][line] < skills)
                            {
                                dict[name][line] = skills;
                            }
                        }
                        else
                        {
                            dict[name].Add(line, skills);
                        }
                    }
                    else
                    {
                        dict.Add(name, new Dictionary<string, int>());
                        dict[name].Add(line, skills);
                    }
                }
                else
                {
                    var duel = input[0].Split(" vs ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string firstName = duel[0];
                    string secondName = duel[1];

                    if (dict.ContainsKey(firstName) && dict.ContainsKey(secondName))
                    {
                        foreach (var item in dict[firstName])
                        {
                            string line = item.Key;

                            if (dict[secondName].ContainsKey(line))
                            {
                                if (dict[firstName].Values.Sum() > dict[secondName].Values.Sum())
                                {
                                    dict.Remove(secondName);
                                    break;
                                }
                                else if (dict[firstName].Values.Sum() < dict[secondName].Values.Sum())
                                {
                                    dict.Remove(firstName);
                                    break;
                                }
                            }
                        }
                    }
                }

                comand = Console.ReadLine();
            }

            if (dict.Count > 0)
            {
                var sortedDict = dict.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

                foreach (var item in sortedDict)
                {
                    Console.WriteLine($"{item.Key}: {sortedDict[item.Key].Values.Sum()} skill");
                    var sortedLine = sortedDict[item.Key].OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

                    foreach (var line in sortedLine)
                    {
                        Console.WriteLine($"- {line.Key} <::> {line.Value}");
                    }
                }
            }
        }
    }
}
