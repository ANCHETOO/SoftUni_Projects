using System;
using System.Collections.Generic;
using System.Linq;

namespace Fashion_Boutique
{
    class Fashion_Boutique
    {
        static void Main(string[] args)
        {
            int[] line = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int capacity = int.Parse(Console.ReadLine());
            int countRacks = 1;
            var stack = new Stack<int>(line);
            int currCapacity = capacity;

            while (stack.Count > 0)
            {
                int currElement = stack.Peek();

                if ((currCapacity - currElement) >= 0)
                {
                    stack.Pop();
                    currCapacity -= currElement;
                }
                else
                {
                    currCapacity = capacity;
                    countRacks++;
                    stack.Pop();
                    currCapacity -= currElement;
                }
            }

            Console.WriteLine(countRacks);
        }
    }
}
