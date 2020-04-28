using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Person people = new Person();

            List<Person> result = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                string name = tokens[0];
                int age = int.Parse(tokens[1]);

                var person = new Person(name, age);
                result.Add(person);
            }

            result.Where(p => p.Age > 30).OrderBy(p => p.Name).ToList().ForEach(p => Console.WriteLine($"{p.Name} - {p.Age}"));
        }
    }
}
