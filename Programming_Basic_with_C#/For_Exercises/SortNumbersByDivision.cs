using System;

namespace SortNumbersByDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter2 = 0;
            int counter3 = 0;
            int counter4 = 0;

            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number%2==0)
                {
                    counter2++;
                }

                if (number%3==0)
                {
                    counter3++;
                }

                if (number%4==0)
                {
                    counter4++;
                }
            }

            Console.WriteLine($"{((counter2*1.0/(n*1.0)*100.0)):f2}%");
            Console.WriteLine($"{((counter3 * 1.0 / (n * 1.0) * 100.0)):f2}%");
            Console.WriteLine($"{((counter4 * 1.0 / (n * 1.0) * 100.0)):f2}%");
        }
    }
}
