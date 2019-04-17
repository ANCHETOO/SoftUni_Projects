using System;

namespace Sum_Right_Left
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            for (int i = num1; i <= num2; i++)
            {
                int sumRight = i % 10 + ((i / 10) % 10);
                int sumLeft = ((i / 1000) % 10) + ((i / 10000) % 10);

                if (sumLeft == sumRight)
                {
                    Console.Write(i + " ");
                }
                else
                {
                    if (sumRight == sumLeft + ((i / 100) % 10))
                    {
                        Console.Write(i + " ");

                    }

                    if (sumLeft == sumRight + ((i / 100) % 10))
                    {
                        Console.Write(i + " ");
                    }
                }
            }

            Console.WriteLine();
        }
    }
}
