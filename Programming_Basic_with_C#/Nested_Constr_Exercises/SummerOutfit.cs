using System;

namespace Summer_Outfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp = int.Parse(Console.ReadLine());
            string dayTime = Console.ReadLine();
            string outfit = string.Empty;
            string shoes = string.Empty;

            if (temp >= 10 && temp <= 18)
            {
                switch (dayTime)
                {
                    case "Morning":
                        {
                            outfit = "Sweatshirt";
                            shoes = "Sneakers";
                            break;
                        }
                    case "Afternoon":
                        {
                            outfit = "Shirt";
                            shoes = "Moccasins";
                            break;
                        }
                    case "Evening":
                        {
                            outfit = "Shirt";
                            shoes = "Moccasins";
                            break;
                        }
                    default:
                        break;
                }
            }
            else if (temp > 18 && temp <= 24)
            {
                switch (dayTime)
                {
                    case "Morning":
                        {
                            outfit = "Shirt";
                            shoes = "Moccasins";
                            break;
                        }
                    case "Afternoon":
                        {
                            outfit = "T-Shirt";
                            shoes = "Sandals";
                            break;
                        }
                    case "Evening":
                        {
                            outfit = "Shirt";
                            shoes = "Moccasins";
                            break;
                        }
                    default:
                        break;
                }
            }
            else if (temp >= 25)
            {
                switch (dayTime)
                {
                    case "Morning":
                        {
                            outfit = "T-Shirt";
                            shoes = "Sandals";
                            break;
                        }
                    case "Afternoon":
                        {
                            outfit = "Swim Suit";
                            shoes = "Barefoot";
                            break;
                        }
                    case "Evening":
                        {
                            outfit = "Shirt";
                            shoes = "Moccasins";
                            break;
                        }
                    default:
                        break;
                }
            }

            Console.WriteLine($"It's {temp} degrees, get your {outfit} and {shoes}.");
        }
    }
}
