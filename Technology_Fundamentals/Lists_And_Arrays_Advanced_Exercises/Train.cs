using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Train
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            int n = int.Parse(Console.ReadLine());
            string comand = Console.ReadLine();

            while (comand != "end")
            {
                string[] step = comand.Split(' ').ToArray();

                if (step[0] == "Add")
                {
                    wagons.Add(int.Parse(step[1]));
                }
                else
                {
                    int passengers = int.Parse(step[0]);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (passengers + wagons[i] <= n)
                        {
                            wagons[i] += passengers;
                            break;
                        }
                    }
                }

                comand = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', wagons));
        }
    }
}
