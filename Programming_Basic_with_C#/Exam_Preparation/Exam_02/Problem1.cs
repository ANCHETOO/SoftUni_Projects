using System;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            double partyPrice = double.Parse(Console.ReadLine());
            int loveMesseges = int.Parse(Console.ReadLine());
            int waxRose = int.Parse(Console.ReadLine());
            int keyHolder = int.Parse(Console.ReadLine());
            int picture = int.Parse(Console.ReadLine());
            int surprice = int.Parse(Console.ReadLine());

            double totalPrice = loveMesseges * 0.60 + waxRose * 7.20 + keyHolder * 3.60 + picture * 18.2 + surprice * 22.0;

            if ((loveMesseges + waxRose + keyHolder + picture + surprice) >= 25)
            {
                totalPrice -= 0.35 * totalPrice;
            }

            totalPrice -= totalPrice * 0.10;

            if (totalPrice >= partyPrice)
            {
                Console.WriteLine($"Yes! {(totalPrice - partyPrice):f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {(partyPrice - totalPrice):f2} lv needed.");
            }
        }
    }
}
