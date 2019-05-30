using System;
using System.Collections.Generic;

namespace P03_PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SortedSet<string> chemicals = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                for (int j = 0; j < input.Length; j++)
                {
                    chemicals.Add(input[j]);
                }
            }

            Console.WriteLine(string.Join(" ", chemicals));
        }
    }
}
