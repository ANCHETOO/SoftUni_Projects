using System;

namespace Rage_Expenses
{
    class RageExpenses
    {
        static void Main(string[] args)
        {
            int games = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            double sum = 0;

            sum = ((int)(games / 2)) * headsetPrice + ((int)(games / 3)) * mousePrice + ((int)(games / 6)) * keyboardPrice + ((int)(games / 12)) * displayPrice;

            Console.WriteLine($"Rage expenses: {sum:f2} lv.");
        }
    }
}
