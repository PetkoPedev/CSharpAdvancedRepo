using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> numbers = new Queue<int>(input);
            Queue<int> result = new Queue<int>();

            foreach (var number in numbers.Where(n => n % 2 == 0))
            {
                result.Enqueue(number);
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
