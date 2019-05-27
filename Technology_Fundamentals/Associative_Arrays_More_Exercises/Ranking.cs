using System;
using System.Linq;
using System.Collections.Generic;

namespace Ranking
{
    class Ranking
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();
            var dictContests = new Dictionary<string, string>();

            while (comand != "end of contests")
            {
                var input = comand.Split(':', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string contestName = input[0];
                string password = input[1];
                dictContests.Add(contestName, password);
                comand = Console.ReadLine();
            }

            comand = Console.ReadLine();
            var dict = new Dictionary<string, Dictionary<string, int>>();

            while (comand != "end of submissions")
            {
                var input = comand.Split("=>", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string contestName = input[0];
                string password = input[1];
                string user = input[2];
                int points = int.Parse(input[3]);

                if (dictContests.ContainsKey(contestName) == true)
                {
                    if (dictContests[contestName] == password)
                    {
                        if (dict.ContainsKey(user) == true)
                        {
                            if (dict[user].ContainsKey(contestName) == true)
                            {
                                if (dict[user][contestName] < points)
                                {
                                    dict[user][contestName] = points;
                                }
                            }
                            else
                            {
                                dict[user].Add(contestName, points);
                            }
                        }
                        else
                        {
                            dict.Add(user, new Dictionary<string, int>());
                            dict[user].Add(contestName, points);
                        }
                    }
                }

                comand = Console.ReadLine();
            }

            string userWithMaxPoints = string.Empty;
            int pointsOfUserWithMaxPoints = int.MinValue;

            foreach (var user in dict)
            {
                int currPoints = user.Value.Values.Sum();

                if (currPoints > pointsOfUserWithMaxPoints)
                {
                    pointsOfUserWithMaxPoints = currPoints;
                    userWithMaxPoints = user.Key;
                }
            }

            Console.WriteLine($"Best candidate is {userWithMaxPoints} with total {pointsOfUserWithMaxPoints} points.");
            Console.WriteLine($"Ranking: ");
            var sorted = dict.OrderBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);

            foreach (var kvp in sorted)
            {
                Console.WriteLine($"{kvp.Key}");
                var sortedPoints = kvp.Value.OrderByDescending(x => x.Value);

                foreach (var item in sortedPoints)
                {
                    Console.WriteLine($"#  {item.Key} -> {item.Value}");
                }
            }
        }
    }
}
