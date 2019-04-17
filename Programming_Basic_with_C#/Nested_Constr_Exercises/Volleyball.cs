using System;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string yearType = Console.ReadLine(); // leap or normal
            int freeDays = int.Parse(Console.ReadLine());
            int travelWeekends = int.Parse(Console.ReadLine());
            double constYear = 0.0;
            double result;

            result = 3 / 4.0 * (48 - travelWeekends);
            result += travelWeekends;
            result += freeDays * 2 / 3.0;

            if (yearType == "leap")
            {
                constYear = 0.15;
                result += constYear * result;
            }

            Console.WriteLine($"{Math.Floor(result)}");
        }
    }
}
