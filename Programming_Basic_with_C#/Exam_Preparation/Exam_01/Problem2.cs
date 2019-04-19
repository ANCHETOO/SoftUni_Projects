using System;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            double totalMoney = 0;
            double charityMoney = 0;

            totalMoney = capacity * price;
            charityMoney = (totalMoney - (totalMoney / (count * 1.0) * 0.75)) / 8.0;

            Console.WriteLine($"Total income - { totalMoney:f2} BGN");
            Console.WriteLine($"Money for charity - { charityMoney:f2} BGN");
        }
    }
}
