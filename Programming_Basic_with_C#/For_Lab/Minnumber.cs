using System;

namespace Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int minNumber = int.MaxValue;

            for (int i = 1; i <= count; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number <= minNumber)
                {
                    minNumber = number;
                }
            }

            Console.WriteLine(minNumber);
        }
    }
}
