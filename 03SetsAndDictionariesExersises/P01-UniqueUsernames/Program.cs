using System;
using System.Collections.Generic;

namespace P01_UniqueUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            var namesList = new HashSet<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string names = Console.ReadLine();
                namesList.Add(names);
            }

            foreach (var name in namesList)
            {
                Console.WriteLine(name);
            }
        }
    }
}
