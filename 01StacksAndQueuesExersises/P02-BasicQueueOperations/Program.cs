using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] conditions = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> queue = new Queue<int>();

            int elementsToEnqueue = conditions[0];
            int elementsToDequeue = conditions[1];
            int elementToFind = conditions[2];

            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < elementsToEnqueue && i < numbers.Length; i++)
            {
                queue.Enqueue(numbers[i]);
            }

            for (int i = 0; i < elementsToDequeue && queue.Count > 0; i++)
            {
                queue.Dequeue();
            }

            Console.WriteLine(queue.Count == 0 ? "0" : queue.Contains(elementToFind) ? "true" : $"{queue.Min()}");
        }
    }
}
