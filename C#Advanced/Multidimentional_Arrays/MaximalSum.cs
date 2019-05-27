using System;
using System.Linq;

namespace MaximalSum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            int rowsMatrix = size[0];
            int colsMatrix = size[1];
            int[,] matrix = new int[rowsMatrix, colsMatrix];
            int maxSum = int.MinValue;
            int[,] matrixWithMaxSum = new int[3, 3];
            int startIndexRow = 0;
            int startIndexCol = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] line = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = line[j];
                }
            }

            for (int i = 0; i < matrix.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 2; j++)
                {
                    int sum = 0;

                    for (int k = 0; k < 3; k++)
                    {
                        for (int m = 0; m < 3; m++)
                        {
                            matrixWithMaxSum[k, m] = matrix[i + k, j + m];
                            sum += matrix[i + k, j + m];
                        }
                    }

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        startIndexRow = i;
                        startIndexCol = j;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");

            for (int i = startIndexRow; i < startIndexRow + 3; i++)
            {
                for (int j = startIndexCol; j < startIndexCol + 3; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
