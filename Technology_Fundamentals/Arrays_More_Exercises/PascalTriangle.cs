using System;

namespace PascalTriangle
{
    class PascalTriangle
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] pascal = new int[n][];

            for (int row = 0; row < n; row++)
            {
                pascal[row] = new int[row + 1];
            }

            pascal[0][0] = 1;

            for (int s = 1; s < n; s++)
            {
                pascal[s][0] = 1;
                pascal[s][s] = 1;
            }

            for (int v = 2; v < n; v++)
            {
                for (int p = 1; p <= v - 1; p++)
                {
                    pascal[v][p] = pascal[v - 1][p - 1] + pascal[v - 1][p];
                }
            }

            for (int row = 0; row < pascal.GetLength(0); row++)
            {

                for (int col = 0; col < row + 1; col++)
                {
                    Console.Write($"{pascal[row][col]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
