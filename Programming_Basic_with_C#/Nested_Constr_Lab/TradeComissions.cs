using System;

namespace Trade_Comissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double s = double.Parse(Console.ReadLine()); // s - comission

            switch (town)
            {
                case "Sofia":
                    {
                        if (s >= 0 && s <= 500)
                        {
                            s *= 5 / 100.0;
                        }
                        else if (s > 500 && s <= 1_000)
                        {
                            s *= 7 / 100.0;
                        }
                        else if (s > 1_000 && s <= 10_000)
                        {
                            s *= 8 / 100.0;
                        }
                        else if (s > 10_000)
                        {
                            s *= 12 / 100.0;
                        }
                        else
                        {
                            Console.WriteLine("error");
                            return;
                        }
                        break;
                    }

                case "Varna":
                    {
                        if (s >= 0 && s <= 500)
                        {
                            s *= 4.5 / 100.0;
                        }
                        else if (s > 500 && s <= 1_000)
                        {
                            s *= 7.5 / 100.0;
                        }
                        else if (s > 1_000 && s <= 10_000)
                        {
                            s *= 10 / 100.0;
                        }
                        else if (s > 10_000)
                        {
                            s *= 13 / 100.0;
                        }
                        else
                        {
                            Console.WriteLine("error");
                            return;
                        }
                        break;
                    }

                case "Plovdiv":
                    {
                        if (s >= 0 && s <= 500)
                        {
                            s *= 5.5 / 100.0;
                        }
                        else if (s > 500 && s <= 1_000)
                        {
                            s *= 8 / 100.0;
                        }
                        else if (s > 1_000 && s <= 10_000)
                        {
                            s *= 12 / 100.0;
                        }
                        else if (s > 10_000)
                        {
                            s *= 14.5 / 100.0;
                        }
                        else
                        {
                            Console.WriteLine("error");
                            return;
                        }
                        break;
                    }

                default:
                    Console.WriteLine("error");
                    return;
            }

            Console.WriteLine($"{s:f2}");
        }
    }
}
