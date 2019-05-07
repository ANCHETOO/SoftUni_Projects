using System;

namespace Poke_Mon
{
    class PokeMon
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int N = n;

            int couter = 0;

            while (n >= m)
            {
                n -= m;
                couter++;

                if ((N % 2 == 0) && (n == N / 2))
                {
                    if (y != 0)
                    {
                        n = n / y;
                    }
                }
            }

            Console.WriteLine(n);
            Console.WriteLine(couter);
        }
    }
}
