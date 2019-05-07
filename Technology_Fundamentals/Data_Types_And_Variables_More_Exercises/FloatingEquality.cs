using System;

namespace Floating_Equality
{
    class FloatingEquality
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double precision = 0.000001;

            if (Math.Abs(a - b) < precision)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
