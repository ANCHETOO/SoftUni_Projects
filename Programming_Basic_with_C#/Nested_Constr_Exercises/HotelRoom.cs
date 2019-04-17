using System;

namespace Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            double priceAp = 0.0;
            double priceSt = 0.0;

            switch (month)
            {
                case "May":
                case "October":
                    {
                        priceSt = 50;
                        priceAp = 65;

                        priceSt *= count;
                        priceAp *= count;

                        if (count > 7 && count <= 14)
                        {
                            priceSt -= 0.05 * priceSt;
                        }
                        else if (count > 14)
                        {
                            priceSt -= 0.30 * priceSt;
                        }

                        break;
                    }
                case "June":
                case "September":
                    {
                        priceSt = 75.20;
                        priceAp = 68.70;

                        priceSt *= count;
                        priceAp *= count;

                        if (count > 14)
                        {
                            priceSt -= 0.20 * priceSt;
                        }

                        break;
                    }
                case "July":
                case "August":
                    {
                        priceSt = 76;
                        priceAp = 77;

                        priceSt *= count;
                        priceAp *= count;

                        break;
                    }

                default:
                    return;
            }

            if (count > 14)
            {
                priceAp -= 0.10 * priceAp;
            }

            Console.WriteLine($"Apartment: {priceAp:f2} lv.");
            Console.WriteLine($"Studio: {priceSt:f2} lv.");
        }
    }
}
