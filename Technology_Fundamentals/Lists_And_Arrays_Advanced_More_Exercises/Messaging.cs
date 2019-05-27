using System;
using System.Linq;
using System.Collections.Generic;

namespace Messaging
{
    class Messaging
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            string name = Console.ReadLine();
            List<char> input = new List<char>();

            for (int i = 0; i < name.Length; i++)
            {
                input.Add(name[i]);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                int curr = numbers[i];
                numbers[i] = GetSum(curr);
            }

            List<char> result = new List<char>();

            for (int j = 0; j < numbers.Length; j++)
            {
                result.Add(GetChar(input, numbers[j]));
            }

            for (int k = 0; k < result.Count; k++)
            {
                Console.Write(result[k]);
            }

            Console.WriteLine();
        }

        static int GetSum(int number)
        {
            int sum = 0;
            int numDiv;
            int digid;

            while (number != 0)
            {
                digid = number % 10;
                numDiv = number / 10;
                number = numDiv;
                sum += digid;
            }

            return sum;
        }

        static char GetChar(List<char> input, int number)
        {
            char letter = ' ';

            if (number >= 0 && number < input.Count)
            {
                letter = input[number];
                input.RemoveAt(number);
            }
            else
            {
                int index = number % input.Count;
                letter = input[index];
                input.RemoveAt(index);
            }

            return letter;
        }
    }
}

