using System;

namespace Problem6
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine());
            int totalPrice = 0;

            for (int i = 1; i <= count; i++)
            {
                string input = Console.ReadLine();
                int price = 0;

                switch (input)
                {
                    case "hoodie":
                        {
                            price = 30;
                            break;
                        }
                    case "keychain":
                        {
                            price = 4;
                            break;
                        }
                    case "T-shirt":
                        {
                            price = 20;
                            break;
                        }
                    case "flag":
                        {
                            price = 15;
                            break;
                        }
                    case "sticker":
                        {
                            price = 1;
                            break;
                        }

                    default:
                        break;
                }

                totalPrice += price;
            }

            if (budget >= totalPrice)
            {
                Console.WriteLine($"You bought {count} items and left with {budget - totalPrice} lv.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {totalPrice - budget} more lv.");
            }
        }
    }
}
