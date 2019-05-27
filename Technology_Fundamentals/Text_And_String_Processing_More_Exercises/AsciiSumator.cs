using System;

namespace AsciiSumator
{
    class AsciiSumator
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            if ((int)(second) < (int)(first))
            {
                char temp = first;
                first = second;
                second = temp;
            }

            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char curr = input[i];

                if (((int)(curr) < (int)(second)) && ((int)(curr) > (int)(first)))
                {
                    sum += (int)(curr);
                }
            }

            Console.WriteLine(sum);
        }
    }
}
