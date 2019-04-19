using System;

namespace Speed_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal speed = decimal.Parse(Console.ReadLine());

            if (speed <= 10m)
            {
                Console.WriteLine("slow");
            }
            else if (speed > 10m && speed <= 50m)
            {
                Console.WriteLine("average");
            }
            else if (speed > 50 && speed <= 150)
            {
                Console.WriteLine("fast");
            }
            else if (speed > 150 && speed <= 1_000)
            {
                Console.WriteLine("ultra fast");
            }
            else if (speed > 1_000)
            {
                Console.WriteLine("extremely fast");
            }
        }
    }
}
