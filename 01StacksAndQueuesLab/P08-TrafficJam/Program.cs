using System;
using System.Collections.Generic;

namespace P08_TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var queue = new Queue<string>();
            int count = 0;
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                if (command == "green")
                {
                    var carsThatCanPass = Math.Min(queue.Count, n);
                    for (int counter = 0; counter < carsThatCanPass; counter++)
                    {
                        Console.WriteLine($"{queue.Dequeue()} passed!");
                        count++;
                    }
                }
                else
                    queue.Enqueue(command);
            }
            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}
