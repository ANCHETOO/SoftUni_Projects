using System;

namespace NOD
{
    class Nod
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            while (a % b != 0)
            {
                int change = a;
                a = b;
                b = change % b;
            }

            Console.WriteLine(b);
        }
    }
}
