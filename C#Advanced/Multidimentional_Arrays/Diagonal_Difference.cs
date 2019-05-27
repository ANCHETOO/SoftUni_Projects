using System;
using System.Linq;

namespace Diagonal_Difference
{
    class Diagonal_Difference
    {
        static void Main(string[] args)
        {
            int sizeMatrix = int.Parse(Console.ReadLine());
            int[,] matrix = new int[sizeMatrix, sizeMatrix];
            int sumDiagonalLeftToRight = 0;
            int sumDiagonalRightToLeft = 0;

            for (int i = 0; i < sizeMatrix; i++)
            {
                var line = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int j = 0; j < sizeMatrix; j++)
                {
                    matrix[i, j] = line[j];

                    if (i == j)
                    {
                        sumDiagonalLeftToRight += matrix[i, j];
                    }

                    if (i + j + 1 == sizeMatrix)
                    {
                        sumDiagonalRightToLeft += matrix[i, j];
                    }
                }
            }

            Console.WriteLine(Math.Abs(sumDiagonalLeftToRight - sumDiagonalRightToLeft));
        }
    }
}
