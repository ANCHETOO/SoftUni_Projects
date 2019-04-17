using System;

namespace Hotel_Rooms
{
    class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine());

            if (floors == 1)
            {
                for (int i = 0; i <= count - 1; i++)
                {
                    Console.Write($"L{floors}{i} ");
                }

                Console.WriteLine();
            }
            else
            {
                for (int i = 0; i <= count - 1; i++)
                {
                    Console.Write($"L{floors}{i} ");
                }

                Console.WriteLine();

                for (int j = floors - 1; j >= 1; j--)
                {
                    if (j % 2 == 0)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            Console.Write($"O{j}{i} ");
                        }

                        Console.WriteLine();
                    }
                    else
                    {
                        for (int i = 0; i < count; i++)
                        {
                            Console.Write($"A{j}{i} ");
                        }

                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
