using System;

namespace Sum_Odd_Numbers
{
    class SumOddNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            int sum = 0;
            int curr = 1;

            while (counter < n)
            {
                if (curr % 2 != 0)
                {
                    Console.WriteLine(curr);
                    counter++;
                    sum += curr;
                }

                curr++;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
