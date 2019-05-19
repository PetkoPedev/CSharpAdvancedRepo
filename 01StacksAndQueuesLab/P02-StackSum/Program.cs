using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var stack = new Stack<int>(input);
            
            string commands = string.Empty;

            while ((commands = Console.ReadLine().ToLower()) != "end")
            {
                string[] tokens = commands.Split();
                string command = tokens[0].ToLower();
                if (command == "add")
                {
                    int num1 = int.Parse(tokens[1]);
                    int num2 = int.Parse(tokens[2]);
                    stack.Push(num1);
                    stack.Push(num2);
                }
                else if (command == "remove")
                {
                    int numberOfElements = int.Parse(tokens[1]);
                    if (stack.Count < numberOfElements)
                    {
                        continue;
                    }
                    for (int i = 0; i < numberOfElements; i++)
                    {
                        stack.Pop();
                    }
                }
            }
            var sum = stack.Sum();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
