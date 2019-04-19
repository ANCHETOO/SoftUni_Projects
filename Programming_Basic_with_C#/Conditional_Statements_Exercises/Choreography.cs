using System;

namespace Choreography
{
    class Program
    {
        static void Main(string[] args)
        {
            int stepsCount = int.Parse(Console.ReadLine());
            int dancersCount = int.Parse(Console.ReadLine());
            int daysCount = int.Parse(Console.ReadLine());

            double stepsperDay = (stepsCount / daysCount * 1.0) / stepsCount * 100.0;
            double stepsperDancer;

            if (stepsperDay <= 13)
            {
                stepsperDay = Math.Ceiling(stepsperDay);
                stepsperDancer = stepsperDay / dancersCount * 1.0;

                Console.WriteLine($"Yes, they will succeed in that goal! {stepsperDancer:f2}%.");
            }
            else
            {
                stepsperDay = Math.Ceiling(stepsperDay);
                stepsperDancer = stepsperDay / dancersCount * 1.0;

                Console.WriteLine($"No, They will not succeed in that goal! Required {stepsperDancer:f2}% steps to be learned per day.");
            }
        }
    }
}
