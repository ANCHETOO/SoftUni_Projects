using System;

namespace Train
{
    class Train
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] train = new int[n];
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                train[i] = int.Parse(Console.ReadLine());
                sum += train[i];
            }

            Console.Write(string.Join(' ', train));
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
