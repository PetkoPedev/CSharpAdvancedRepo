using System;
using System.Collections.Generic;
using System.Text;

namespace _07WorkshopLab
{
    public class CustomStack
    {
        private const int initialCapacity = 4;
        private int[] items;
        private int count;

        public CustomStack()
        {
            this.count = 0;
            this.items = new int[initialCapacity];
        }

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public void Push(int element)
        {
            if (this.items.Length == this.count)
            {
                var nextItems = new int[this.items.Length * 2];
                for (int i = 0; i < this.items.Length; i++)
                {
                    nextItems[i] = this.items[i];
                }
                this.items = nextItems;
            }
            this.items[this.count] = element;
            count++;
        }

        public int Pop()
        {
            //if (this.items.Length == 0)
            //{
            //    throw new InvalidOperationException("CustomStack is empty");
            //}
            CheckIfEmpty();
            var lastIndex = this.count - 1;
            int last = this.items[lastIndex];
            this.count--;
            return last;
        }

        public int Peek()
        {
            CheckIfEmpty();

            return items[Count - 1];
        }

        private void CheckIfEmpty()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("CustomStack is empty");
            }
        }

        public void ForEach(Action<int> action)
        {
            for (int i = Count - 1; i >= 0; i--)
            {
                action(items[i]);
            }
        }
    }
}
