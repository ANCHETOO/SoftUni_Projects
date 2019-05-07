using System;

namespace PadawanEquipment
{
    class PadawanEquipment
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine());
            double lightPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            int freeBelts = count / 6;
            int extraLights = (int)Math.Ceiling((count * 1.1));
            double totalPrice = lightPrice * extraLights + robePrice * count + beltPrice * (count - freeBelts);

            if (totalPrice <= budget)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {(totalPrice - budget):f2}lv more.");
            }
        }
    }
}
