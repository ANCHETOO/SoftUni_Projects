using System;

namespace PassedOrFail
{
    class PassedOrFailed
    {
        static void Main(string[] args)
        {
            double mark = double.Parse(Console.ReadLine());

            if (mark >= 3)
            {
                Console.WriteLine($"Passed!");
            }
            else
            {
                Console.WriteLine($"Failed!");
            }
        }
    }
}
