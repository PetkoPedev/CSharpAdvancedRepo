﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> numbers = new Dictionary<int, int>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (!numbers.ContainsKey(currentNumber))
                {
                    numbers.Add(currentNumber, 0);
                }
                numbers[currentNumber]++;
            }

            int evenTimesNumber = numbers
                .Where(n => n.Value % 2 == 0)
                .SingleOrDefault()
                .Key;

            Console.WriteLine(evenTimesNumber);
        }
    }
}
