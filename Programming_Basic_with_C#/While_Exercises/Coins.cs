using System;

namespace Coins
{
    class Coins
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            input = input * 100;

            int counter = 0;

            int coin = 0;
            if (input >= 200)
            {
                coin = (int)(input / 200);
                counter += coin;
                input = input % 200;
            }

            if (input >= 100)
            {
                coin = (int)(input / 100);
                counter += coin;
                input = input % 100;
            }

            if (input >= 50)
            {
                coin = (int)(input / 50);
                counter += coin;
                input = input % 50;
            }

            if (input >= 20)
            {
                coin = (int)(input / 20);
                counter += coin;
                input = input % 20;
            }

            if (input >= 10)
            {
                coin = (int)(input / 10);
                counter += coin;
                input = input % 10;
            }

            if (input >= 5)
            {
                coin = (int)(input / 5);
                counter += coin;
                input = input % 5;
            }

            if (input >= 2)
            {
                coin = (int)(input / 2);
                counter += coin;
                input = input % 2;
            }

            if (input >= 1)
            {
                coin = (int)(input / 1);
                counter += coin;
                input = input % 1;
            }

            Console.WriteLine(counter);
        }
    }
}
