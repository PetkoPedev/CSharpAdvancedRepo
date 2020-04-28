using System;

namespace P02_GenericBoxOfInteger
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Box<int> myBox = new Box<int>();

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                myBox.Add(input);
            }

            string result = myBox.ToString();
            Console.WriteLine(result);
        }
    }
}
