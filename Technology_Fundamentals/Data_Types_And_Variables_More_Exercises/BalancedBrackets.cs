using System;

namespace Balanced_Brackets
{
    class BalancedBrackets
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counterLeftBrackets = 0;
            int counterRightBrackets = 0;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                if (input == "(")
                {
                    counterLeftBrackets++;
                }

                if (input == ")")
                {
                    if (counterLeftBrackets == 0)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                    else
                    {
                        counterLeftBrackets--;
                    }
                }
            }

            if (counterRightBrackets == counterLeftBrackets)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
