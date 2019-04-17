using System;

namespace Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMashinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            double savedMoney = new double();
            int money = 10;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    savedMoney += money - 1;
                    money += 10;
                }
                else
                {
                    savedMoney += toyPrice;
                }
            }

            if (savedMoney >= washingMashinePrice)
            {
                Console.WriteLine($"Yes! {(savedMoney - washingMashinePrice):f2}");
            }
            else
            {
                Console.WriteLine($"No! {(washingMashinePrice - savedMoney):f2}");
            }
        }
    }
}
