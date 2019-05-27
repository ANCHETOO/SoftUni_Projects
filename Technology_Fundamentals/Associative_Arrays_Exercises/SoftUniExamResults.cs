using System;
using System.Linq;
using System.Collections.Generic;

namespace SoftUniExamResults
{
    class SoftUniExamResults
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();
            var dict = new Dictionary<string, int>();
            var languages = new Dictionary<string, int>();

            while (comand != "exam finished")
            {
                List<string> input = comand.Split('-').ToList();
                string name = input[0];
                string language = input[1];
                int points = 0;

                if (input.Count > 2)
                {
                    points = int.Parse(input[2]);
                }

                if (!dict.ContainsKey(name))
                {
                    if (language != "banned")
                    {
                        dict.Add(name, points);

                        if (!languages.ContainsKey(language))
                        {
                            languages.Add(language, 1);
                        }
                        else
                        {
                            languages[language]++;
                        }
                    }
                }
                else
                {
                    if (language != "banned")
                    {
                        if (dict[name] < points)
                        {
                            dict[name] = points;
                        }

                        if (!languages.ContainsKey(language))
                        {
                            languages.Add(language, 1);
                        }
                        else
                        {
                            languages[language]++;
                        }
                    }
                    else
                    {
                        dict.Remove(name);
                    }
                }

                comand = Console.ReadLine();
            }

            Console.WriteLine($"Results:");
            var result = dict.OrderBy(kvp => kvp.Key).OrderByDescending(kvp => kvp.Value);

            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key} | {kvp.Value}");
            }

            Console.WriteLine($"Submissions:");
            var resultLanguages = languages.OrderBy(kvp => kvp.Key).OrderByDescending(kvp => kvp.Value);

            foreach (var kvp in resultLanguages)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }
        }
    }
}
