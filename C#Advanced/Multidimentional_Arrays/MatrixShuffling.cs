using System;
using System.Linq;

namespace MatrixShuffling
{
    class MatrixShuffling
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                  .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                  .Select(int.Parse)
                  .ToArray();
            int rowsMatrix = size[0];
            int colsMatrix = size[1];
            string[,] matrix = new string[rowsMatrix, colsMatrix];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string[] lineInput = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = lineInput[j];
                }
            }

            string line = Console.ReadLine();

            while (line != "END")
            {
                string[] command = line
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if ((command[0] == "swap") && (command.Length == 5))
                {
                    if ((int.Parse(command[1]) >= 0) && (int.Parse(command[1]) < matrix.GetLength(0)) && (int.Parse(command[2]) >= 0) && (int.Parse(command[2]) < matrix.GetLength(1)) && (int.Parse(command[3]) >= 0) && (int.Parse(command[3]) < matrix.GetLength(0)) && (int.Parse(command[4]) >= 0) && (int.Parse(command[4]) < matrix.GetLength(1)))
                    {
                        string temp = matrix[int.Parse(command[1]), int.Parse(command[2])];
                        matrix[int.Parse(command[1]), int.Parse(command[2])] = matrix[int.Parse(command[3]), int.Parse(command[4])];
                        matrix[int.Parse(command[3]), int.Parse(command[4])] = temp;

                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                Console.Write($"{matrix[i, j]} ");
                            }

                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine($"Invalid input!");
                }

                line = Console.ReadLine();
            }
        }
    }
}
