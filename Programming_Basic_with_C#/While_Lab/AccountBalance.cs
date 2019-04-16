using System;

namespace Account_Balance
{
    class AcountBalance
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            double sum = 0.0;

            for (int i = 1; i <= count; i++)
            {
                double increase = double.Parse(Console.ReadLine());

                if (increase<0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                Console.WriteLine($"Increase: {increase:f2}");
                sum += increase;
            }

            Console.WriteLine($"Total: {sum:f2}");
        }
    }
}
