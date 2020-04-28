using System;
using System.Linq;

namespace P03_GenericSwapMethodStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Box<string> myBox = new Box<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                myBox.Add(input);
            }

            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int firstIndex = indexes[0];
            int secondIndex = indexes[1];

            myBox.Swap(firstIndex, secondIndex);

            var result = myBox.ToString();
            Console.WriteLine(result);
        }
    }
}
