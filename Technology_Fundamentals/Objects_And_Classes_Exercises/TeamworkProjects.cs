using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamworkProjects
{
    class TeamworkProjects
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var list = new List<Team>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split('-', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = input[1];
                string creator = input[0];

                if (!CheckForTeam(list, name))
                {
                    Console.WriteLine($"Team {name} was already created!");
                }
                else
                {
                    if (!CheckForCreator(list, creator))
                    {
                        Console.WriteLine($"{creator} cannot create another team!");
                    }
                    else
                    {
                        var team = new Team(name, creator);
                        list.Add(team);
                        Console.WriteLine($"Team {name} has been created by {creator}!");
                    }
                }
            }

            string comand = Console.ReadLine();

            while (comand != "end of assignment")
            {
                var input = comand.Split("->", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string member = input[0];
                string name = input[1];
                int index = GetIndexOfTeam(list, name);

                if (index == -1)
                {
                    Console.WriteLine($"Team {name} does not exist!");
                }
                else
                {
                    if (!CheckForMember(list, member))
                    {
                        Console.WriteLine($"Member {member} cannot join team {name}!");
                    }
                    else
                    {
                        list[index].Members.Add(member);
                    }
                }

                comand = Console.ReadLine();
            }

            var listDisbanned = new List<Team>();
            var listValid = new List<Team>();

            foreach (var team in list)
            {
                if (team.Members.Count == 1)
                {
                    listDisbanned.Add(team);
                }
                else if (team.Members.Count > 1)
                {
                    listValid.Add(team);
                }
            }

            var listDisbannedSorted = listDisbanned.OrderBy(x => x.Name).ToList();
            var listValidSorted = listValid.OrderByDescending(x => x.Members.Count).ThenBy(x => x.Name).ToList();

            for (int i = 0; i < listValidSorted.Count; i++)
            {
                var currTeam = listValidSorted[i];

                Console.WriteLine(listValidSorted[i].Name);
                Console.WriteLine($"- {currTeam.Members[0]}");

                var members = new List<string>();

                for (int j = 1; j < currTeam.Members.Count; j++)
                {
                    members.Add(currTeam.Members[j]);
                }

                var result = members.OrderBy(x => x).ToList();

                for (int k = 0; k < result.Count; k++)
                {
                    Console.WriteLine($"-- {result[k]}");
                }
            }

            Console.WriteLine($"Teams to disband:");

            for (int i = 0; i < listDisbannedSorted.Count; i++)
            {
                Console.WriteLine($"{listDisbannedSorted[i].Name}");
            }
        }

        private static bool CheckForMember(List<Team> list, string member)
        {
            bool result = true;

            for (int j = 0; j < list.Count; j++)
            {
                var currTeam = list[j];

                for (int i = 0; i < currTeam.Members.Count; i++)
                {
                    var currMember = currTeam.Members[i];

                    if (currMember == member)
                    {
                        result = false;
                        break;
                    }
                }
            }

            return result;
        }

        private static int GetIndexOfTeam(List<Team> list, string name)
        {
            int index = -1;

            for (int j = 0; j < list.Count; j++)
            {
                var currTeam = list[j];

                if (currTeam.Name == name)
                {
                    index = j;
                    break;
                }
            }

            return index;
        }

        private static bool CheckForCreator(List<Team> list, string creator)
        {
            bool result = true;

            for (int j = 0; j < list.Count; j++)
            {
                var currTeam = list[j];

                if (currTeam.Creator == creator)
                {
                    result = false;
                    break;
                }
            }

            return result;
        }


        private static bool CheckForTeam(List<Team> list, string name)
        {
            bool result = true;

            for (int j = 0; j < list.Count; j++)
            {
                var currTeam = list[j];

                if (currTeam.Name == name)
                {
                    result = false;
                    break;
                }
            }

            return result;
        }
    }

    class Team
    {
        public string Name { get; set; }

        public string Creator { get; set; }

        public List<string> Members { get; set; }

        public Team(string name, string member)
        {
            Name = name;
            Members = new List<string>();
            Members.Add(member);
            Creator = Members[0];
        }
    }
}
