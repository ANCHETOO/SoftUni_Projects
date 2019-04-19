using System;

namespace Problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalPassangers = int.Parse(Console.ReadLine());
            int countBussStops = int.Parse(Console.ReadLine());

            for (int i = 1; i <= countBussStops; i++)
            {
                int countDown = int.Parse(Console.ReadLine());
                totalPassangers -= countDown;
                int countUpp = int.Parse(Console.ReadLine());
                totalPassangers += countUpp;
            }

            if (countBussStops % 2 == 0)
            {
                Console.WriteLine($"The final number of passengers is : {totalPassangers}");
            }
            else
            {
                Console.WriteLine($"The final number of passengers is : {totalPassangers + 2}");
            }
        }
    }
}
