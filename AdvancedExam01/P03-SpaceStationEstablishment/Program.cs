using System;

namespace P03_SpaceStationEstablishment
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[][] universe = new char[n][];

            InitializeMatrix(universe);
        }

        private static void InitializeMatrix(char[][] universe)
        {
            for (int row = 0; row < universe.Length; row++)
            {
                char[] currentRow = Console.ReadLine().ToCharArray();
                universe[row] = currentRow;
                for (int col = 0; col < currentRow.Length; col++)
                {
                    universe[row][col] = currentRow[col];
                }
            }
        }
    }
}
