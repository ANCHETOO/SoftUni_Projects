using System;
using System.Linq;

namespace Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool isIndex = false;

            for (int i = 0; i < arr.Length; i++)
            {
                int sumLeft = 0;
                int sumRight = 0;

                for (int j = 0; j < i; j++)
                {
                    sumLeft += arr[j];
                }

                for (int k = i + 1; k < arr.Length; k++)
                {
                    sumRight += arr[k];
                }

                if (sumRight == sumLeft)
                {
                    Console.Write(i);
                    Console.Write(" ");
                    isIndex = true;
                }
            }

            if (isIndex == false)
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}
