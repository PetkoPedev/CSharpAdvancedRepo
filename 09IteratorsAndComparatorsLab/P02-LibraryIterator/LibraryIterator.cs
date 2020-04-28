using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
    public class LibraryIterator : IEnumerator<Book>
    {
        private int currentIndex;

        private Book[] books;

        public Book Current
        {
            get
            {
                return books[currentIndex];
            }
        }
        
        object IEnumerator.Current => Current;

        public void Dispose()
        {
            books = null;
        }

        public bool MoveNext()
        {
            currentIndex = currentIndex + 1;
            bool result = currentIndex < books.Length;

            return result;
        }

        public void Reset()
        {
            currentIndex = -1;
        }

        public LibraryIterator(List<Book> books)
        {
            this.books = books.ToArray();
            Reset();
        }
    }
}
