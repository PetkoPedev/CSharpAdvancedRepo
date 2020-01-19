using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            //int length = int.Parse(Console.ReadLine());
            //
            //string[] names = Console.ReadLine().Split();
            //
            //Func<string, bool> filter = n => n <= length;

            var targetLength = int.Parse(Console.ReadLine());
            var names = Console.ReadLine().Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            Print(names, n => n.Length <= targetLength);
        }

        public static void Print(IEnumerable<string> collection, Func<string, bool> Filter)
        {
            Console.WriteLine(string.Join(Environment.NewLine, collection.Where(Filter)));
        }
    }
}
