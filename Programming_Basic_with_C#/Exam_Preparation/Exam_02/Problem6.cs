using System;

namespace Problem6
{
    class Program
    {
        static void Main(string[] args)
        {
            int countMen = int.Parse(Console.ReadLine());
            int countWomen = int.Parse(Console.ReadLine());
            int countTables = int.Parse(Console.ReadLine());
            int counter = 1;

            for (int i = 1; i <= countMen; i++)
            {
                for (int j = 1; j <= countWomen; j++)
                {
                    if (counter <= countTables)
                    {
                        Console.Write($"({i} <-> {j}) ");
                        counter++;
                    }
                    else
                    {
                        Console.WriteLine();
                        return;
                    }
                }
            }

            Console.WriteLine();
        }
    }
}
