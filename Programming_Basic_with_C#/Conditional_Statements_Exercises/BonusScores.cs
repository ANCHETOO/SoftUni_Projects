using System;

namespace Bonus_Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double bonusScores = 0.0;
            double totalScores = 0.0;

            if (num <= 100)
            {
                bonusScores += 5;
            }
            else if (100 < num && num <= 1_000)
            {
                bonusScores += 0.20 * num;
            }
            else if (num>1_000)
            {
                bonusScores += 0.10 * num;
            }
            if (num%2==0)
            {
                bonusScores += 1;
            }
            else if (num%10==5)
            {
                bonusScores += 2;
            }

            totalScores = num + bonusScores;

            Console.WriteLine(bonusScores);
            Console.WriteLine(totalScores);
        }
    }
}
