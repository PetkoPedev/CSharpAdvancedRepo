using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceStationRecruitment
{
    public class SpaceStation
    {
        public SpaceStation(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.astronauts = new List<Astronaut>();
        }

        List<Astronaut> astronauts;

        public string Name { get; set; }
        public int Capacity { get; set; }

        public int Count => this.astronauts.Count;

        public void Add(Astronaut astronaut)
        {
            if (this.Capacity >= astronauts.Count)
            {
                this.astronauts.Add(astronaut);
            }
        }

        public void Remove(string name)
        {
            Astronaut astronautToRemove = this.astronauts.FirstOrDefault(x => x.Name == name);
            this.astronauts.Remove(astronautToRemove);
        }

        public Astronaut GetOldestAstronaut()
        {
            Astronaut astronaut = this.astronauts.OrderByDescending(x => x.Age).FirstOrDefault();
            return astronaut;
        }

        public Astronaut GetAstronaut(string name)
        {
            Astronaut astronaut = this.astronauts.FirstOrDefault(x => x.Name == name);
            return astronaut;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Astronauts working at Space Station {this.Name}:");
            foreach (var astro in astronauts)
            {
                sb.AppendLine($"{astro.ToString()}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
