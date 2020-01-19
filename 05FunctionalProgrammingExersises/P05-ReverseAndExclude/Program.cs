using System;
using System.Collections.Generic;
using System.Linq;

namespace P06_ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int divisor = int.Parse(Console.ReadLine());

            Func<int, bool> filter = n => n % divisor != 0;

            var remainingNumbers = input.Reverse().Where(filter);

            Console.WriteLine(string.Join(" ", remainingNumbers));
        }
    }
}
