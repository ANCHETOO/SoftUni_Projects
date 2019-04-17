using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int[] numbers = new int[count];
            int sum = new int();
            int counter = 0;
            int maxNumber = int.MinValue;

            for (int i = 0; i < count; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < count; i++)
            {
                sum += numbers[i];
            }

            for (int i = 0; i < count; i++)
            {
                if (numbers[i] >= maxNumber)
                {
                    maxNumber = numbers[i];
                }

                if (numbers[i] == (sum - numbers[i]))
                {
                    Console.WriteLine("Yes");
                    Console.WriteLine($"Sum = {numbers[i]}");
                    counter++;
                }
            }

            if (counter == 0)
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sum - maxNumber - maxNumber)}");
            }
        }
    }
}
