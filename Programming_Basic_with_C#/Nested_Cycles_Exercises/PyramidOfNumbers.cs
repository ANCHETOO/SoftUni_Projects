using System;

namespace Pyramid_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 1;
            int number = 1;

            while (number <= n)
            {
                for (int i = 1; i <= count; i++)
                {
                    Console.Write(number + " ");
                    number += 1;

                    if (number == n + 1)
                    {
                        Console.WriteLine();
                        return;
                    }
                }

                Console.WriteLine();
                count += 1;
            }
        }
    }
}
