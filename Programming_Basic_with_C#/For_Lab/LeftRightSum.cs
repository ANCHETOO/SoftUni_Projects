using System;

namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int leftSum = new int();
            int rightsum = new int();

            for (int i = 1; i <= count; i++)
            {
                int number = int.Parse(Console.ReadLine());
                leftSum += number;
            }

            for (int i = 1; i <= count; i++)
            {
                int number = int.Parse(Console.ReadLine());
                rightsum += number;
            }

            if (leftSum == rightsum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightsum)}");
            }
        }
    }
}
