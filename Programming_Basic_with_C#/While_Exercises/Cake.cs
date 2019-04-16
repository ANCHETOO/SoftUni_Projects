using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            string comand = string.Empty;
            int pieces = width * length;
            comand = Console.ReadLine();

            while (comand != "STOP")
            {
                pieces -= int.Parse(comand);

                if (pieces < 0)
                {
                    Console.WriteLine($"No more cake left! You need {-pieces} pieces more.");
                    return;
                }

                comand = Console.ReadLine();
            }

            Console.WriteLine($"{pieces} pieces are left.");
        }
    }
}
