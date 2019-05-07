using System;

namespace GamingStore
{
    class GamingStore
    {
        static void Main(string[] args)
        {
            decimal budjet = decimal.Parse(Console.ReadLine());
            decimal money = budjet;
            string comand = Console.ReadLine();

            while (comand != "Game Time")
            {
                string game = comand;
                decimal price = 0;

                switch (game)
                {
                    case "OutFall 4":
                        {
                            price = 39.99m;
                            break;
                        }
                    case "CS: OG":
                        {
                            price = 15.99m;
                            break;
                        }
                    case "Zplinter Zell":
                        {
                            price = 19.99m;
                            break;
                        }
                    case "Honored 2":
                        {
                            price = 59.99m;
                            break;
                        }
                    case "RoverWatch":
                        {
                            price = 29.99m;
                            break;
                        }
                    case "RoverWatch Origins Edition":
                        {
                            price = 39.99m;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine($"Not Found");
                            break;
                        }
                }

                if (price > budjet)
                {
                    Console.WriteLine($"Too Expensive");
                }
                else
                {
                    budjet -= price;
                    Console.WriteLine($"Bought {game}");
                }

                if (budjet == 0)
                {
                    Console.WriteLine($"Out of money!");
                    return;
                }

                comand = Console.ReadLine();
            }

            Console.WriteLine($"Total spent: ${(money - budjet):f2}. Remaining: ${budjet:f2}");
        }
    }
}
