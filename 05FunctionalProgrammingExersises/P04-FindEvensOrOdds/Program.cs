using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] range = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int lowerbound = range[0];
            int upperBound = range[1];

            List<int> numbers = new List<int>();

            string numberType = Console.ReadLine();

            for (int i = lowerbound; i <= upperBound; i++)
            {
                numbers.Add(i);
            }

            Predicate<int> isEven = number => number % 2 == 0;
            Predicate<int> isOdd = number => number % 2 != 0;
            Action<List<int>> printNumbers = x => Console.WriteLine(string.Join(" ", x));

            if (numberType == "odd")
            {
                numbers = numbers.Where(x => isOdd(x)).ToList();
            }
            else if (numberType == "even")
            {
                numbers = numbers.Where(x => isEven(x)).ToList();
            }

            printNumbers(numbers);
        }
    }
}
