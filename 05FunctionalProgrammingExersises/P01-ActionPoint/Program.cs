using System;
using System.Linq;

namespace P01_ActionPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> printNames = names => Console.WriteLine(string.Join(Environment.NewLine, names));

            string[] inputName = Console.ReadLine().Split();

            printNames(inputName);
        }
    }
}
