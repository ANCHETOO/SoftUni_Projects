using System;
using System.Collections.Generic;
using System.Linq;

namespace LongestIncreasingSubsequence
{
    class LongestIncreasingSubsequence
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = input.Length;
            var arr = new int[n][];
            int maxLenght = 0;

            for (int i = 0; i < n; i++)
            {
                arr[i] = new int[2];
                arr[i][0] = input[i];
                arr[i][1] = 1;
            }

            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[i][0] > arr[j][0])
                    {
                        if (arr[i][1] <= arr[j][1])
                        {
                            arr[i][1]++;
                            if (maxLenght < arr[i][1])
                            {
                                maxLenght = arr[i][1];
                            }
                        }
                    }
                }
            }

            int element = int.MaxValue;
            var result = new List<int>();

            for (int i = maxLenght; i >= 1; i--)
            {
                for (int j = 0; j < n; j++)
                {
                    if (arr[j][1] == i)
                    {
                        if (arr[j][0] < element)
                        {
                            element = arr[j][0];
                            result.Add(arr[j][0]);
                            break;
                        }
                    }
                }
            }

            result.Reverse();
            Console.WriteLine(string.Join(' ', result));
        }
    }
}
