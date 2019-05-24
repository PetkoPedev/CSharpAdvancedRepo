using System;
using System.Linq;

namespace P05_SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizeOfMatrix = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = sizeOfMatrix[0];
            int columns = sizeOfMatrix[1];

            int[,] matrix = new int[rows, columns];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElement = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElement[col];
                }
            }

            int maxSum = int.MinValue;
            int selectedRow = -1;
            int selectedCol = -1;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    var newSquareSum = matrix[row, col] +
                                       matrix[row + 1, col] +
                                       matrix[row, col + 1] +
                                       matrix[row + 1, col + 1];
                    if (newSquareSum > maxSum)
                    {
                        maxSum = newSquareSum;
                        selectedCol = col;
                        selectedRow = row;
                    }
                }
            }

            Console.WriteLine($"{matrix[selectedRow, selectedCol]} " +
                $"{matrix[selectedRow, selectedCol + 1]}\n" +
                $"{matrix[selectedRow + 1, selectedCol]} " +
                $"{matrix[selectedRow + 1, selectedCol + 1]}\n{maxSum}");
        }
    }
}
