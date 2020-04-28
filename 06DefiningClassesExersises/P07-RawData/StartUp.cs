using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_RawData
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Car[] cars = new Car[n];

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] tokens = input.Split();
                string model = tokens[0];
                double engineSpeed = double.Parse(tokens[1]);
                double enginePower = double.Parse(tokens[2]);
                int cargoWeight = int.Parse(tokens[3]);
                string cargoType = tokens[4];
                double tyreOnePressure = double.Parse(tokens[5]);
                int tyreOneAge = int.Parse(tokens[6]);
                double tyreTwoPressure = double.Parse(tokens[7]);
                int tyreTwoAge = int.Parse(tokens[8]);
                double tyreThreePressure = double.Parse(tokens[9]);
                int tyreThreeAge = int.Parse(tokens[10]);
                double tyreFourPressure = double.Parse(tokens[11]);
                int tyreFourAge = int.Parse(tokens[12]);

                cars[i] = new Car(model,
                new Engine(engineSpeed, enginePower),
                new Cargo(cargoType, cargoWeight),
                new List<Tyre>
                {
                    new Tyre(tyreOnePressure, tyreOneAge),
                    new Tyre(tyreTwoPressure, tyreTwoAge),
                    new Tyre(tyreThreePressure, tyreThreeAge),
                    new Tyre(tyreFourPressure, tyreFourAge)
                });
            }

            string command = Console.ReadLine().ToLower();

            if (command == "fragile")
            {
                cars.Where(c => c.cargo.type == "fragile")
                    .Where(c => c.tyres.Any(t => t.pressure < 1))
                    .Select(c => c.model).ToList()
                    .ForEach(m => Console.WriteLine(m));
            }
            else if (command == "flamable")
            {
                cars.Where(c => c.cargo.type == "flamable")
                    .Where(c => c.engine.power > 250)
                    .Select(c => c.model).ToList()
                    .ForEach(m => Console.WriteLine(m));
            }
        }
    }
}
