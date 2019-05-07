using System;

namespace Vending_Machine
{
    class VendingMachine
    {
        static void Main(string[] args)
        {
            decimal money = 0;
            string comand = Console.ReadLine();

            while (comand != "Start")
            {
                decimal coin = 0;
                bool isCoin = decimal.TryParse(comand, out coin);

                if (isCoin)
                {
                    if (coin == 0.1m || coin == 0.2m || coin == 0.5m || coin == 1m || coin == 2m)
                    {
                        money += coin;
                    }
                    else
                    {
                        Console.WriteLine($"Cannot accept {coin}");
                    }
                }
                else
                {
                    Console.WriteLine($"Cannot accept {comand}");
                }

                comand = Console.ReadLine();
            }

            comand = Console.ReadLine();

            while (comand != "End")
            {
                string product = comand;
                decimal price = 0;

                switch (product)
                {
                    case "Nuts":
                        {
                            price = 2m;
                            break;
                        }
                    case "Water":
                        {
                            price = 0.7m;
                            break;
                        }
                    case "Crisps":
                        {
                            price = 1.5m;
                            break;
                        }
                    case "Soda":
                        {
                            price = 0.8m;
                            break;
                        }
                    case "Coke":
                        {
                            price = 1m;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid product");
                            break;
                        }
                }

                if (price != 0)
                {
                    if (money >= price)
                    {
                        Console.WriteLine($"Purchased {product.ToLower()}");
                        money -= price;
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, not enough money");
                    }
                }

                comand = Console.ReadLine();
            }

            Console.WriteLine($"Change: {money:f2}");
        }
    }
}
