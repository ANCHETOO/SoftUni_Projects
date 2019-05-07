using System;

namespace Print_And_Sum
{
    class PrintAndSum
    {
        static void Main(string[] args)
        {
            int numFirst = int.Parse(Console.ReadLine());
            int numSecond = int.Parse(Console.ReadLine());
            int sum = 0;

            if (numFirst > numSecond)
            {
                int temp = numFirst;
                numFirst = numFirst + numSecond;
                numSecond = numFirst - numSecond;
                numFirst = numFirst - temp;
            }

            for (int i = numFirst; i <= numSecond; i++)
            {
                Console.Write(i + " ");
                sum += i;
            }

            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
