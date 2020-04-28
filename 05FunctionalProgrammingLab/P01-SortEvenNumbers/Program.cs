using System;
using System.Linq;

namespace P01_SortEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(", ")
                .Select(n => int.Parse(n))
                .Where(n => n % 2 == 0)
                .OrderBy(n => n)
                .ToArray();

            string result = string.Join(", ", numbers);
            Console.WriteLine(result);
        }
    }
}
