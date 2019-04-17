using System;

namespace Travel
{
    class Program
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();
            double savedSum = 0;

            while (comand != "End")
            {
                double budjet = double.Parse(Console.ReadLine());

                while (savedSum < budjet)
                {
                    double current = double.Parse(Console.ReadLine());
                    savedSum += current;
                }

                Console.WriteLine($"Going to {comand}!");
                savedSum = 0;
                comand = Console.ReadLine();
            }

            return;
        }
    }
}
