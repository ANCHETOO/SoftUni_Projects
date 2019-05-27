using System;
using System.Linq;

namespace SnakeMoves
{
    class SnakeMoves
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
            string snake = Console.ReadLine();
            int index = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = snake[index];
                    Console.Write($"{matrix[i, j]}");
                    index++;

                    if (index == snake.Length)
                    {
                        index = 0;
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
