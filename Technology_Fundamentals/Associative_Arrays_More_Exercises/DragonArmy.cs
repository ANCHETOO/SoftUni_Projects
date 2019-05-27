using System;
using System.Collections.Generic;
using System.Linq;

namespace DragonArmy
{
    class DragonArmy
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, List<Dragon>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string type = input[0];
                string name = input[1];
                string dmg = input[2];
                string health = input[3];
                string armor = input[4];

                if (dmg == "null")
                {
                    dmg = "45";
                }

                if (health == "null")
                {
                    health = "250";
                }

                if (armor == "null")
                {
                    armor = "10";
                }

                var dragon = new Dragon()
                {
                    Name = name,
                    Dmg = int.Parse(dmg),
                    Health = int.Parse(health),
                    Armor = int.Parse(armor)
                };

                if (dict.ContainsKey(type) == false)
                {
                    dict.Add(type, new List<Dragon>());
                    dict[type].Add(dragon);
                }
                else
                {
                    bool haveDragon = false;
                    int index = -1;

                    for (int j = 0; j < dict[type].Count; j++)
                    {
                        if (dict[type][j].Name == dragon.Name)
                        {
                            haveDragon = true;
                            index = j;
                        }
                    }

                    if (haveDragon == false)
                    {
                        dict[type].Add(dragon); // da li go ima???
                    }
                    else
                    {
                        dict[type][index].Dmg = dragon.Dmg;
                        dict[type][index].Health = dragon.Health;
                        dict[type][index].Armor = dragon.Armor;
                    }
                }
            }

            foreach (var type in dict)
            {
                var dmgList = new List<decimal>();
                var healthList = new List<decimal>();
                var armorList = new List<decimal>();

                for (int i = 0; i < dict[type.Key].Count; i++)
                {
                    dmgList.Add(dict[type.Key][i].Dmg);
                    healthList.Add(dict[type.Key][i].Health);
                    armorList.Add(dict[type.Key][i].Armor);
                }

                Console.WriteLine($"{type.Key}::({dmgList.Average():f2}/{healthList.Average():f2}/{armorList.Average():f2})");

                foreach (var dragon in dict[type.Key].OrderBy(x => x.Name))
                {
                    Console.WriteLine($"-{dragon.Name} -> damage: {dragon.Dmg}, health: {dragon.Health}, armor: {dragon.Armor}");
                }
            }
        }
    }
    class Dragon
    {
        public string Name { get; set; }

        public int Dmg { get; set; }

        public int Health { get; set; }

        public int Armor { get; set; }
    }
}
