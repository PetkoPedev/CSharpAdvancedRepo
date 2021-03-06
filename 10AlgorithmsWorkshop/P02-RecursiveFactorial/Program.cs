﻿using System;

namespace P02_RecursiveFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(Factorial(number));
        }

        static long Factorial(int num)
        {
            if (num == 0)
            {
                return 1;
            }
            return num * Factorial(num - 1);
        }
    }
}
