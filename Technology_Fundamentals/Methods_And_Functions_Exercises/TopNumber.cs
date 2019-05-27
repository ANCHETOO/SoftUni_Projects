using System;

namespace TopNumber
{
    class TopNumber
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (IsMagic(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static int GetSum(int i)
        {
            int sum = 0;

            while (i != 0)
            {
                int digid = i % 10;
                sum += digid;
                i = i / 10;
            }

            return sum;
        }

        public static bool IsMagic(int i)
        {
            if ((GetSum(i) % 8 == 0) && (ContainsOddDigid(i) == true))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ContainsOddDigid(int i)
        {
            while (i != 0)
            {
                int digid = i % 10;
                if (!(digid % 2 == 0))
                {
                    return true;
                }

                i = i / 10;
            }

            return false;
        }
    }
}
