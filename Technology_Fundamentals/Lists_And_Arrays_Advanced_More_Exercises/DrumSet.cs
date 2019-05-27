using System;
using System.Linq;
using System.Collections.Generic;

namespace DrumSet
{
    class DrumSet
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            List<int> drumset = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            List<int> drums = new List<int>();

            for (int i = 0; i < drumset.Count; i++)
            {
                drums.Add(drumset[i]);
            }

            string comand = Console.ReadLine();

            while (comand != "Hit it again, Gabsy!")
            {
                int hit = int.Parse(comand);

                for (int j = 0; j < drums.Count; j++)
                {
                    if ((drums[j] - hit) > 0 && drumset[j] != 0)
                    {
                        drums[j] = drums[j] - hit;
                    }
                    else
                    {
                        if ((budget - 3 * drumset[j]) >= 0 && drumset[j] != 0)
                        {
                            drums[j] = drumset[j];
                            budget -= 3 * drumset[j];
                        }
                        else
                        {
                            drumset[j] = 0;
                        }
                    }
                }

                comand = Console.ReadLine();
            }

            for (int m = 0; m < drums.Count; m++)
            {
                if (drumset[m] != 0)
                {
                    Console.Write(drums[m] + " ");
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Gabsy has {budget:f2}lv.");
        }
    }
}
