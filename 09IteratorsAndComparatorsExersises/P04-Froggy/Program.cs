using System;
using System.Linq;

namespace P04_Froggy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Lake lake = new Lake(inputNumbers);

            Console.WriteLine(string.Join(", ", lake));
        }
    }
}
