using System;
using System.Numerics;

namespace Spice_Must_Flow
{
    class SpiceMustFlow
    {
        static void Main(string[] args)
        {
            BigInteger yield = BigInteger.Parse(Console.ReadLine());
            int countDays = 0;
            BigInteger amount = 0;

            while (yield >= 100)
            {
                amount += yield;
                yield -= 10;
                amount -= 26;
                countDays++;
            }

            amount -= 26;

            if (amount < 0)
            {
                amount = 0;
            }

            Console.WriteLine(countDays);
            Console.WriteLine(amount);
        }
    }
}
