using System;

namespace Passed
{
    class Passed
    {
        static void Main(string[] args)
        {
            double mark = double.Parse(Console.ReadLine());

            if (mark >= 3)
            {
                Console.WriteLine($"Passed!");
            }
        }
    }
}
