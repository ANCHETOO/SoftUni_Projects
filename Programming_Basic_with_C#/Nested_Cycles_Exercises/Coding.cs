using System;

namespace Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int reminder = 0;
            int indexAscii = 0;

            while (number != 0)
            {
                reminder = number % 10;
                number = number / 10;

                if (reminder == 0)
                {
                    Console.WriteLine("ZERO");
                }
                else
                {
                    indexAscii = reminder + 33;

                    for (int i = 1; i <= reminder; i++)
                    {
                        Console.Write((char)(indexAscii));
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
