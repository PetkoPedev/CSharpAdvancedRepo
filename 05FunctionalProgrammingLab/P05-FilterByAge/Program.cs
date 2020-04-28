using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_FilterByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<KeyValuePair<string, int>> people = new List<KeyValuePair<string, int>>(); 

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(", ")
                    .ToArray();

                string name = tokens[0];
                int age = int.Parse(tokens[1]);

                people.Add(new KeyValuePair<string, int>(name, age));
            }

            string condition = Console.ReadLine();
            int ageToShow = int.Parse(Console.ReadLine());
            string[] format = Console.ReadLine().Split();

            people.Where(p => condition == "younger" ? p.Value <= ageToShow : p.Value >= ageToShow)
                .ToList()
                .ForEach(p => Printer(p, format));
        }

        static void Printer(KeyValuePair<string, int> person, string[] printPattern)
        {
            if (printPattern.Length == 2)
            {
                Console.WriteLine(printPattern[0] == "name" ? $"{person.Key} - {person.Value}" : $"{person.Value} - {person.Key}");
            }
            else
            {
                Console.WriteLine(printPattern[0] == "name" ? $"{person.Key}" : $"{person.Value}");
            }
        }
    }
}
