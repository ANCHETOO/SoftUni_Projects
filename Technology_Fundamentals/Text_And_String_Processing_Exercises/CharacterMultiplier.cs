using System;

namespace CharacterMultiplier
{
    class CharacterMultiplier
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string first = input[0];
            string second = input[1];
            Console.WriteLine(GetMultiplificationOfCharsOfTwoStrings(first, second));
        }

        private static int GetMultiplificationOfCharsOfTwoStrings(string first, string second)
        {
            int result = 0;

            if (first.Length > second.Length)
            {
                string temp = first;
                first = second;
                second = temp;
            }

            for (int i = 0; i < first.Length; i++)
            {
                result += ((int)first[i]) * ((int)second[i]);
            }

            for (int j = first.Length; j < second.Length; j++)
            {
                result += (int)second[j];
            }

            return result;
        }
    }
}
