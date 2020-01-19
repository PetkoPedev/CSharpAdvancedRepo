using System;
using System.Linq;

namespace P05_AppliedArithmetics
{
    class Program
    {
        public delegate void Print(int x);

        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Func<int, int> incrementByOne = x => x += 1;
            Func<int, int> substract = x => x -= 1;
            Func<int, int> multiply = x => x *= 2;
            Action<int[]> print = numbers => Console.WriteLine(string.Join(" ", numbers));

            string command = Console.ReadLine();

            while (command != "end")
            {
                if (command == "add")
                {
                    inputNumbers = inputNumbers.Select(incrementByOne).ToArray();
                }
                else if (command == "multiply")
                {
                    inputNumbers = inputNumbers.Select(multiply).ToArray();
                }
                else if (command == "subtract")
                {
                    inputNumbers = inputNumbers.Select(substract).ToArray();
                }
                else if (command == "print")
                {
                    print(inputNumbers);
                }

                command = Console.ReadLine();
            }
        }
    }
}
