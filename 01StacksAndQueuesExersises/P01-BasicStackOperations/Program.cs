using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] conditions = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>();

            int elementsToPush = conditions[0];
            int elementsToPop = conditions[1];
            int elementToFind = conditions[2];

            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < elementsToPush && i < numbers.Length; i++)
            {
                stack.Push(numbers[i]);
            }

            for (int i = 0; i < elementsToPop && stack.Count > 0; i++)
            {
                stack.Pop();
            }

            Console.WriteLine(stack.Count == 0 ? "0" : stack.Contains(elementToFind) ? "true" : $"{stack.Min()}");
        }
    }
}
