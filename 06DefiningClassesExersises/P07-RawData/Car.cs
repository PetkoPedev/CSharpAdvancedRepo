using System;
using System.Collections.Generic;
using System.Text;

namespace P07_RawData
{
    public class Car
    {
        public string model;
        public Engine engine;
        public Cargo cargo;
        public List<Tyre> tyres;

        public Car(string model, Engine engine, Cargo cargo, List<Tyre> tyres)
        {
            this.model = model;
            this.engine = engine;
            this.cargo = cargo;
            this.tyres = tyres;
        }
    }
}
