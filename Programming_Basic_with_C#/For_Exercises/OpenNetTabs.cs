using System;

namespace OpenNetTabs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double selery = double.Parse(Console.ReadLine());

            while (selery > 0 && n > 0)
            {
                string name = Console.ReadLine();

                if (name == "Facebook")
                {
                    selery -= 150;
                }

                if (name == "Instagram")
                {
                    selery -= 100;
                }

                if (name == "Reddit")
                {
                    selery -= 50;
                }

                n--;
            }

            if (selery <= 0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine(selery);
            }
        }
    }
}
