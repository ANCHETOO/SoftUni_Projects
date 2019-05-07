using System;
using System.Linq;

namespace Arr_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int old = arr[0];

                for (int j = 0; j < arr.Length - 1; j++)
                {
                    arr[j] = arr[j + 1];
                }

                arr[arr.Length - 1] = old;
            }

            Console.WriteLine(string.Join(' ', arr));
        }
    }
}
