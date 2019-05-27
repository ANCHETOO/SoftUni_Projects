using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_Stack_Operations
{
    class Basic_Stack_Operations
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();
            int count = input[0];
            int countElementsToPop = input[1];
            int elementToSearch = input[2];
            int[] elements = Console.ReadLine()
                            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();
            var stack = new Stack<int>(elements);

            for (int i = 0; i < countElementsToPop; i++)
            {
                stack.Pop();
            }

            bool result = stack.Contains(elementToSearch);

            if (result == true)
            {
                Console.WriteLine($"true");
            }
            else
            {
                if (stack.Count > 0)
                {
                    int minElement = stack.Min();
                    Console.WriteLine(minElement);
                }
                else
                {
                    Console.WriteLine($"0");
                }
            }
        }
    }
}
