using System;

namespace P01_GenericBoxOfStrings
{
    public class Program
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

            var result = myBox.ToString();
            Console.WriteLine(result);
        }
    }
}
