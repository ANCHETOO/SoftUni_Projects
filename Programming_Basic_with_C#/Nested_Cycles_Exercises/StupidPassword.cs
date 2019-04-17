using System;

namespace Stupid_Passwords
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            char password = (char)((int)('a') + l-1);

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    for (char k='a'; k <= password; k++)
                    {
                        for (char m = 'a'; m <= password; m++)
                        {
                            for (int p = 1; p <= n; p++)
                            {
                                if (p>i&&p>j)
                                {
                                    Console.Write($"{i}{j}{k}{m}{p} ");
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine();
        }
    }
}
