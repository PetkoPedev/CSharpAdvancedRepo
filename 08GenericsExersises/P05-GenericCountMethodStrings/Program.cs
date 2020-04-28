using System;
using System.Linq;

namespace P05_GenericCountMethodStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Box<string> myBox = new Box<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                myBox.Add(input);
            }

            string stringToCompare = Console.ReadLine();

            myBox.Compare(stringToCompare);

            int result = myBox.CountGreater;
            Console.WriteLine(result);
        }
    }
}
