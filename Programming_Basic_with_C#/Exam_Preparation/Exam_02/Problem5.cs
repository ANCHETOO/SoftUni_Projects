using System;

namespace Problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());
            double totalElectricity = 0;
            double totalOther = 0;

            for (int i = 1; i <= months; i++)
            {
                double electricity = double.Parse(Console.ReadLine());
                totalElectricity += electricity;

                double otherCur = electricity + 20 + 15;
                otherCur += 0.20 * otherCur;
                totalOther += otherCur;
            }

            double totalWater = months * 20;
            double totalInternet = months * 15;
            double average = (totalElectricity + totalWater + totalInternet + totalOther) / (months * 1.0);

            Console.WriteLine($"Electricity: {totalElectricity:f2} lv");
            Console.WriteLine($"Water: {totalWater:f2} lv");
            Console.WriteLine($"Internet: {totalInternet:f2} lv");
            Console.WriteLine($"Other: {totalOther:f2} lv");
            Console.WriteLine($"Average: {average:f2} lv");
        }
    }
}
