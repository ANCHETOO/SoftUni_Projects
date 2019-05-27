using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Truck_Tour
{
    class TruckTour
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var queue = new Queue<Pump>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ').Select(x => BigInteger.Parse(x)).ToArray();

                var pump = new Pump
                {
                    Fuel = input[0],

                    Distance = input[1],

                    Index = i
                };

                queue.Enqueue(pump);
            }

            int counter = 0;

            while (counter != n)
            {
                BigInteger fuel = 0;

                counter = 0;

                for (int j = 0; j < n; j++)
                {
                    var currPump = queue.Dequeue();

                    queue.Enqueue(currPump);

                    fuel += currPump.Fuel;

                    if (fuel >= currPump.Distance)
                    {
                        counter++;

                        fuel -= currPump.Distance;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            Console.WriteLine(queue.Peek().Index);
        }
    }
    class Pump
    {
        public BigInteger Fuel { get; set; }

        public BigInteger Distance { get; set; }

        public int Index { get; set; }
    }

}
