using System;

namespace Vacation
{
    class Vacation
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;

            switch (name)
            {
                case "Students":
                    {
                        if (day == "Friday")
                        {
                            price = 8.45;
                        }
                        else if (day == "Saturday")
                        {
                            price = 9.80;
                        }
                        else if (day == "Sunday")
                        {
                            price = 10.46;
                        }
                        else
                        {
                            Console.WriteLine("Invalid day!");
                            return;
                        }
                        break;
                    }
                case "Business":
                    {
                        if (day == "Friday")
                        {
                            price = 10.90;
                        }
                        else if (day == "Saturday")
                        {
                            price = 15.60;
                        }
                        else if (day == "Sunday")
                        {
                            price = 16;
                        }
                        else
                        {
                            Console.WriteLine("Invalid day!");
                            return;
                        }
                        break;
                    }
                case "Regular":
                    {
                        if (day == "Friday")
                        {
                            price = 15;
                        }
                        else if (day == "Saturday")
                        {
                            price = 20;
                        }
                        else if (day == "Sunday")
                        {
                            price = 22.50;
                        }
                        else
                        {
                            Console.WriteLine("Invalid day!");
                            return;
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid name!");
                        return;
                    }
            }

            double result = count * price;

            if (name == "Students"&&count>=30)
            {
                result *= 0.85;
            }

            if (name== "Business"&&count>=100)
            {
                result -= 10 * price;
            }

            if (name== "Regular"&&(count>=10&&count<=20))
            {
                result *= 0.95;
            }

            Console.WriteLine($"Total price: {result:f2}");
        }
    }
}
