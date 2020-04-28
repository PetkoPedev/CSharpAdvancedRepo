using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AquariumAdventure
{
    public class Aquarium
    {
        private List<Fish> fishInPool;

        public Aquarium(string name,  int capacity, int size)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.Size = size;
            this.fishInPool = new List<Fish>();
        }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Size { get; set; }

        public void Add(Fish fish)
        {
            if (!fishInPool.Contains(fish) && this.fishInPool.Count < this.Capacity)
            {
                fishInPool.Add(fish);
            }
        }

        public bool Remove(string name)
        {
            var fishToRemove = this.fishInPool.FirstOrDefault(x => x.Name == name);
            if (fishToRemove != null)
            {
                this.fishInPool.Remove(fishToRemove);
                return true;
            }
            return false;
        }

        public Fish FindFish(string name)
        {
            return this.fishInPool.FirstOrDefault(x => x.Name == name);
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Aquarium: {this.Name} ^ Size: {this.Size}");
            foreach (var fi in this.fishInPool)
            {
                sb.AppendLine(fi.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
