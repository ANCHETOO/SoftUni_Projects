using System;

namespace Time_15mins
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes = minutes + hours * 60 + 15;
            hours = minutes / 60;

            if (hours > 23)
            {
                hours = 0;
            }

            minutes = minutes % 60;
            Console.WriteLine($"{hours}:{minutes:d2}");
        }
    }
}
