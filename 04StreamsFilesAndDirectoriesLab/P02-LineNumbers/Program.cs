using System;
using System.IO;

namespace P02_LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new StreamReader("Input.txt");
            using (reader)
            {
                int counter = 1;
                string line = reader.ReadLine();
                using (var writer = new StreamWriter("Output.txt"))
                {
                    while (line != null)
                    {
                        writer.WriteLine($"{counter}. {line}");
                        line = reader.ReadLine();
                        counter++;
                    }
                }
            }
        }
    }
}
