using System;

namespace P02_KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> printSirs = names => Console.WriteLine("Sir " + string.Join(Environment.NewLine + "Sir ", names));

            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            printSirs(input);
        }
    }
}
