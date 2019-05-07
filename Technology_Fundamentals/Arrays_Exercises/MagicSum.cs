using System;
using System.Linq;

namespace Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sum = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int currElement = arr[i];

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (currElement + arr[j] == sum)
                    {
                        Console.WriteLine($"{currElement} {arr[j]}");
                    }
                }
            }
        }
    }
}
