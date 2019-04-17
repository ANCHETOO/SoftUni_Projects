using System;

namespace Problem_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            if (a>b)
            {
                a = a + b;
                b = a - b;
                a = a - b;
            }

            if (c>d)
            {
                c = c + d;
                d = c - d;
                c = c - d;
            }

            for (int i = a; i <= b; i++)
            {
                for (int j = a; j <= b; j++)
                {
                    for (int k = c; k <= d; k++)
                    {
                        for (int l = c; l <=d ; l++)
                        {
                            if (i+l==j+k)
                            {
                                if (i!=j)
                                {
                                    if (k!=l)
                                    {
                                        Console.WriteLine($"{i}{j}");
                                        Console.WriteLine($"{k}{l}");                    
                                        Console.WriteLine();
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
