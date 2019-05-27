using System;
using System.Linq;
using System.Collections.Generic;

namespace TheVLogger
{
    class TheVLoger
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, int[]>();
            var dictFollowers = new Dictionary<string, List<string>>();
            string command = Console.ReadLine();

            while (command != "Statistics")
            {
                string[] line = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (line[1] == "joined")
                {
                    string name = line[0];

                    if (dict.ContainsKey(name))
                    {
                        //ignore
                    }
                    else
                    {
                        int[] count = new int[2];
                        count[0] = 0;
                        count[1] = 0;

                        dict.Add(name, count);
                        dictFollowers.Add(name, new List<string>());
                    }
                }
                else
                {
                    string name = line[2];
                    string nameFollower = line[0];

                    if (dict.ContainsKey(name) == true && dict.ContainsKey(nameFollower) == true)
                    {
                        if (name != nameFollower && dictFollowers[name].Contains(nameFollower) == false)
                        {
                            dict[name][0]++;
                            dict[nameFollower][1]++;
                            dictFollowers[name].Add(nameFollower);
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"The V-Logger has a total of {dict.Count} vloggers in its logs.");

            var max = dict.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Value[1]);

            int counter = 1;

            foreach (var item in max)
            {
                Console.WriteLine($"{counter++}. {item.Key} : {item.Value[0]} followers, {item.Value[1]} following");

                if (counter == 2)
                {
                    var followerList = dictFollowers[item.Key].OrderBy(x => x);

                    foreach (var follower in followerList)
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }
            }
        }
    }
}
