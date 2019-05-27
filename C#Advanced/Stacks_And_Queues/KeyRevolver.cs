using System;
using System.Collections.Generic;
using System.Linq;

namespace KeyRevolver
{
    class KeyRevolver
    {
        static void Main(string[] args)
        {
            int bulletCost = int.Parse(Console.ReadLine());
            int capacityBarrel = int.Parse(Console.ReadLine());
            int[] bullets = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] locks = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int intelegence = int.Parse(Console.ReadLine());
            var bulletStack = new Stack<int>(bullets);
            var locksQueue = new Queue<int>(locks);
            int totalBullets = bulletStack.Count;
            int currCapacityBarel = capacityBarrel;

            while (bulletStack.Count > 0)
            {
                var currBullet = bulletStack.Peek();
                var currLock = locksQueue.Peek();

                bulletStack.Pop();
                currCapacityBarel--;

                if (currBullet > currLock)
                {
                    Console.WriteLine($"Ping!");

                    if (currCapacityBarel == 0 && bulletStack.Count > 0)
                    {
                        Console.WriteLine($"Reloading!");
                        currCapacityBarel = capacityBarrel;
                    }
                }
                else
                {
                    Console.WriteLine($"Bang!");

                    if (currCapacityBarel == 0 && bulletStack.Count > 0)
                    {
                        Console.WriteLine($"Reloading!");
                        currCapacityBarel = capacityBarrel;
                    }

                    locksQueue.Dequeue();

                    if (locksQueue.Count == 0)
                    {
                        Console.WriteLine($"{bulletStack.Count} bullets left. Earned ${intelegence - bulletCost * (totalBullets - bulletStack.Count)}");
                        return;
                    }
                }


            }

            Console.WriteLine($"Couldn't get through. Locks left: {locksQueue.Count}");
        }
    }
}
