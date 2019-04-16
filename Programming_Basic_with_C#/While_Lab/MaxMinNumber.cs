using System;

namespace Sequence
{
    class MaxMinNumber
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();
            int maxNum = int.MinValue;
            int minNum = int.MaxValue;

            while (comand!="END")
            {
                int num = int.Parse(comand);

                if (num>maxNum)
                {
                    maxNum = num;
                }

                if (num<minNum)
                {
                    minNum = num;
                }

                comand = Console.ReadLine();
            }

            Console.WriteLine($"Max number: {maxNum}");
            Console.WriteLine($"Min number: {minNum}");
        }
    }
}
