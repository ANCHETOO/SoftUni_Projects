using System;

namespace BackIn30Minutes
{
    class BackIn30Minutes
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            minutes += hours * 60 + 30;
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
