using System;
using System.Linq;

namespace P05_SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimention = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = dimention[0];
            int cols = dimention[1];

            char[,] matrix = new char[rows, cols];

            string snake = Console.ReadLine();

            int counter = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (counter >= snake.Length)
                    {
                        counter = 0;
                    }

                    matrix[row, col] = snake[counter++];
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
