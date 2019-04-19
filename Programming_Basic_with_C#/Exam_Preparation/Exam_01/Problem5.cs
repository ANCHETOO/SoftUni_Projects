using System;

namespace Problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            int points = 0;
            int difference = 0;

            for (int i = 1; i <= count; i++)
            {
                int goalsSuccess = int.Parse(Console.ReadLine());
                int goalsNotsuccess = int.Parse(Console.ReadLine());

                difference += goalsSuccess - goalsNotsuccess;

                if (goalsSuccess > goalsNotsuccess)
                {
                    points += 3;
                }
                else if (goalsSuccess == goalsNotsuccess)
                {
                    points += 1;
                }
            }

            if (difference >= 0)
            {
                Console.WriteLine($"{name} has finished the group phase with {points} points.");
                Console.WriteLine($"Goal difference: {difference}.");
            }
            else
            {
                Console.WriteLine($"{name} has been eliminated from the group phase.");
                Console.WriteLine($"Goal difference: {difference}.");
            }
        }
    }
}
