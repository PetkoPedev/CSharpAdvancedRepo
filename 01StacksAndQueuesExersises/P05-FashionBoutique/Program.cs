using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>(clothes);

            int capacity = int.Parse(Console.ReadLine());
            int sum = 0;
            int racksNumber = 1;

            while (stack.Count > 0)
            {
                sum += stack.Peek();
                if (sum <= capacity)
                {
                    stack.Pop();
                }
                else
                {
                    racksNumber++;
                    sum = 0;
                }
            }
            Console.WriteLine(racksNumber);
        }
    }
}
