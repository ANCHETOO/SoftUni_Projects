using System;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            double food = double.Parse(Console.ReadLine());
            double souvenirs = double.Parse(Console.ReadLine());
            double hotelPrice = double.Parse(Console.ReadLine());
            double totalMoney = 0;

            totalMoney = (420 / 100.0) * 7.0 * 1.85;
            totalMoney += 3 * (food + souvenirs);
            totalMoney += hotelPrice * 0.90;
            totalMoney += hotelPrice * 0.85;
            totalMoney += hotelPrice * 0.80;

            Console.WriteLine($"Money needed: {totalMoney:f2}");
        }
    }
}
