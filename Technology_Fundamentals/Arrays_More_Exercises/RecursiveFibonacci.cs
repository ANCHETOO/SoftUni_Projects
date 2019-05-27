using System;

namespace RecursiveFibonacci
{
    class RecursiveFibonacci
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"{Fibonacci(n)}");
        }

        static int Fibonacci(int num)
        {
            int result = 0;

            if (num == 1)
            {
                result = 1;
            }
            else if (num == 2)
            {
                result = 1;
            }
            else
            {
                result = Fibonacci(num - 1) + Fibonacci(num - 2);
            }

            return result;
        }
    }
}
