using System;
using System.Linq;

namespace P01_DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                int[] colElement = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = colElement[cols];
                }
            }

            int leftSum = 0;
            int rightSum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row == col)
                    {
                        leftSum += matrix[row, col];
                    }
                }
            }

            for (int i = matrix.GetLength(0); i > 0; i--)
            {
                for (int j = matrix.GetLength(1) - 1; j > 0; j--)
                {
                    if (i == j)
                    {
                        rightSum += matrix[i, j];
                    }
                }
            }

            Console.WriteLine(Math.Abs(leftSum - rightSum));
        }
    }
}
