using System;

namespace World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = Double.Parse(Console.ReadLine());
            double distance = Double.Parse(Console.ReadLine());
            double speed = Double.Parse(Console.ReadLine());

            double time = distance * speed;
            double delay = Math.Truncate(distance / 15) * 12.5;
            time += delay;

            if (time < record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {time:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {(time - record):f2} seconds slower.");
            }
        }
    }
}
