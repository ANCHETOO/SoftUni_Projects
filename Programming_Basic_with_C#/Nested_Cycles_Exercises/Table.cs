using System;

namespace Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= n; j++)
                {
                    Console.Write(j + " ");
                }

                for (int k = n - 1; k >= n - i + 1; k--)
                {
                    Console.Write(k + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
