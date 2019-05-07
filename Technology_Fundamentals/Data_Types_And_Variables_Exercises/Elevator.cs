using System;

namespace Elevator
{
    class Elevator
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int result = (int)Math.Ceiling(count / (capacity * 1.0));

            Console.WriteLine(result);
        }
    }
}
