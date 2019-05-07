using System;

namespace Strong_Number
{
    class StrongNumber
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(input);
            int sum = 0;

            while (n > 0)
            {
                int digid = n % 10;
                n = n / 10;
                sum += Factoriel(digid);
            }

            if (sum == int.Parse(input))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }

        private static int Factoriel(int v)
        {
            int result = 1;

            if (v != 0)
            {
                for (int i = 1; i <= v; i++)
                {
                    result *= i;
                }
            }

            return result;
        }
    }
}
