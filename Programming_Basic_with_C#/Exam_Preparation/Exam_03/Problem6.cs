using System;

namespace Problem6
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int lastDigid = int.Parse(number[2].ToString());
            int middleDigid = int.Parse(number[1].ToString());
            int firstDigid = int.Parse(number[0].ToString());

            for (int i = 1; i <= lastDigid; i++)
            {
                for (int j = 1; j <= middleDigid; j++)
                {
                    for (int k = 1; k <= firstDigid; k++)
                    {
                        Console.WriteLine($"{i} * {j} * {k} = {(i * j * k)};");
                    }
                }
            }
        }
    }
}
