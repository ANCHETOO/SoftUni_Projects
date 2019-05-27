using System;

namespace TribonacciSequence
{
    class TribonacciSequence
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write(GetTribonacci(i) + " ");
            }

            Console.WriteLine();
        }

        public static int GetTribonacci(int i)
        {
            if (i == 1)
            {
                return 1;
            }
            else if (i == 2)
            {
                return 1;
            }
            else if (i == 3)
            {
                return 2;
            }
            else
            {
                int counter = 3;
                int element = 0;
                int first = 1;
                int second = 1;
                int third = 2;

                while (counter != i)
                {
                    element = first + second + third;
                    first = second;
                    second = third;
                    third = element;
                    counter++;
                }

                return element;
            }
        }
    }
}
