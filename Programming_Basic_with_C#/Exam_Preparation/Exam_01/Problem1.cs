using System;

namespace Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string teamName = Console.ReadLine();
            string input = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            double price = 0;

            switch (teamName)
            {
                case "Argentina":
                    {
                        switch (input)
                        {
                            case "flags":
                                {
                                    price = 3.25;
                                    break;
                                }
                            case "caps":
                                {
                                    price = 7.20;
                                    break;
                                }
                            case "posters":
                                {
                                    price = 5.10;
                                    break;
                                }
                            case "stickers":
                                {
                                    price = 1.25;
                                    break;
                                }
                            default:
                                Console.WriteLine("Invalid stock!");
                                return;
                        }
                        break;
                    }
                case "Brazil":
                    {
                        switch (input)
                        {
                            case "flags":
                                {
                                    price = 4.20;
                                    break;
                                }
                            case "caps":
                                {
                                    price = 8.50;
                                    break;
                                }
                            case "posters":
                                {
                                    price = 5.35;
                                    break;
                                }
                            case "stickers":
                                {
                                    price = 1.20;
                                    break;
                                }
                            default:
                                Console.WriteLine("Invalid stock!");
                                return;
                        }
                        break;
                    }
                case "Croatia":
                    {
                        switch (input)
                        {
                            case "flags":
                                {
                                    price = 2.75;
                                    break;
                                }
                            case "caps":
                                {
                                    price = 6.90;
                                    break;
                                }
                            case "posters":
                                {
                                    price = 4.95;
                                    break;
                                }
                            case "stickers":
                                {
                                    price = 1.10;
                                    break;
                                }
                            default:
                                Console.WriteLine("Invalid stock!");
                                return;
                        }
                        break;
                    }
                case "Denmark":
                    {
                        switch (input)
                        {
                            case "flags":
                                {
                                    price = 3.10;
                                    break;
                                }
                            case "caps":
                                {
                                    price = 6.50;
                                    break;
                                }
                            case "posters":
                                {
                                    price = 4.80;
                                    break;
                                }
                            case "stickers":
                                {
                                    price = 0.90;
                                    break;
                                }
                            default:
                                Console.WriteLine("Invalid stock!");
                                return;
                        }
                        break;
                    }
                default:
                    Console.WriteLine("Invalid country!");
                    return;
            }

            double totalPrice = price * count;
            Console.WriteLine($"Pepi bought {count} {input} of {teamName} for {totalPrice:f2} lv.");
        }
    }
}
