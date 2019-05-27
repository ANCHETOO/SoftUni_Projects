using System;
using System.Linq;

namespace BombTheBasement
{
    class BombTheBasement
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                   .Select(int.Parse)
                   .ToArray();
            int rowsMatrix = size[0];
            int colsMatrix = size[1];
            char[,] matrix = new char[rowsMatrix, colsMatrix];
            int[] secondLine = Console.ReadLine()
                  .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                  .Select(int.Parse)
                  .ToArray();
            int rowIndex = secondLine[0];
            int colIndex = secondLine[1];
            int detonatePower = secondLine[2];
            int detonateLenght = secondLine[2];


            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (colIndex - detonatePower <= j && j <= colIndex + detonatePower && i <= (2 * detonateLenght + 1))
                    {
                        matrix[i, j] = '1';
                    }
                    else
                    {
                        matrix[i, j] = '0';
                    }

                    Console.Write($"{matrix[i, j]}");
                }

                if (i % 2 == 0)
                {
                    detonatePower--;
                }

                Console.WriteLine();
            }
        }
    }
}
