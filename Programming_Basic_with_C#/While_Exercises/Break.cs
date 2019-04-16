using System;

namespace Break
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal tourPrice = decimal.Parse(Console.ReadLine());
            decimal budget = decimal.Parse(Console.ReadLine());
            string comand = string.Empty;
            decimal money = 0;
            int counter = 0;
            int countSpend = 0;

            while (true)
            {
                comand = Console.ReadLine();

                if (comand=="spend")
                {
                    money = decimal.Parse(Console.ReadLine());
                    counter++;
                    countSpend++;
                    budget -= money;

                    if (budget<0)
                    {
                        budget = 0;
                    }

                    if (countSpend==5)
                    {
                        Console.WriteLine($"You can't save the money.");
                        Console.WriteLine(counter);
                        return;
                    }
                }
                else if (comand=="save")
                {
                    money = decimal.Parse(Console.ReadLine());
                    counter++;
                    countSpend = 0;
                    budget += money;

                    if (budget >= tourPrice)
                    {
                        Console.WriteLine($"You saved the money for {counter} days.");
                        return;
                    }
                }
            }
        }
    }
}
