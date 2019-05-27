using System;
using System.Linq;
using System.Collections.Generic;

namespace Snowwhite
{
    class Snowwhite
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();
            var list = new List<Dwarf>();

            while (comand != "Once upon a time")
            {
                var input = comand.Split(" <:> ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = input[0];
                string hatColor = input[1];
                int physic = int.Parse(input[2]);

                if (HaveName(list, name) == false)
                {
                    var dwarf = new Dwarf()
                    {
                        Name = name,
                        HatColor = hatColor,
                        Physic = physic
                    };
                    list.Add(dwarf);
                }
                else
                {
                    int index = GetIndex(list, name, hatColor);

                    if (index != -1)
                    {
                        if (list[index].HatColor == hatColor)
                        {
                            if (list[index].Physic < physic)
                            {
                                list[index].Physic = physic;
                            }
                        }
                    }
                    else
                    {
                        var dwarf = new Dwarf()
                        {
                            Name = name,
                            HatColor = hatColor,
                            Physic = physic
                        };
                        list.Add(dwarf);
                    }
                }

                comand = Console.ReadLine();
            }

            foreach (var dwarf in list.OrderByDescending(x => x.Physic).ThenByDescending(x => list.Count(y => y.HatColor == x.HatColor)))
            {
                Console.WriteLine($"({dwarf.HatColor}) {dwarf.Name} <-> {dwarf.Physic}");
            }
        }

        private static int GetIndex(List<Dwarf> list, string name, string hatColor)
        {
            int index = -1;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Name == name && list[i].HatColor == hatColor)
                {
                    index = i;
                }
            }

            return index;
        }

        private static bool HaveName(List<Dwarf> list, string name)
        {
            bool haveName = false;

            foreach (var item in list)
            {
                string currName = item.Name;

                if (currName == name)
                {
                    haveName = true;
                    break;
                }
            }

            return haveName;
        }
    }

    class Dwarf
    {
        public string Name { get; set; }

        public string HatColor { get; set; }

        public int Physic { get; set; }
    }
}
