using System;

namespace War_Of_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();
            int maxSum = int.MinValue;
            string winner = string.Empty;

            while (comand != "STOP")
            {
                if (GetAscii(comand) >= maxSum)
                {
                    maxSum = GetAscii(comand);
                    winner = comand;
                }

                comand = Console.ReadLine();
            }

            Console.WriteLine($"Winner is {winner} - {maxSum}!");

        }

        static int GetAscii(string name)
        {
            int result = 0;

            for (int i = 0; i < name.Length; i++)
            {
                char letter = name[i];
                result += letter;
            }

            return result;
        }
    }
}
