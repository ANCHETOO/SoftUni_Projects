using System;
using System.Collections.Generic;
using System.Linq;

namespace Auto_Repair_And_Service
{
    class Auto_Repair_And_Service
    {
        static void Main(string[] args)
        {
            string[] cars = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string comand = Console.ReadLine();
            var queue = new Queue<string>(cars);
            var stackServed = new Stack<string>();

            while (comand != "End")
            {
                if (comand == "Service")
                {
                    if (queue.Count > 0)
                    {
                        string curr = queue.Peek();
                        stackServed.Push(curr);
                        queue.Dequeue();
                        Console.WriteLine($"Vehicle {curr} got served.");
                    }
                }
                else if (comand == "History")
                {
                    if (stackServed.Count > 0)
                    {
                        Console.WriteLine(string.Join(", ", stackServed));
                    }
                }
                else // comand==carinfo
                {
                    string[] line = comand.Split("-", StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string carInfo = line[1];

                    if (queue.Contains(carInfo))
                    {
                        Console.WriteLine($"Still waiting for service.");
                    }
                    else if (stackServed.Contains(carInfo))
                    {
                        Console.WriteLine($"Served.");
                    }
                }

                comand = Console.ReadLine();
            }

            if (queue.Count > 0)
            {
                Console.WriteLine($"Vehicles for service: {string.Join(", ", queue)}");
            }

            if (stackServed.Count > 0)
            {
                Console.WriteLine($"Served vehicles: {string.Join(", ", stackServed)}");
            }
        }
    }
}
