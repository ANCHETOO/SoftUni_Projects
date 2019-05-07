using System;
using System.Linq;

namespace Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < arr.Length - 1; i++)
            {
                bool isBigger = false;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        isBigger = true;
                    }
                    else
                    {
                        isBigger = false;
                        break;
                    }
                }

                if (isBigger == true)
                {
                    Console.Write($"{arr[i]} ");
                }
            }

            Console.Write(arr[arr.Length - 1]);
            Console.WriteLine();
        }
    }
}

