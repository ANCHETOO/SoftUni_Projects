using System;
using System.Collections.Generic;
using System.Linq;

namespace Ranking
{
    class Ranking
    {
        static void Main(string[] args)
        {
            var dictContests = new Dictionary<string, string>();
            var dictUsers = new Dictionary<string, Dictionary<string, int>>();
            string command = Console.ReadLine();

            while (command != "end of contests")
            {
                string[] line = command
                    .Split(":", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string contest = line[0];
                string password = line[1];

                if (dictContests.ContainsKey(contest))
                {
                    dictContests[contest] = password;
                }
                else
                {
                    dictContests.Add(contest, password);
                }

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "end of submissions")
            {
                string[] line = command
                    .Split("=>", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string contest = line[0];
                string password = line[1];
                string name = line[2];
                int points = int.Parse(line[3]);

                if (dictContests.ContainsKey(contest) == true)
                {
                    if (dictContests[contest] == password)
                    {
                        if (dictUsers.ContainsKey(name) == true)
                        {
                            if (dictUsers[name].ContainsKey(contest))
                            {
                                if (dictUsers[name][contest] < points)
                                {
                                    dictUsers[name][contest] = points;
                                }
                            }
                            else
                            {
                                dictUsers[name].Add(contest, points);
                            }
                        }
                        else
                        {
                            dictUsers.Add(name, new Dictionary<string, int>());
                            dictUsers[name].Add(contest, points);
                        }
                    }
                }

                command = Console.ReadLine();
            }

            string bestCandidate = string.Empty;
            int totalPoints = 0;

            foreach (var name in dictUsers)
            {
                int points = name.Value.Values.Sum();

                if (totalPoints < points)
                {
                    bestCandidate = name.Key;
                    totalPoints = points;
                }
            }

            Console.WriteLine($"Best candidate is {bestCandidate} with total {totalPoints} points.");
            Console.WriteLine($"Ranking: ");

            foreach (var item in dictUsers.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}");
                var curr = item.Value;

                foreach (var contest in curr.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}
