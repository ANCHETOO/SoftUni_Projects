using System;

namespace FoldAndSum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int index = input.Length / 4;
            var numberA = new int[2 * index];
            int counter = index;

            for (int i = 0; i < 2 * index; i++)
            {
                numberA[i] = int.Parse(input[counter]);
                counter++;
            }

            var numberB = new int[2 * index];
            counter = index - 1;

            for (int j = 0; j < index; j++)
            {
                numberB[j] = int.Parse(input[counter]);
                counter--;
            }

            counter = 4 * index - 1;

            for (int k = index; k < 2 * index; k++)
            {
                numberB[k] = int.Parse(input[counter]);
                counter--;
            }

            var numberC = new int[2 * index];

            for (int i = 0; i < 2 * index; i++)
            {
                numberC[i] = numberA[i] + numberB[i];
            }

            Console.WriteLine(string.Join(' ', numberC));
        }
    }
}
