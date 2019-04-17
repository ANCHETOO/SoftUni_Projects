using System;

namespace New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double price = 0.0;

            switch (flower)
            {
                case "Roses":
                    {
                        price = 5;
                        price = price * count;

                        if (count > 80)
                        {
                            price -= 0.10 * price;
                        }

                        break;
                    }

                case "Dahlias":
                    {
                        price = 3.80;
                        price = price * count;

                        if (count > 90)
                        {
                            price -= 0.15 * price;
                        }

                        break;
                    }

                case "Tulips":
                    {
                        price = 2.80;
                        price = price * count;

                        if (count > 80)
                        {
                            price -= 0.15 * price;
                        }

                        break;
                    }

                case "Narcissus":
                    {
                        price = 3;
                        price = price * count;

                        if (count < 120)
                        {
                            price += 0.15 * price;
                        }

                        break;
                    }

                case "Gladiolus":
                    {
                        price = 2.5;
                        price = price * count;

                        if (count < 80)
                        {
                            price += 0.20 * price;
                        }

                        break;
                    }

                default:
                    break;
            }

            double result = 0.0;
            result = budget - price;

            if (result >= 0)
            {
                Console.WriteLine($"Hey, you have a great garden with {count} {flower} and {result:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {-result:f2} leva more.");
            }
        }
    }
}
