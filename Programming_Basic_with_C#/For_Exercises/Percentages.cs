using System;

namespace Percentages
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //n[1..1000]
            int counterP1 = 0;
            int counterP2 = 0;
            int counterP3 = 0;
            int counterP4 = 0;
            int counterP5 = 0;

            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number < 200 && number >= 1)
                {
                    counterP1++;
                }
                else if (number >= 200 && number <= 399)
                {
                    counterP2++;
                }
                else if (number >= 400 && number <= 599)
                {
                    counterP3++;
                }
                else if (number >= 600 && number <= 799)
                {
                    counterP4++;
                }
                else if (number >= 800 && number <= 1000)
                {
                    counterP5++;
                }
            }

            Console.WriteLine($"{((counterP1 * 1.0) / (n * 1.0) * 100):f2}%");
            Console.WriteLine($"{((counterP2 * 1.0) / (n * 1.0) * 100):f2}%");
            Console.WriteLine($"{((counterP3 * 1.0) / (n * 1.0) * 100):f2}%");
            Console.WriteLine($"{((counterP4 * 1.0) / (n * 1.0) * 100):f2}%");
            Console.WriteLine($"{((counterP5 * 1.0) / (n * 1.0) * 100):f2}%");
        }
    }
}
