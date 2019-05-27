using System;
using System.Collections.Generic;
using System.Linq;

namespace Fast_Food
{
    class Fast_Food
    {
        static void Main(string[] args)
        {
            int totalQuantity = int.Parse(Console.ReadLine());
            int[] line = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var queue = new Queue<int>(line);

            while (queue.Count > 0)
            {
                int currOrder = queue.Peek();

                if ((totalQuantity - currOrder) >= 0)
                {
                    totalQuantity -= currOrder;
                    queue.Dequeue();
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(line.Max());

            if (queue.Count == 0)
            {
                Console.WriteLine($"Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
            }
        }
    }
}
