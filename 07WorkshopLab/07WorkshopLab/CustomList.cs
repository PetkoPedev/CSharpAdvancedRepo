using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07WorkshopLab
{
    public class CustomList
    {
        /// <summary>
        /// Default size of internal array
        /// </summary>
        private const int InitialCapacity = 2;

        /// <summary>
        /// Internal array
        /// </summary>
        private int[] items;

        /// <summary>
        /// Creates custom integer list with default size
        /// </summary>
        public CustomList()
        {
            this.items = new int[InitialCapacity];
        }

        /// <summary>
        /// Creates custom integer list with initial size
        /// </summary>
        /// <param name="initialSize">Initial size of the list</param>
        public CustomList(int initialSize)
        {
            items = new int[initialSize];
        }

        /// <summary>
        /// Number of elements in the list
        /// </summary>
        public int Count { get; private set; }

        /// <summary>
        /// Indexer that gives access to the items in the collection 
        /// without exposing the internal array.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public int this[int index]
        {
            get
            {
                if (index >= this.Count)
                {
                    throw new ArgumentException();
                }
                return items[index];
            }
            set
            {
                if (index >= this.Count)
                {
                    throw new ArgumentException();
                }
                items[index] = value;
            }
        }

        /// <summary>
        /// Private method that resizes the collection
        /// </summary>
        private void Resize()
        {
            int[] copy = new int[this.items.Length * 2];

            for (int i = 0; i < this.items.Length; i++)
            {
                copy[i] = this.items[i];
            }
            this.items = copy;
            
        }

        /// <summary>
        /// Adds a new element to the end of the collection
        /// </summary>
        /// <param name="item"></param>
        public void Add(int item)
        {
            if (this.Count == this.items.Length)
            {
                this.Resize();
            }

            this.items[this.Count] = item;
            this.Count++;
        }

        private void Shift(int index)
        {
            for (int i = index; i < this.Count - 1; i++)
            {
                this.items[i] = this.items[i + 1];
            }
        }

        /// <summary>
        /// Shrinks the collection twice
        /// </summary>
        private void Shrink()
        {
            int[] copy = new int[this.items.Length / 2];
            for (int i = 0; i < this.Count; i++)
            {
                copy[i] = this.items[i];
            }
            this.items = copy;
        }

        /// <summary>
        /// Removes an element from the collection at the index provided
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public int RemoveAt(int index)
        {
            if (index >= this.Count)
            {
                throw new ArgumentException();
            }

            var item = this.items[index];
            this.items[index] = default(int);
            this.Shift(index);

            this.Count--;
            if (this.Count<= this.items.Length/4)
            {
                this.Shrink();
            }
            return item;
        }

        private void ShiftToRight(int index)
        {
            for (int i = Count; i > index; i--)
            {
                this.items[i] = this.items[i - 1];
            }
        }

        private void CheckIndexRange(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new IndexOutOfRangeException();
            }
        }
        /// <summary>
        /// Insert an element at a given index
        /// </summary>
        /// <param name="index"></param>
        /// <param name="element"></param>
        public void Insert(int index, int element)
        {
            if (index > this.Count)
            {
                throw new IndexOutOfRangeException();
            }
            if (this.Count == this.items.Length)
            {
                this.Resize();
            }
            this.ShiftToRight(index);
            this.items[index] = element;
            this.Count++;
        }

        public bool Contains(int element)
        {
            bool result = false;

            for (int i = 0; i < Count; i++)
            {
                if (items[i] == element)
                {
                    result = true;
                    break;
                }
            }

            return result;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            CheckIndexRange(firstIndex);
            CheckIndexRange(secondIndex);
            int tempElement = items[firstIndex];
            items[firstIndex] = items[secondIndex];
            items[secondIndex] = tempElement;
        }

        public void ForEach(Action<int> action)
        {
            for (int i = 0; i < Count - 1; i++)
            {
                action(items[i]);
            }
        }
    }
}
