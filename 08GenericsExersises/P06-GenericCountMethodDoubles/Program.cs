using System;

namespace P06_GenericCountMethodDoubles
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Box<double> myBox = new Box<double>();

            for (int i = 0; i < n; i++)
            {
                double input = double.Parse(Console.ReadLine());
                myBox.Add(input);
            }

            double stringToCompare = double.Parse(Console.ReadLine());

            myBox.Compare(stringToCompare);

            int result = myBox.CountGreater;
            Console.WriteLine(result);
        }
    }
}
