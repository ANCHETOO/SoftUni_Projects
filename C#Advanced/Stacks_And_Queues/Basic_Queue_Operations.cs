using System;
using System.Collections.Generic;
using System.Linq;


namespace Basic_Queue_Operations
{
    class Basic_Queue_Operations
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();
            int count = input[0];
            int countElementsToDequeue = input[1];
            int elementToSearch = input[2];
            int[] elements = Console.ReadLine()
                            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();
            var queue = new Queue<int>(elements);

            for (int i = 0; i < countElementsToDequeue; i++)
            {
                queue.Dequeue();
            }

            bool result = queue.Contains(elementToSearch);

            if (result == true)
            {
                Console.WriteLine($"true");
            }
            else
            {
                if (queue.Count > 0)
                {
                    int minElement = queue.Min();
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
