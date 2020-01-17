using System;
using System.Collections.Generic;

namespace P06_Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = string.Empty;
            Queue<string> people = new Queue<string>();
            Queue<string> paidPeople = new Queue<string>();

            while ((line = Console.ReadLine()) != "End")
            {
                if (line == "Paid")
                {
                    foreach (var p in people)
                    {
                        paidPeople.Enqueue(p);
                        Console.WriteLine(p);
                    }
                    people.Clear();
                }
                else
                {
                    people.Enqueue(line);
                }
            }

            Console.WriteLine($"{people.Count} people remaining.");
        }
    }
}
