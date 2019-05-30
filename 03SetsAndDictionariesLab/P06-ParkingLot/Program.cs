using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P06_ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            var carsIn = new HashSet<string>();

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                var inputParams = Regex.Split(input, ", ");
                if (inputParams[0] == "IN")
                {
                    carsIn.Add(inputParams[1]);
                }
                else
                {
                    carsIn.Remove(inputParams[1]);
                }
            }

            Console.WriteLine(carsIn.Count > 0 ? string.Join("\n", carsIn) : "Parking Lot is Empty");
        }
    }
}
