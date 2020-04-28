using System;
using System.Collections.Generic;
using System.Text;

namespace P02_GenericBoxOfInteger
{
    public class Box<TItem>
    {
        private List<TItem> boxCollection;

        public Box()
        {
            this.boxCollection = new List<TItem>();
        }

        public void Add(TItem item)
        {
            this.boxCollection.Add(item);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in this.boxCollection)
            {
                sb.AppendLine($"{item.GetType().FullName}: {item}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
