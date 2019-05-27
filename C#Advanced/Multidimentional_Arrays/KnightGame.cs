using System;
using System.Linq;

namespace KnightGame
{
    class KnightGame
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];
            int count = 0;
            int currCount = 0;
            int tempI = 0;
            int tempJ = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string line = Console.ReadLine();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = line[j];
                }
            }

            while (true)
            {
                bool isReady = true;
                int maxCount = -1;

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[i, j] == 'K')
                        {
                            if (IsHorse(i, j, matrix))
                            {
                                isReady = false;
                                currCount = GetCount(i, j, matrix);

                                if (currCount > maxCount)
                                {
                                    maxCount = currCount;
                                    tempI = i;
                                    tempJ = j;

                                }
                            }
                        }
                    }
                }

                if (maxCount > 0)
                {
                    matrix[tempI, tempJ] = 'O';
                    count++;
                }

                if (isReady == true)
                {
                    Console.WriteLine(count);
                    return;
                }
            }
        }

        private static int GetCount(int i, int j, char[,] matrix)
        {
            int result = 0;

            if (i - 2 >= 0 && j - 1 >= 0)
            {
                if (matrix[i - 2, j - 1] == 'K')
                {
                    result++;
                }
            }

            if (i - 2 >= 0 && j + 1 < matrix.GetLength(1))
            {
                if (matrix[i - 2, j + 1] == 'K')
                {
                    result++;
                }
            }

            if (i - 1 >= 0 && j - 2 >= 0)
            {
                if (matrix[i - 1, j - 2] == 'K')
                {
                    result++;
                }
            }

            if (i - 1 >= 0 && j + 2 < matrix.GetLength(1))
            {
                if (matrix[i - 1, j + 2] == 'K')
                {
                    result++;
                }
            }

            if (i + 1 < matrix.GetLength(0) && j - 2 >= 0)
            {
                if (matrix[i + 1, j - 2] == 'K')
                {
                    result++;
                }
            }

            if (i + 1 < matrix.GetLength(0) && j + 2 < matrix.GetLength(1))
            {
                if (matrix[i + 1, j + 2] == 'K')
                {
                    result++;
                }
            }

            if (i + 2 < matrix.GetLength(0) && j + 1 < matrix.GetLength(1))
            {
                if (matrix[i + 2, j + 1] == 'K')
                {
                    result++;
                }
            }

            if (i + 2 < matrix.GetLength(0) && j - 1 >= 0)
            {
                if (matrix[i + 2, j - 1] == 'K')
                {
                    result++;
                }
            }

            return result;
        }

        private static bool IsHorse(int i, int j, char[,] matrix)
        {
            bool result = false;

            if (i - 2 >= 0 && j - 1 >= 0)
            {
                if (matrix[i - 2, j - 1] == 'K')
                {
                    result = true;
                }
            }

            if (i - 2 >= 0 && j + 1 < matrix.GetLength(1))
            {
                if (matrix[i - 2, j + 1] == 'K')
                {
                    result = true;
                }
            }

            if (i - 1 >= 0 && j - 2 >= 0)
            {
                if (matrix[i - 1, j - 2] == 'K')
                {
                    result = true;
                }
            }

            if (i - 1 >= 0 && j + 2 < matrix.GetLength(1))
            {
                if (matrix[i - 1, j + 2] == 'K')
                {
                    result = true;
                }
            }

            if (i + 1 < matrix.GetLength(0) && j - 2 >= 0)
            {
                if (matrix[i + 1, j - 2] == 'K')
                {
                    result = true;
                }
            }

            if (i + 1 < matrix.GetLength(0) && j + 2 < matrix.GetLength(1))
            {
                if (matrix[i + 1, j + 2] == 'K')
                {
                    result = true;
                }
            }

            if (i + 2 < matrix.GetLength(0) && j + 1 < matrix.GetLength(1))
            {
                if (matrix[i + 2, j + 1] == 'K')
                {
                    result = true;
                }
            }

            if (i + 2 < matrix.GetLength(0) && j - 1 >= 0)
            {
                if (matrix[i + 2, j - 1] == 'K')
                {
                    result = true;
                }
            }

            return result;
        }
    }
}

