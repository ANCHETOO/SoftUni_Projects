using System;
using System.Collections.Generic;
using System.Linq;

namespace Judge
{
    class Judge
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();
            var users = new Dictionary<string, Dictionary<string, int>>();
            var contests = new Dictionary<string, Dictionary<string, int>>();

            while (comand != "no more time")
            {
                var input = comand.Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = input[0];
                string contestName = input[1];
                int contestPoints = int.Parse(input[2]);

                if (contests.ContainsKey(contestName) == true)
                {
                    if (contests[contestName].ContainsKey(name) == true)
                    {
                        if (contests[contestName][name] < contestPoints)
                        {
                            contests[contestName][name] = contestPoints;
                        }
                    }
                    else
                    {
                        contests[contestName].Add(name, contestPoints);
                    }
                }
                else
                {
                    contests.Add(contestName, new Dictionary<string, int>());
                    contests[contestName].Add(name, contestPoints);
                }

                if (users.ContainsKey(name) == true)
                {
                    if (users[name].ContainsKey(contestName) == true)
                    {
                        if (users[name][contestName] < contestPoints)
                        {
                            users[name][contestName] = contestPoints;
                        }
                    }
                    else
                    {
                        users[name].Add(contestName, contestPoints);
                    }
                }
                else
                {
                    users.Add(name, new Dictionary<string, int>());
                    users[name].Add(contestName, contestPoints);
                }

                comand = Console.ReadLine();
            }

            int counter = 1;

            foreach (var item in contests)
            {
                Console.WriteLine($"{item.Key}: {contests[item.Key].Count} participants");
                counter = 1;
                var dict = contests[item.Key]
                    .OrderByDescending(x => x.Value)
                    .ThenBy(x => x.Key)
                    .ToDictionary(x => x.Key, x => x.Value);

                foreach (var kvp in dict)
                {
                    Console.WriteLine($"{counter++}. {kvp.Key} <::> {kvp.Value}");
                }
            }

            Console.WriteLine($"Individual standings:");
            counter = 1;
            var sorted = users.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in sorted)
            {
                Console.WriteLine($"{counter++}. {item.Key} -> {item.Value.Values.Sum()}");
            }
        }
    }
}