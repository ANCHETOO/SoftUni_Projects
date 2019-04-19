using System;

namespace Multiplication_Table
{
    class MultiplicationTable
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"{n} X {i} = {n * i}");
            }
        }
    }
}