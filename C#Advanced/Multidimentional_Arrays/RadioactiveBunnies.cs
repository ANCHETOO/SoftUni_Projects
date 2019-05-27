using System;
using System.Linq;
using System.Collections.Generic;

namespace RadioactiveBunnies
{
    class RadioactiveBunnies
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rolls = sizes[0];
            int cols = sizes[1];
            var matrix = new char[rolls, cols];
            int x = 0;
            int y = 0;

            for (int i = 0; i < rolls; i++)
            {
                string line = Console.ReadLine();

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = line[j];

                    if (matrix[i, j] == 'P')
                    {
                        x = i;
                        y = j;
                        matrix[i, j] = '.';
                    }
                }
            }

            char[] moves = Console.ReadLine().ToCharArray();

            for (int i = 0; i < moves.Length; i++)
            {
                char curr = moves[i];

                UpDateBunnies(matrix);

                switch (curr)
                {
                    case 'R':
                        {
                            if (y + 1 < cols)
                            {
                                y = y + 1;
                            }
                            else
                            {
                                PrintMatrix(matrix);
                                Console.WriteLine($"won: {x} {y}");
                                return;
                            }

                            break;
                        }
                    case 'L':
                        {
                            if (y - 1 >= 0)
                            {
                                y = y - 1;
                            }
                            else
                            {
                                PrintMatrix(matrix);
                                Console.WriteLine($"won: {x} {y}");
                                return;
                            }

                            break;
                        }
                    case 'U':
                        {
                            if (x - 1 >= 0)
                            {
                                x = x - 1;
                            }
                            else
                            {
                                PrintMatrix(matrix);
                                Console.WriteLine($"won: {x} {y}");
                                return;
                            }

                            break;
                        }
                    case 'D':
                        {
                            if (x + 1 < rolls)
                            {
                                x = x + 1;
                            }
                            else
                            {
                                PrintMatrix(matrix);
                                Console.WriteLine($"won: {x} {y}");
                                return;
                            }

                            break;
                        }
                    default:
                        break;
                }

                if (matrix[x, y] == 'B')
                {
                    PrintMatrix(matrix);
                    Console.WriteLine($"dead: {x} {y}");
                    return;
                }
            }

        }

        private static void UpDateBunnies(char[,] matrix)
        {
            var newMatrix = new char[matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 'B')
                    {
                        newMatrix[i, j] = 'B';

                        if (i - 1 >= 0)
                        {
                            newMatrix[i - 1, j] = 'B';
                        }

                        if (j - 1 >= 0)
                        {
                            newMatrix[i, j - 1] = 'B';
                        }

                        if (j + 1 < matrix.GetLength(1))
                        {
                            newMatrix[i, j + 1] = 'B';
                        }

                        if (i + 1 < matrix.GetLength(0))
                        {
                            newMatrix[i + 1, j] = 'B';
                        }
                    }
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (newMatrix[i, j] == 'B')
                    {
                        matrix[i, j] = 'B';
                    }
                }
            }
        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}");
                }

                Console.WriteLine();
            }
        }
    }
}
