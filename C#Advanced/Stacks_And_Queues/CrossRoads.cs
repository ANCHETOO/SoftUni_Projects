using System;
using System.Collections.Generic;
using System.Linq;

namespace CrossRoads
{
    class CrossRoads
    {
        static void Main(string[] args)
        {
            int timeForGreen = int.Parse(Console.ReadLine());
            int delay = int.Parse(Console.ReadLine());
            string line = Console.ReadLine();
            var queque = new Queue<string>();
            int totalCarPassed = 0;

            while (line != "END")
            {
                if (line == "green")
                {
                    int leftTime = timeForGreen;

                    while (queque.Count > 0)
                    {
                        string currCar = queque.Peek();

                        if (currCar.Length > (leftTime + delay))
                        {
                            Console.WriteLine($"A crash happened!");
                            Console.WriteLine($"{currCar} was hit at {currCar[leftTime + delay]}.");
                            return;
                        }
                        else //if (currCar.Length < (leftTime + delay) && currCar.Length >= leftTime)
                        {
                            queque.Dequeue();
                            totalCarPassed++;

                            if (currCar.Length < leftTime)
                            {
                                leftTime -= currCar.Length;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
                else
                {
                    queque.Enqueue(line);
                }

                line = Console.ReadLine();
            }

            Console.WriteLine($"Everyone is safe.");
            Console.WriteLine($"{totalCarPassed} total cars passed the crossroads.");
        }
    }
}
