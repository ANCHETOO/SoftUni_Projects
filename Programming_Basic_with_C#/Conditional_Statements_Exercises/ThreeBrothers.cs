using System;

namespace Three_Brothers
{
    class Program
    {
        static void Main(string[] args)
        {
            double timeA = double.Parse(Console.ReadLine());
            double timeB = double.Parse(Console.ReadLine());
            double timeC = double.Parse(Console.ReadLine());
            double timeD = double.Parse(Console.ReadLine());

            double timeNeeded = 1.0 / (1.0 / timeA + 1.0 / timeB + 1.0 / timeC);
            timeNeeded += 0.15 * timeNeeded;

            if (timeNeeded >= timeD)
            {
                Console.WriteLine($"Cleaning time: {timeNeeded:f2}");
                Console.WriteLine($"No, there isn't a surprise - shortage of time -> {Math.Ceiling(timeNeeded - timeD)} hours.");
            }
            else
            {
                Console.WriteLine($"Cleaning time: {timeNeeded:f2}");
                Console.WriteLine($"Yes, there is a surprise - time left -> {Math.Floor(-timeNeeded + timeD)} hours.");
            }
        }
    }
}
