using System;
using System.Collections;
using System.Collections.Generic;

namespace P01_ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var stack = new Stack<char>();
            foreach (var ch in input)
            {
                stack.Push(ch);
            }

            while (stack.Count != 0)
            {
                Console.Write(stack.Pop());
            }
            Console.WriteLine();
        }
    }
}
