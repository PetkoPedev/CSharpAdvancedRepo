using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(input);
            //TODO
            
            Console.WriteLine();
        }
    }
}
