using System;

namespace CharactersInRange1
{
    class CharactersInRange
    {
        static void Main(string[] args)
        {
            char fisrt = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());

            PrintSequenceChars(fisrt, second);
        }

        static void PrintSequenceChars(char first, char second)
        {
            if (first > second)
            {
                char swap = first;
                first = second;
                second = swap;
            }

            for (char i = (char)(first + 1); i < second; i++)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
        }
    }
}
