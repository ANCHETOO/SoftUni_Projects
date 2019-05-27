using System;
using System.Text.RegularExpressions;

namespace ExtractPersonInformation
{
    class ExtractPersonInformation
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string text = Console.ReadLine();
                string patternName = @"\@(?<name>[A-Za-z]+)\|";
                string patternAge = @"\#(?<age>[\d]+)\*";
                var matchName = Regex.Match(text, patternName);
                var matchAge = Regex.Match(text, patternAge);

                if (matchName.Success && matchAge.Success)
                {
                    string name = matchName.Groups["name"].Value;
                    string age = matchAge.Groups["age"].Value;
                    Console.WriteLine($"{name} is {age} years old.");
                }
            }
        }
    }
}
