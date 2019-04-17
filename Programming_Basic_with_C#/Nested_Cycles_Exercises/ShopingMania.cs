using System;

namespace Shoping_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string comand = Console.ReadLine();
            int counter = 0;
            int moneySpend = 0;
            int moneyLeft = budget;

            while (comand != "enough")
            {
                if (comand == "enter")
                {
                    bool result = true;

                    while (result)
                    {
                        comand = Console.ReadLine();
                        result = int.TryParse(comand, out int currPrice);

                        if (result)
                        {
                            if (currPrice <= moneyLeft)
                            {
                                moneySpend += currPrice;
                                moneyLeft -= currPrice;
                                counter++;
                            }
                            else
                            {
                                Console.WriteLine("Not enough money.");
                            }

                            if (moneyLeft == 0)
                            {
                                break;
                            }
                        }
                    }
                }

                if (moneyLeft == 0)
                {
                    break;
                }

                comand = Console.ReadLine();
            }

            Console.WriteLine($"For {counter} clothes I spent {moneySpend} lv and have {moneyLeft} lv left.");
        }
    }
}
