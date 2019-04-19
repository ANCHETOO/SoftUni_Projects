using System;

namespace Equal_Numbers3
{
    class Program
    {
        static void Main(string[] args)
        {
            double numFirst = double.Parse(Console.ReadLine());
            double numSecond = double.Parse(Console.ReadLine());
            double numThird = double.Parse(Console.ReadLine());

            if (numFirst == numSecond && numSecond == numThird)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
