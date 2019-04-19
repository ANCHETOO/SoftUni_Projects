using System;

namespace Excellent_Result
{
    class Program
    {
        static void Main(string[] args)
        {
            double mark = double.Parse(Console.ReadLine());

            if (mark >= 5.50 && mark <= 6)
            {
                Console.WriteLine("Excellent!");
            }
            else
            {
                return;
            }
        }
    }
}
