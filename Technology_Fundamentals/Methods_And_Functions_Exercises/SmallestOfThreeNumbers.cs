using System;

namespace SmallestOfThreeNumbers
{
    class SmallestOfThreeNumbers
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMin(a, b, c));
        }

        public static int GetMin(int a, int b, int c)
        {
            int result = int.MaxValue;

            if (result > a)
            {
                result = a;
            }

            if (result > b)
            {
                result = b;
            }

            if (result > c)
            {
                result = c;
            }

            return result;
        }
    }
}
