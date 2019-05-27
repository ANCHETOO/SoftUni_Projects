using System;

namespace VowelsCount
{
    class VowelsCount
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(GetVowelsCount(input));
        }

        public static int GetVowelsCount(string input)
        {
            int count = 0;
            input = input.ToLower();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a' || input[i] == 'o' || input[i] == 'i' || input[i] == 'y' || input[i] == 'e' || input[i] == 'u')
                {
                    count++;
                }
            }

            return count;
        }
    }
}
