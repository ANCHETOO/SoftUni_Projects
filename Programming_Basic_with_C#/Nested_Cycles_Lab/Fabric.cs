using System;

namespace Fabric
{
    class Fabric
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string comand = Console.ReadLine();
                bool isFlour = false;
                bool isSugar = false;
                bool isEggs = false;

                while (true)
                {
                    if (comand == "flour")
                    {
                        isFlour = true;
                    }

                    if (comand == "eggs")
                    {
                        isEggs = true;
                    }

                    if (comand == "sugar")
                    {
                        isSugar = true;
                    }

                    if (comand == "Bake!")
                    {
                        if (isSugar & isFlour & isEggs)
                        {
                            Console.WriteLine($"Baking batch number {i}...");
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"The batter should contain flour, eggs and sugar!");
                        }
                    }

                    comand = Console.ReadLine();
                }
            }
        }
    }
}
