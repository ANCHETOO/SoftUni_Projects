using System;

namespace Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int maxNumber = int.MinValue;

            for (int i = 1; i <= count; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number >= maxNumber)
                {
                    maxNumber = number;
                }
            }

            Console.WriteLine(maxNumber);
        }
    }
}
