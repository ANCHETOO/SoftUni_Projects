using System;
using System.Collections.Generic;
using System.Linq;

namespace Cups_And_Bottles
{
    class Cups_And_Bottles
    {
        static void Main(string[] args)
        {
            int[] cups = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] bottles = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var cupsQueue = new Queue<int>(cups);
            var bottleStack = new Stack<int>(bottles);
            int wastedWater = 0;
            var currWaterAmount = cupsQueue.Peek();

            while (cupsQueue.Count > 0 && bottleStack.Count > 0)
            {
                var currBottle = bottleStack.Peek();

                if (currBottle >= currWaterAmount)
                {
                    wastedWater += currBottle - currWaterAmount;
                    cupsQueue.Dequeue();
                    bottleStack.Pop();

                    if (cupsQueue.Count > 0)
                    {
                        currWaterAmount = cupsQueue.Peek();
                    }
                    else
                    {
                        break;
                    }
                }
                else //urrBottle<currWaterAmount
                {
                    bottleStack.Pop();
                    currWaterAmount -= currBottle;
                }
            }

            if (cupsQueue.Count == 0)
            {
                if (bottleStack.Count > 0)
                {
                    Console.WriteLine($"Bottles: {string.Join(' ', bottleStack)}");
                }
            }
            else //cupsQueue.Count>0
            {
                Console.WriteLine($"Cups: {string.Join(' ', cupsQueue)}");
            }

            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}
