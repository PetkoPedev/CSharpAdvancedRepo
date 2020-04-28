using System;
using System.Linq;

namespace P02_SeashellTreasure
{
    class Program
    {
        static char[][] beach;
        

        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            beach = new char[rows][];

            Initialize();
        }

        private static void Initialize()
        {
            for (int row = 0; row < beach.Length; row++)
            {
                string[] currentRow = Console.ReadLine().Split().ToArray();

                beach[row] = currentRow;
            }
        }
    }
}
