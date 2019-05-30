using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> symbolsCount = new Dictionary<char, int>();

            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                if (!symbolsCount.ContainsKey(currentChar))
                {
                    symbolsCount.Add(currentChar, 0);
                }
                symbolsCount[currentChar]++;
            }

            foreach (var item in symbolsCount.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
