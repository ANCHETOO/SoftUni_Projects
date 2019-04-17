using System;

namespace Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int points = new int();

            char[] vowel = word.ToCharArray();

            foreach (var letter in vowel)
            {
                switch (letter)
                {
                    case 'a':
                        points += 1;
                        break;
                    case 'e':
                        points += 2;
                        break;
                    case 'i':
                        points += 3;
                        break;
                    case 'o':
                        points += 4;
                        break;
                    case 'u':
                        points += 5;
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(points);
        }
    }
}
