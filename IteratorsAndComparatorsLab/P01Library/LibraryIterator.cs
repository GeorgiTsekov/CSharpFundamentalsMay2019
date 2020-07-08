using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
    public class LibraryIterator : IEnumerator<Book>
    {
        private int currentIndex;

        private readonly List<Book> books;

        public Book Current => books[this.currentIndex];

        object IEnumerator.Current => this.Current;

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            currentIndex++;
            bool result = currentIndex < books.Count;
            return result;
        }

        public void Reset()
        {
            currentIndex = -1;
        }

        public LibraryIterator(IEnumerable<Book> books)
        {
            this.Reset();
            this.books = new List<Book>(books);
        }
    }
}
