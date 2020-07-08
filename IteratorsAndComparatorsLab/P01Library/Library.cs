using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        private List<Book> books;

        public IEnumerator<Book> GetEnumerator()
        {
            var libraryEnumerator = new LibraryIterator(this.books);

            return libraryEnumerator;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);
        }
    }
}
